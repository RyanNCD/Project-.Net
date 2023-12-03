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
    public partial class frmManageCategory : Form
    {
        ICategoryRepository repository = new CategoryRepository();
        public frmManageCategory()
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

                txtCategoryID.DataBindings.Clear();
                txtCategoryName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                ClearText();
            }
            else
            {
                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadCategoryList();
            }
        }
        private void ClearText()
        {
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
            txtDescription.Text = "";
        }
        private Boolean CheckExist(int Id)
        {
            foreach (var item in repository.GetCategories())
            {
                if (item.CategoryId == int.Parse(txtCategoryID.Text))
                {
                    MessageBox.Show("ID were exist");
                    return true;
                }
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckExist(int.Parse(txtCategoryID.Text)))
            {
                btnSave.Enabled = false;
                btnCreate.Text = "Create";
                LoadCategoryList();
            }
            else if (txtCategoryName.Text == "" || txtCategoryID.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("All fields are required!", "Category Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Category
                {
                    CategoryId = int.Parse(txtCategoryID.Text),
                    CategoryName = txtCategoryName.Text,
                    CategoryDescription = txtDescription.Text,
                };
                repository.SaveCategory(p);

                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadCategoryList();
            }
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "" || txtCategoryID.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("All fields are required!", "Category Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Category
                {
                    CategoryId = int.Parse(txtCategoryID.Text),
                    CategoryName = txtCategoryName.Text,
                    CategoryDescription = txtDescription.Text,
                };
                repository.UpdateCategory(p);

                LoadCategoryList();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Category Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var p = new Category
                {
                    CategoryId = int.Parse(txtCategoryID.Text),
                };
                repository.DeleteCategory(p);
                LoadCategoryList();
            }
        }
        private void frmManageCategory_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
        }
        private void LoadCategoryList()
        {
            try
            {
                var CategoryList = repository.GetCategories();
                BindingSource source = new BindingSource();
                source.DataSource = CategoryList;

                txtCategoryID.DataBindings.Clear();
                txtCategoryName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();

                txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                txtCategoryName.DataBindings.Add("Text", source, "CategoryName");
                txtDescription.DataBindings.Add("Text", source, "CategoryDescription");

                dgvCategories.DataSource = null;
                dgvCategories.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Categories");
            }
        }

    }
}
