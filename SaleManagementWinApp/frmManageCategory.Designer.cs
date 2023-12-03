namespace SaleManagementWinApp
{
    partial class frmManageCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            dgvCategories = new System.Windows.Forms.DataGridView();
            txtCategoryName = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            lbFlowerBouquetName = new System.Windows.Forms.Label();
            lbDescription = new System.Windows.Forms.Label();
            lbCategoryID = new System.Windows.Forms.Label();
            lbCategorymng = new System.Windows.Forms.Label();
            txtCategoryID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new System.Drawing.Point(121, 205);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(99, 34);
            btnSave.TabIndex = 102;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(339, 205);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(99, 34);
            btnDelete.TabIndex = 99;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(174, 263);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(99, 34);
            btnClose.TabIndex = 98;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(15, 205);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(99, 34);
            btnCreate.TabIndex = 97;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(226, 205);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(99, 34);
            btnUpdate.TabIndex = 96;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Dock = System.Windows.Forms.DockStyle.Right;
            dgvCategories.Location = new System.Drawing.Point(467, 0);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 29;
            dgvCategories.Size = new System.Drawing.Size(443, 321);
            dgvCategories.TabIndex = 95;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new System.Drawing.Point(169, 118);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new System.Drawing.Size(242, 27);
            txtCategoryName.TabIndex = 94;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(169, 151);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(242, 27);
            txtDescription.TabIndex = 92;
            // 
            // lbFlowerBouquetName
            // 
            lbFlowerBouquetName.AutoSize = true;
            lbFlowerBouquetName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFlowerBouquetName.Location = new System.Drawing.Point(94, 123);
            lbFlowerBouquetName.Name = "lbFlowerBouquetName";
            lbFlowerBouquetName.Size = new System.Drawing.Size(56, 23);
            lbFlowerBouquetName.TabIndex = 89;
            lbFlowerBouquetName.Text = "Name";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbDescription.Location = new System.Drawing.Point(54, 155);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new System.Drawing.Size(96, 23);
            lbDescription.TabIndex = 88;
            lbDescription.Text = "Description";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCategoryID.Location = new System.Drawing.Point(54, 90);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new System.Drawing.Size(96, 23);
            lbCategoryID.TabIndex = 85;
            lbCategoryID.Text = "CategoryID";
            // 
            // lbCategorymng
            // 
            lbCategorymng.AutoSize = true;
            lbCategorymng.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbCategorymng.Location = new System.Drawing.Point(33, 18);
            lbCategorymng.Name = "lbCategorymng";
            lbCategorymng.Size = new System.Drawing.Size(386, 46);
            lbCategorymng.TabIndex = 81;
            lbCategorymng.Text = "Category Management";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new System.Drawing.Point(169, 86);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new System.Drawing.Size(242, 27);
            txtCategoryID.TabIndex = 103;
            // 
            // frmManageCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(910, 321);
            Controls.Add(txtCategoryID);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(dgvCategories);
            Controls.Add(txtCategoryName);
            Controls.Add(txtDescription);
            Controls.Add(lbFlowerBouquetName);
            Controls.Add(lbDescription);
            Controls.Add(lbCategoryID);
            Controls.Add(lbCategorymng);
            Name = "frmManageCategory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Category";
            Load += frmManageCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtFlowerBouquetStatus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtUnitslnStock;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbFlowerBouquetName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtFlowerBouquetID;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbFlowerBouquetStatus;
        private System.Windows.Forms.Label lbSupplierID;
        private System.Windows.Forms.Label lbFlowerBouquetID;
        private System.Windows.Forms.Label lbCategorymng;
        private System.Windows.Forms.TextBox txtCategoryID;
    }
}