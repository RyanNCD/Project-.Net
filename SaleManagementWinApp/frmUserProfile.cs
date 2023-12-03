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
    public partial class frmUserProfile : Form
    {
        ICustomerRepository repository = new CustomerRepository();
        public frmUserProfile()
        {
            InitializeComponent();
        }

        public Customer CurrentCustomer { get; set; }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            try
            {
                txtEmail.Text = CurrentCustomer.Email;
                txtPassword.Text = CurrentCustomer.Password;
                txtCustomerName.Text = CurrentCustomer.CustomerName;
                txtCity.Text = CurrentCustomer.City;
                txtCountry.Text = CurrentCustomer.Country;
                dtpBirthday.Value = (DateTime)CurrentCustomer.Birthday;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Customers");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("All fields are required!", "Customer Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Customer
                {
                    CustomerId = CurrentCustomer.CustomerId,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CustomerName = txtCustomerName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Birthday = dtpBirthday.Value
                };
                repository.UpdateCustomer(p);
                MessageBox.Show("Save succesful", "Profile",
                    MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
