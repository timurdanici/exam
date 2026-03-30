using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AutoService.Data;
using AutoService.Models;

namespace AutoService.Forms
{
    public partial class MainForm : Form
    {
        private readonly ClientRepository _clientRepo = new ClientRepository();
        private readonly CarRepository    _carRepo    = new CarRepository();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadCars();
            LoadReport();
        }

        // =============================================
        // CLIENTS TAB
        // =============================================

        private void LoadClients()
        {
            try
            {
                var clients = _clientRepo.GetAll();
                dgvClients.DataSource = null;

                var dt = new DataTable();
                dt.Columns.Add("ID",       typeof(int));
                dt.Columns.Add("Фамилия",  typeof(string));
                dt.Columns.Add("Имя",      typeof(string));
                dt.Columns.Add("Телефон",  typeof(string));
                dt.Columns.Add("Адрес",    typeof(string));

                foreach (var c in clients)
                    dt.Rows.Add(c.Id, c.LastName, c.FirstName, c.Phone, c.Address);

                dgvClients.DataSource = dt;

                if (dgvClients.Columns.Count > 0)
                    dgvClients.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                ShowError("Ошибка загрузки клиентов", ex);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditClientForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        _clientRepo.Add(form.Client);
                        LoadClients();
                        LoadReport();
                    }
                    catch (Exception ex)
                    {
                        ShowError("Ошибка добавления клиента", ex);
                    }
                }
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            var client = GetSelectedClient();
            if (client == null) return;

            using (var form = new AddEditClientForm(client))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        _clientRepo.Update(form.Client);
                        LoadClients();
                        LoadReport();
                    }
                    catch (Exception ex)
                    {
                        ShowError("Ошибка редактирования клиента", ex);
                    }
                }
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            var client = GetSelectedClient();
            if (client == null) return;

            var result = MessageBox.Show(
                $"Удалить клиента «{client.FullName}»?\n(Все его автомобили также будут удалены.)",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _clientRepo.Delete(client.Id);
                    LoadClients();
                    LoadCars();
                    LoadReport();
                }
                catch (Exception ex)
                {
                    ShowError("Ошибка удаления клиента", ex);
                }
            }
        }

        private void btnRefreshClients_Click(object sender, EventArgs e)
        {
            LoadClients();
        }

        private Client GetSelectedClient()
        {
            if (dgvClients.CurrentRow == null)
            {
                MessageBox.Show("Выберите клиента в таблице.", "Нет выбора",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            var row = dgvClients.CurrentRow;
            return new Client
            {
                Id        = (int)row.Cells["ID"].Value,
                LastName  = row.Cells["Фамилия"].Value?.ToString(),
                FirstName = row.Cells["Имя"].Value?.ToString(),
                Phone     = row.Cells["Телефон"].Value?.ToString(),
                Address   = row.Cells["Адрес"].Value?.ToString()
            };
        }

        // =============================================
        // CARS TAB
        // =============================================

        private void LoadCars(string search = null)
        {
            try
            {
                List<Car> cars;

                if (string.IsNullOrWhiteSpace(search))
                    cars = _carRepo.GetAll();
                else
                    cars = _carRepo.Search(search);

                dgvCars.DataSource = null;

                var dt = new DataTable();
                dt.Columns.Add("ID",          typeof(int));
                dt.Columns.Add("Марка",       typeof(string));
                dt.Columns.Add("Модель",      typeof(string));
                dt.Columns.Add("Год выпуска", typeof(int));
                dt.Columns.Add("Гос. номер",  typeof(string));
                dt.Columns.Add("Клиент",      typeof(string));
                dt.Columns.Add("ID_клиента",  typeof(int));

                foreach (var c in cars)
                    dt.Rows.Add(c.Id, c.Brand, c.Model, c.Year, c.LicensePlate, c.ClientName, c.ClientId);

                dgvCars.DataSource = dt;

                if (dgvCars.Columns.Count > 0)
                {
                    dgvCars.Columns["ID"].Visible         = false;
                    dgvCars.Columns["ID_клиента"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка загрузки автомобилей", ex);
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var clients = _clientRepo.GetAll();
            if (clients.Count == 0)
            {
                MessageBox.Show("Сначала добавьте хотя бы одного клиента.",
                    "Нет клиентов", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var form = new AddEditCarForm(clients))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        _carRepo.Add(form.Car);
                        LoadCars(txtSearch.Text);
                        LoadReport();
                    }
                    catch (Exception ex)
                    {
                        ShowError("Ошибка добавления автомобиля", ex);
                    }
                }
            }
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            var car = GetSelectedCar();
            if (car == null) return;

            var clients = _clientRepo.GetAll();
            using (var form = new AddEditCarForm(clients, car))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        _carRepo.Update(form.Car);
                        LoadCars(txtSearch.Text);
                        LoadReport();
                    }
                    catch (Exception ex)
                    {
                        ShowError("Ошибка редактирования автомобиля", ex);
                    }
                }
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            var car = GetSelectedCar();
            if (car == null) return;

            var result = MessageBox.Show(
                $"Удалить автомобиль «{car.Brand} {car.Model} ({car.LicensePlate})»?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _carRepo.Delete(car.Id);
                    LoadCars(txtSearch.Text);
                    LoadReport();
                }
                catch (Exception ex)
                {
                    ShowError("Ошибка удаления автомобиля", ex);
                }
            }
        }

        private void btnRefreshCars_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadCars();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCars(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadCars(txtSearch.Text);
        }

        private Car GetSelectedCar()
        {
            if (dgvCars.CurrentRow == null)
            {
                MessageBox.Show("Выберите автомобиль в таблице.", "Нет выбора",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            var row = dgvCars.CurrentRow;
            return new Car
            {
                Id           = (int)row.Cells["ID"].Value,
                Brand        = row.Cells["Марка"].Value?.ToString(),
                Model        = row.Cells["Модель"].Value?.ToString(),
                Year         = Convert.ToInt32(row.Cells["Год выпуска"].Value),
                LicensePlate = row.Cells["Гос. номер"].Value?.ToString(),
                ClientId     = Convert.ToInt32(row.Cells["ID_клиента"].Value),
                ClientName   = row.Cells["Клиент"].Value?.ToString()
            };
        }

        // =============================================
        // REPORT TAB
        // =============================================

        private void LoadReport()
        {
            try
            {
                var data = _carRepo.GetReport();
                dgvReport.DataSource = null;

                var dt = new DataTable();
                dt.Columns.Add("Клиент",      typeof(string));
                dt.Columns.Add("Марка",       typeof(string));
                dt.Columns.Add("Модель",      typeof(string));
                dt.Columns.Add("Год выпуска", typeof(string));
                dt.Columns.Add("Гос. номер",  typeof(string));

                foreach (var r in data)
                    dt.Rows.Add(
                        r.ClientName,
                        r.Brand,
                        r.Model,
                        r.Year == 0 ? "—" : r.Year.ToString(),
                        string.IsNullOrEmpty(r.LicensePlate) ? "—" : r.LicensePlate);

                dgvReport.DataSource = dt;
            }
            catch (Exception ex)
            {
                ShowError("Ошибка загрузки отчёта", ex);
            }
        }

        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        // =============================================
        // HELPERS
        // =============================================

        private static void ShowError(string message, Exception ex)
        {
            MessageBox.Show($"{message}:\n{ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
