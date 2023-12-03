namespace SaleManagementWinApp
{
    partial class frmManageFlowerBouquet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lbProjectDescription;
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            dgvFlowerBouquets = new System.Windows.Forms.DataGridView();
            txtFlowerBouquetName = new System.Windows.Forms.TextBox();
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            lbUnitsInStock = new System.Windows.Forms.Label();
            lbFlowerBouquetName = new System.Windows.Forms.Label();
            lbDescription = new System.Windows.Forms.Label();
            txtFlowerBouquetID = new System.Windows.Forms.TextBox();
            lbCategoryID = new System.Windows.Forms.Label();
            lbFlowerBouquetStatus = new System.Windows.Forms.Label();
            lbSupplierID = new System.Windows.Forms.Label();
            lbFlowerBouquetID = new System.Windows.Forms.Label();
            lbFlowerBouquetmng = new System.Windows.Forms.Label();
            txtSupplierID = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            cboCategoryID = new System.Windows.Forms.ComboBox();
            ckbStatus = new System.Windows.Forms.CheckBox();
            lbProjectDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvFlowerBouquets).BeginInit();
            SuspendLayout();
            // 
            // lbProjectDescription
            // 
            lbProjectDescription.AutoSize = true;
            lbProjectDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbProjectDescription.Location = new System.Drawing.Point(96, 227);
            lbProjectDescription.Name = "lbProjectDescription";
            lbProjectDescription.Size = new System.Drawing.Size(79, 23);
            lbProjectDescription.TabIndex = 61;
            lbProjectDescription.Text = "UnitPrice";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(337, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(99, 34);
            btnDelete.TabIndex = 75;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(172, 438);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(99, 34);
            btnClose.TabIndex = 74;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(13, 380);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(99, 34);
            btnCreate.TabIndex = 71;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(224, 380);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(99, 34);
            btnUpdate.TabIndex = 70;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvFlowerBouquets
            // 
            dgvFlowerBouquets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlowerBouquets.Dock = System.Windows.Forms.DockStyle.Right;
            dgvFlowerBouquets.Location = new System.Drawing.Point(510, 0);
            dgvFlowerBouquets.Name = "dgvFlowerBouquets";
            dgvFlowerBouquets.RowHeadersWidth = 51;
            dgvFlowerBouquets.RowTemplate.Height = 29;
            dgvFlowerBouquets.Size = new System.Drawing.Size(443, 503);
            dgvFlowerBouquets.TabIndex = 69;
            // 
            // txtFlowerBouquetName
            // 
            txtFlowerBouquetName.Location = new System.Drawing.Point(194, 157);
            txtFlowerBouquetName.Name = "txtFlowerBouquetName";
            txtFlowerBouquetName.Size = new System.Drawing.Size(242, 27);
            txtFlowerBouquetName.TabIndex = 68;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(194, 256);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(242, 27);
            txtUnitsInStock.TabIndex = 67;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(194, 190);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(242, 27);
            txtDescription.TabIndex = 66;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(194, 223);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(242, 27);
            txtUnitPrice.TabIndex = 65;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbUnitsInStock.Location = new System.Drawing.Point(71, 260);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(104, 23);
            lbUnitsInStock.TabIndex = 64;
            lbUnitsInStock.Text = "UnitsInStock";
            // 
            // lbFlowerBouquetName
            // 
            lbFlowerBouquetName.AutoSize = true;
            lbFlowerBouquetName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFlowerBouquetName.Location = new System.Drawing.Point(119, 162);
            lbFlowerBouquetName.Name = "lbFlowerBouquetName";
            lbFlowerBouquetName.Size = new System.Drawing.Size(56, 23);
            lbFlowerBouquetName.TabIndex = 63;
            lbFlowerBouquetName.Text = "Name";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbDescription.Location = new System.Drawing.Point(79, 194);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new System.Drawing.Size(96, 23);
            lbDescription.TabIndex = 62;
            lbDescription.Text = "Description";
            // 
            // txtFlowerBouquetID
            // 
            txtFlowerBouquetID.Location = new System.Drawing.Point(194, 91);
            txtFlowerBouquetID.Name = "txtFlowerBouquetID";
            txtFlowerBouquetID.Size = new System.Drawing.Size(242, 27);
            txtFlowerBouquetID.TabIndex = 59;
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCategoryID.Location = new System.Drawing.Point(79, 129);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new System.Drawing.Size(96, 23);
            lbCategoryID.TabIndex = 58;
            lbCategoryID.Text = "CategoryID";
            // 
            // lbFlowerBouquetStatus
            // 
            lbFlowerBouquetStatus.AutoSize = true;
            lbFlowerBouquetStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFlowerBouquetStatus.Location = new System.Drawing.Point(5, 291);
            lbFlowerBouquetStatus.Name = "lbFlowerBouquetStatus";
            lbFlowerBouquetStatus.Size = new System.Drawing.Size(170, 23);
            lbFlowerBouquetStatus.TabIndex = 57;
            lbFlowerBouquetStatus.Text = "FlowerBouquetStatus";
            // 
            // lbSupplierID
            // 
            lbSupplierID.AutoSize = true;
            lbSupplierID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbSupplierID.Location = new System.Drawing.Point(86, 324);
            lbSupplierID.Name = "lbSupplierID";
            lbSupplierID.Size = new System.Drawing.Size(89, 23);
            lbSupplierID.TabIndex = 56;
            lbSupplierID.Text = "SupplierID";
            // 
            // lbFlowerBouquetID
            // 
            lbFlowerBouquetID.AutoSize = true;
            lbFlowerBouquetID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFlowerBouquetID.Location = new System.Drawing.Point(36, 92);
            lbFlowerBouquetID.Name = "lbFlowerBouquetID";
            lbFlowerBouquetID.Size = new System.Drawing.Size(141, 23);
            lbFlowerBouquetID.TabIndex = 55;
            lbFlowerBouquetID.Text = "FlowerBouquetID";
            // 
            // lbFlowerBouquetmng
            // 
            lbFlowerBouquetmng.AutoSize = true;
            lbFlowerBouquetmng.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbFlowerBouquetmng.Location = new System.Drawing.Point(5, 22);
            lbFlowerBouquetmng.Name = "lbFlowerBouquetmng";
            lbFlowerBouquetmng.Size = new System.Drawing.Size(486, 46);
            lbFlowerBouquetmng.TabIndex = 54;
            lbFlowerBouquetmng.Text = "FlowerBouquet Management";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new System.Drawing.Point(194, 320);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new System.Drawing.Size(242, 27);
            txtSupplierID.TabIndex = 78;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new System.Drawing.Point(119, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(99, 34);
            btnSave.TabIndex = 79;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cboCategoryID
            // 
            cboCategoryID.FormattingEnabled = true;
            cboCategoryID.Location = new System.Drawing.Point(194, 124);
            cboCategoryID.Margin = new System.Windows.Forms.Padding(2);
            cboCategoryID.Name = "cboCategoryID";
            cboCategoryID.Size = new System.Drawing.Size(242, 28);
            cboCategoryID.TabIndex = 80;
            // 
            // ckbStatus
            // 
            ckbStatus.AutoSize = true;
            ckbStatus.Location = new System.Drawing.Point(194, 296);
            ckbStatus.Name = "ckbStatus";
            ckbStatus.Size = new System.Drawing.Size(18, 17);
            ckbStatus.TabIndex = 81;
            ckbStatus.UseVisualStyleBackColor = true;
            // 
            // frmManageFlowerBouquet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(953, 503);
            Controls.Add(ckbStatus);
            Controls.Add(cboCategoryID);
            Controls.Add(btnSave);
            Controls.Add(txtSupplierID);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(dgvFlowerBouquets);
            Controls.Add(txtFlowerBouquetName);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtDescription);
            Controls.Add(txtUnitPrice);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbFlowerBouquetName);
            Controls.Add(lbDescription);
            Controls.Add(lbProjectDescription);
            Controls.Add(txtFlowerBouquetID);
            Controls.Add(lbCategoryID);
            Controls.Add(lbFlowerBouquetStatus);
            Controls.Add(lbSupplierID);
            Controls.Add(lbFlowerBouquetID);
            Controls.Add(lbFlowerBouquetmng);
            Name = "frmManageFlowerBouquet";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Flower Bouquet";
            Load += frmManageFlowerBouquet_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFlowerBouquets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvFlowerBouquets;
        private System.Windows.Forms.TextBox txtFlowerBouquetName;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbFlowerBouquetName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbProjectDescription;
        private System.Windows.Forms.TextBox txtFlowerBouquetID;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbFlowerBouquetStatus;
        private System.Windows.Forms.Label lbSupplierID;
        private System.Windows.Forms.Label lbFlowerBouquetID;
        private System.Windows.Forms.Label lbFlowerBouquetmng;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboCategoryID;
        private System.Windows.Forms.CheckBox ckbStatus;
    }
}
