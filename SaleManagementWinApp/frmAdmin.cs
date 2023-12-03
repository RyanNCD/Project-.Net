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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void mntrFlowerBouquet_Click(object sender, EventArgs e)
        {
            frmManageFlowerBouquet frmManageFlowerBouquet = new frmManageFlowerBouquet();
            frmManageFlowerBouquet.ShowDialog();
        }

        private void mntrCustomer_Click(object sender, EventArgs e)
        {
            frmManageCustomer frmManageCustomer = new frmManageCustomer();
            frmManageCustomer.ShowDialog();
        }

        private void mntrOrder_Click(object sender, EventArgs e)
        {
            frmManageOrder frmManageOrder = new frmManageOrder();
            frmManageOrder.ShowDialog();
        }

        private void mntrCategory_Click(object sender, EventArgs e)
        {
            frmManageCategory frmManageCategory = new frmManageCategory();
            frmManageCategory.ShowDialog();
        }

        private void mntrSupplier_Click(object sender, EventArgs e)
        {
            frmManageSupplier frmManageSupplier = new frmManageSupplier();
            frmManageSupplier.ShowDialog();
        }

        private void mntrLogout_Click(object sender, EventArgs e) => Close();
    }
}
