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
    public partial class frmManageSupplier : Form
    {
        ISupplierRepository repository = new SupplierRepository();
        public frmManageSupplier()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Create")
            {
                btnCreate.Text = "Cancel";
                btnSave.Enabled = true;

                txtSupplierID.DataBindings.Clear();
                txtSupplierName.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtTelephone.DataBindings.Clear();
                ClearText();
            }
            else
            {
                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadSupplierList();
            }
        }
        private void ClearText()
        {
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            txtAddress.Text = "";
            txtTelephone.Text = "";
        }
        private Boolean CheckExist(int Id)
        {
            foreach (var item in repository.GetSuppliers())
            {
                if (item.SupplierId == int.Parse(txtSupplierID.Text))
                {
                    MessageBox.Show("ID were exist");
                    return true;
                }
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckExist(int.Parse(txtSupplierID.Text)))
            {
                btnSave.Enabled = false;
                btnCreate.Text = "Create";
                LoadSupplierList();
            }
            else if (txtSupplierID.Text == "" || txtSupplierName.Text == "" || txtAddress.Text == "" || txtTelephone.Text == "")
            {
                MessageBox.Show("All fields are required!", "Supplier Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Supplier
                {
                    SupplierId = int.Parse(txtSupplierID.Text),
                    SupplierName = txtSupplierName.Text,
                    SupplierAddress = txtAddress.Text,
                    Telephone = txtTelephone.Text,
                };
                repository.SaveSupplier(p);

                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadSupplierList();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSupplierID.Text == "" || txtSupplierName.Text == "" || txtAddress.Text == "" || txtTelephone.Text == "")
            {
                MessageBox.Show("All fields are required!", "Supplier Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Supplier
                {
                    SupplierId = int.Parse(txtSupplierID.Text),
                    SupplierName = txtSupplierName.Text,
                    SupplierAddress = txtAddress.Text,
                    Telephone = txtTelephone.Text,
                };
                repository.UpdateSupplier(p);

                LoadSupplierList();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Supplier Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var c = new Supplier
                {
                    SupplierId = int.Parse(txtSupplierID.Text),
                };
                repository.DeleteSupplier(c);
                LoadSupplierList();
            }
        }
        private void frmManageSupplier_Load(object sender, EventArgs e)
        {
            LoadSupplierList();
        }
        private void LoadSupplierList()
        {
            try
            {
                var SupplierList = repository.GetSuppliers();
                BindingSource source = new BindingSource();
                source.DataSource = SupplierList;

                txtSupplierID.DataBindings.Clear();
                txtSupplierName.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtTelephone.DataBindings.Clear();

                txtSupplierID.DataBindings.Add("Text", source, "SupplierId");
                txtSupplierName.DataBindings.Add("Text", source, "SupplierName");
                txtAddress.DataBindings.Add("Text", source, "SupplierAddress");
                txtTelephone.DataBindings.Add("Text", source, "Telephone");

                dgvSuppliers.DataSource = null;
                dgvSuppliers.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Suppliers");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
