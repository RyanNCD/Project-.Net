using BusinessObjects;
using DataAccessObjects;
using Microsoft.Extensions.Configuration;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        ICustomerRepository repo = new CustomerRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Customer CurrentCus = CustomerDAO.GetCustomerByEmail(txtEmail.Text);
            Boolean CheckAdmin = false;
            IConfiguration config = new ConfigurationBuilder()
                           .SetBasePath(Directory.GetCurrentDirectory())
                           .AddJsonFile("appsettings.json", true, true)
                           .Build();
            var adminEmail = config["AdminAccount:Email"];
            var adminPassword = config["AdminAccount:Password"];
            if (adminEmail.Equals(txtEmail.Text) && adminPassword.Equals(txtPassword.Text))
            {
                frmAdmin frm = new frmAdmin();
                frm.Show();
                CheckAdmin = true;
            }
            else if (!CheckAdmin)
            {
                List<Customer> list = repo.GetCustomers();

                foreach (Customer customer in list)
                {
                    if (txtEmail.Text == customer.Email && txtPassword.Text == customer.Password)
                    {
                        frmUser frm = new frmUser();
                        frm.CurrentCustomer = customer;
                        frm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong Email or Password");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;

		}
    }
}
