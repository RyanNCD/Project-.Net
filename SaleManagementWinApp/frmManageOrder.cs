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
    public partial class frmManageOrder : Form
    {
        IOrderRepository repository = new OrderRepository();
        public frmManageOrder()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("All fields are required!", "Order Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var fb = new Order
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    CustomerId = int.Parse(txtCustomerID.Text),
                    OrderDate = dtpOrderDate.Value,
                    ShippedDate = dtpShippedDate.Value,
                    Total = decimal.Parse(txtTotal.Text),
                    OrderStatus = txtOrderStatus.Text,
                };
                repository.UpdateOrder(fb);

                LoadOrderList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Order Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var c = new Order
                {
                    OrderId = int.Parse(txtOrderID.Text),
                };
                repository.DeleteOrder(c);
                LoadOrderList();
            }
        }

        private void frmManageOrder_Load_1(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            try
            {
                var OrderList = repository.GetOrders();
                BindingSource source = new BindingSource();
                source.DataSource = OrderList;

                txtOrderID.DataBindings.Clear();
                txtCustomerID.DataBindings.Clear();
                dtpOrderDate.DataBindings.Clear();
                dtpShippedDate.DataBindings.Clear();
                txtTotal.DataBindings.Clear();
                txtOrderStatus.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtCustomerID.DataBindings.Add("Text", source, "CustomerID");
                dtpOrderDate.DataBindings.Add("Value", source, "OrderDate");
                dtpShippedDate.DataBindings.Add("Value", source, "ShippedDate");
                txtTotal.DataBindings.Add("Text", source, "Total");
                txtOrderStatus.DataBindings.Add("Text", source, "OrderStatus");

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Orders");
            }
        }
    }
}
