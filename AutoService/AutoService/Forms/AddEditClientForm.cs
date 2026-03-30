using System;
using System.Windows.Forms;
using AutoService.Models;

namespace AutoService.Forms
{
    public partial class AddEditClientForm : Form
    {
        public Client Client { get; private set; }

        public AddEditClientForm(Client client = null)
        {
            InitializeComponent();

            if (client != null)
            {
                Text = "Редактировать клиента";
                txtLastName.Text  = client.LastName;
                txtFirstName.Text = client.FirstName;
                txtPhone.Text     = client.Phone;
                txtAddress.Text   = client.Address;
                Client = client;
            }
            else
            {
                Text = "Добавить клиента";
                Client = new Client();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введите фамилию клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Введите имя клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            Client.LastName  = txtLastName.Text.Trim();
            Client.FirstName = txtFirstName.Text.Trim();
            Client.Phone     = txtPhone.Text.Trim();
            Client.Address   = txtAddress.Text.Trim();

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
