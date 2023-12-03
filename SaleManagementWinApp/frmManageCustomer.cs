using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmManageCustomer : Form
    {
        ICustomerRepository repository = new CustomerRepository();
        public frmManageCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Create")
            {
                btnCreate.Text = "Cancel";
                btnSave.Enabled = true;

                txtCustomerID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCustomerName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                dtpBirthday.DataBindings.Clear();
                ClearText();
            }
            else
            {
                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadCustomerList();
            }
        }

        private void ClearText()
        {
            txtCustomerID.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtCustomerName.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            dtpBirthday.Value = DateTime.Now;
        }

        private Boolean CheckExist(int Id)
        {
            foreach (var item in repository.GetCustomers())
            {
                if (item.CustomerId == int.Parse(txtCustomerID.Text))
                {
                    MessageBox.Show("ID were exist");
                    return true;
                }
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckExist(int.Parse(txtCustomerID.Text)))
            {
                btnSave.Enabled = false;
                btnCreate.Text = "Create";
                LoadCustomerList();
            }
            else if (txtCustomerID.Text == "" || txtCustomerName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("All fields are required!", "Customer Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Customer
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CustomerName = txtCustomerName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Birthday = dtpBirthday.Value
                };
                repository.SaveCustomer(p);

                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadCustomerList();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "" || txtCustomerName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("All fields are required!", "Customer Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Customer
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CustomerName = txtCustomerName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Birthday = dtpBirthday.Value
                };
                repository.UpdateCustomer(p);

                LoadCustomerList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Customer Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var c = new Customer
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                };
                repository.DeleteCustomer(c);
                LoadCustomerList();
            }
        }

        private void frmManageCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void LoadCustomerList()
        {
            try
            {
                var CustomerList = repository.GetCustomers();
                BindingSource source = new BindingSource();
                source.DataSource = CustomerList;

                txtCustomerID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCustomerName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                dtpBirthday.DataBindings.Clear();

                txtCustomerID.DataBindings.Add("Text", source, "CustomerId");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCustomerName.DataBindings.Add("Text", source, "CustomerName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                dtpBirthday.DataBindings.Add("Value", source, "Birthday");

                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Customers");
            }
        }
    }
}
