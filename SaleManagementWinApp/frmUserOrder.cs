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
using System.Xml.Linq;

namespace SaleManagementWinApp
{
    public partial class frmUserOrder : Form
    {
        IFlowerBouquetRepository repository = new FlowerBouquetRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public Customer CurrentCustomer { get; set; }
        public frmUserOrder()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var ListSearch = repository.GetFlowerBouquets();
            if (txtSearch.Text == null || txtSearch.Text == "Search FlowerBouquet here ")
            {
                ListSearch = repository.GetFlowerBouquets();
            }
            else
            {
                ListSearch = repository.GetFlowerBouquets().Where(fb => fb.FlowerBouquetName.ToUpper().Contains(txtSearch.Text.ToUpper())).ToList();
            }
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = ListSearch;


                txtFlowerBouquetID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtFlowerBouquetName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                txtSupplierID.DataBindings.Clear();

                txtFlowerBouquetID.DataBindings.Add("Text", source, "FlowerBouquetId");
                txtCategoryID.DataBindings.Add("Text", source, "Category.CategoryName");
                txtFlowerBouquetName.DataBindings.Add("Text", source, "FlowerBouquetName");
                txtDescription.DataBindings.Add("Text", source, "Description");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                txtSupplierID.DataBindings.Add("Text", source, "SupplierID");

                dgvFlowerBouquets.DataSource = null;
                dgvFlowerBouquets.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load project list");
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search FlowerBouquet here" || txtSearch.Text == "Search FlowerBouquet here ")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search FlowerBouquet here ";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void frmUserOrder_Load(object sender, EventArgs e)
        {
            LoadFlowerBouquetList();
        }

        private void LoadFlowerBouquetList()
        {
            try
            {
                var FlowerBouquetList = repository.GetFlowerBouquets();
                BindingSource source = new BindingSource();
                source.DataSource = FlowerBouquetList;

                foreach (var item in FlowerBouquetList)
                {
                    var category = item.Category.CategoryName;
                }

                txtFlowerBouquetID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtFlowerBouquetName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                txtSupplierID.DataBindings.Clear();

                txtFlowerBouquetID.DataBindings.Add("Text", source, "FlowerBouquetId");
                txtCategoryID.DataBindings.Add("Text", source, "Category.CategoryName");
                txtFlowerBouquetName.DataBindings.Add("Text", source, "FlowerBouquetName");
                txtDescription.DataBindings.Add("Text", source, "Description");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                txtSupplierID.DataBindings.Add("Text", source, "SupplierID");

                dgvFlowerBouquets.DataSource = null;
                dgvFlowerBouquets.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of FlowerBouquets");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new Order
                {
                    OrderId = 4003,
                    CustomerId = CurrentCustomer.CustomerId,
                    OrderDate = DateTime.Now,
                    ShippedDate = DateTime.Now.AddDays(7),
                    Total = decimal.Parse(txtUnitPrice.Text),
                    OrderStatus = "Not Done"
                };
                var orderDetail = new OrderDetail
                {
                    OrderId = order.OrderId,
                    FlowerBouquetId = int.Parse(txtFlowerBouquetID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = 1,
                    Discount = 0
                };
                orderRepository.SaveOrder(order);
                orderDetailRepository.SaveOrderDetail(orderDetail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
