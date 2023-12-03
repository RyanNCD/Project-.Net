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
    public partial class frmManageFlowerBouquet : Form
    {
        IFlowerBouquetRepository repository = new FlowerBouquetRepository();
        public frmManageFlowerBouquet()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e) => Close();

        public void LoadCategoryList()
        {
            try
            {
                var categoryList = repository.GetCategories();
                cboCategoryID.DataSource = categoryList;
                cboCategoryID.DisplayMember = "CategoryName";
                cboCategoryID.ValueMember = "CategoryId";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Create")
            {
                btnCreate.Text = "Cancel";
                btnSave.Enabled = true;

                txtFlowerBouquetID.DataBindings.Clear();
                cboCategoryID.DataBindings.Clear();
                txtFlowerBouquetName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                ckbStatus.DataBindings.Clear();
                txtSupplierID.DataBindings.Clear();
                ClearText();
            }
            else
            {
                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadFlowerBouquetList();
            }
        }

        private void ClearText()
        {
            txtFlowerBouquetID.Text = "";
            cboCategoryID.SelectedIndex = 0;
            txtFlowerBouquetName.Text = "";
            txtDescription.Text = "";
            txtUnitPrice.Text = "";
            txtUnitsInStock.Text = "";
            ckbStatus.Checked = false;
            txtSupplierID.Text = "";
        }

        private Boolean CheckExist(int Id)
        {
            foreach (var item in repository.GetFlowerBouquets())
            {
                if (item.FlowerBouquetId == int.Parse(txtFlowerBouquetID.Text))
                {
                    MessageBox.Show("ID were exist");
                    return true;
                }
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckExist(int.Parse(txtFlowerBouquetID.Text)))
            {
                btnSave.Enabled = false;
                btnCreate.Text = "Create";
                LoadFlowerBouquetList();
            }
            else if (txtFlowerBouquetID.Text == "" || txtFlowerBouquetName.Text == "" || txtUnitPrice.Text == "" || txtUnitsInStock.Text == "")
            {
                MessageBox.Show("All fields are required!", "FlowerBouquet Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var fb = new FlowerBouquet
                {
                    FlowerBouquetId = int.Parse(txtFlowerBouquetID.Text),
                    CategoryId = int.Parse(cboCategoryID.SelectedValue.ToString()),
                    FlowerBouquetName = txtFlowerBouquetName.Text,
                    Description = txtDescription.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    FlowerBouquetStatus = ckbStatus.Checked ? (byte)1 : (byte)0,
                    SupplierId = int.Parse(txtSupplierID.Text)
                };
                repository.SaveFlowerBouquet(fb);

                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadFlowerBouquetList();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFlowerBouquetID.Text == "" || txtFlowerBouquetName.Text == "" || txtUnitPrice.Text == "" || txtUnitsInStock.Text == "")
            {
                MessageBox.Show("All fields are required!", "FlowerBouquet Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var fb = new FlowerBouquet
                {
                    FlowerBouquetId = int.Parse(txtFlowerBouquetID.Text),
                    CategoryId = int.Parse(cboCategoryID.SelectedValue.ToString()),
                    FlowerBouquetName = txtFlowerBouquetName.Text,
                    Description = txtDescription.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    FlowerBouquetStatus = ckbStatus.Checked ? (byte)1 : (byte)0,
                    SupplierId = int.Parse(txtSupplierID.Text)
                };
                repository.UpdateFlowerBouquet(fb);

                LoadFlowerBouquetList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "FlowerBouquet Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var c = new FlowerBouquet
                {
                    FlowerBouquetId = int.Parse(txtFlowerBouquetID.Text),
                };
                repository.DeleteFlowerBouquet(c);
                LoadFlowerBouquetList();
            }
        }

        private void frmManageFlowerBouquet_Load(object sender, EventArgs e)
        {
            LoadCategoryList(); 
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
                cboCategoryID.DataBindings.Clear();
                txtFlowerBouquetName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                ckbStatus.DataBindings.Clear();
                txtSupplierID.DataBindings.Clear();

                txtFlowerBouquetID.DataBindings.Add("Text", source, "FlowerBouquetId");
                cboCategoryID.DataBindings.Add("Text", source, "Category.CategoryName");
                txtFlowerBouquetName.DataBindings.Add("Text", source, "FlowerBouquetName");
                txtDescription.DataBindings.Add("Text", source, "Description");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                ckbStatus.DataBindings.Add("Checked", source, "FlowerBouquetStatus", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSupplierID.DataBindings.Add("Text", source, "SupplierID");

                dgvFlowerBouquets.DataSource = null;
                dgvFlowerBouquets.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of FlowerBouquets");
            }
        }
    }
}
