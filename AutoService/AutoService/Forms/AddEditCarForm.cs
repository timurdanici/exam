using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoService.Models;

namespace AutoService.Forms
{
    public partial class AddEditCarForm : Form
    {
        public Car Car { get; private set; }

        private readonly List<Client> _clients;

        public AddEditCarForm(List<Client> clients, Car car = null)
        {
            InitializeComponent();

            _clients = clients;

            // Populate client ComboBox
            cmbClient.DataSource    = _clients;
            cmbClient.DisplayMember = "FullName";
            cmbClient.ValueMember   = "Id";

            if (car != null)
            {
                Text             = "Редактировать автомобиль";
                txtBrand.Text    = car.Brand;
                txtModel.Text    = car.Model;
                txtYear.Text     = car.Year.ToString();
                txtLicensePlate.Text = car.LicensePlate;
                cmbClient.SelectedValue = car.ClientId;
                Car = car;
            }
            else
            {
                Text = "Добавить автомобиль";
                Car  = new Car();
                if (_clients.Count > 0)
                    cmbClient.SelectedIndex = 0;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Введите марку автомобиля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBrand.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Введите модель автомобиля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModel.Focus();
                return;
            }

            if (!int.TryParse(txtYear.Text.Trim(), out int year) || year < 1900 || year > DateTime.Now.Year + 1)
            {
                MessageBox.Show($"Введите корректный год выпуска (1900–{DateTime.Now.Year + 1}).",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYear.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLicensePlate.Text))
            {
                MessageBox.Show("Введите государственный номер.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicensePlate.Focus();
                return;
            }

            if (cmbClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClient.Focus();
                return;
            }

            Car.Brand        = txtBrand.Text.Trim();
            Car.Model        = txtModel.Text.Trim();
            Car.Year         = year;
            Car.LicensePlate = txtLicensePlate.Text.Trim();
            Car.ClientId     = (int)cmbClient.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
