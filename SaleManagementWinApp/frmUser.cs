using BusinessObjects;
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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        public Customer CurrentCustomer { get; set; }
        private void mntrProfile_Click(object sender, EventArgs e)
        {
            frmUserProfile frm = new frmUserProfile();
            frm.CurrentCustomer = CurrentCustomer;
            frm.ShowDialog();
        }

        private void mntrOrder_Click(object sender, EventArgs e)
        {
            frmUserOrder frm = new frmUserOrder();
            frm.ShowDialog();
        }

        private void mntrLogout_Click(object sender, EventArgs e) => Close();
    }
}
