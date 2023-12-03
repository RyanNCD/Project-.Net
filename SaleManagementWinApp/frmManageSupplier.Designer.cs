namespace SaleManagementWinApp
{
    partial class frmManageSupplier
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
            txtTelephone = new System.Windows.Forms.TextBox();
            lbTelephone = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            dgvSuppliers = new System.Windows.Forms.DataGridView();
            txtSupplierName = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            lbName = new System.Windows.Forms.Label();
            lbAddress = new System.Windows.Forms.Label();
            lbSupplierID = new System.Windows.Forms.Label();
            lbSuppliermng = new System.Windows.Forms.Label();
            txtSupplierID = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new System.Drawing.Point(158, 184);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new System.Drawing.Size(242, 27);
            txtTelephone.TabIndex = 133;
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTelephone.Location = new System.Drawing.Point(51, 188);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new System.Drawing.Size(88, 23);
            lbTelephone.TabIndex = 132;
            lbTelephone.Text = "Telephone";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(321, 253);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(99, 34);
            btnDelete.TabIndex = 129;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(158, 311);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(99, 34);
            btnClose.TabIndex = 128;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(216, 253);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(99, 34);
            btnUpdate.TabIndex = 126;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Right;
            dgvSuppliers.Location = new System.Drawing.Point(437, 0);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.RowTemplate.Height = 29;
            dgvSuppliers.Size = new System.Drawing.Size(443, 352);
            dgvSuppliers.TabIndex = 125;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new System.Drawing.Point(158, 118);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new System.Drawing.Size(242, 27);
            txtSupplierName.TabIndex = 124;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(158, 151);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(242, 27);
            txtAddress.TabIndex = 123;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbName.Location = new System.Drawing.Point(83, 118);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(56, 23);
            lbName.TabIndex = 122;
            lbName.Text = "Name";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAddress.Location = new System.Drawing.Point(69, 155);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new System.Drawing.Size(70, 23);
            lbAddress.TabIndex = 121;
            lbAddress.Text = "Address";
            // 
            // lbSupplierID
            // 
            lbSupplierID.AutoSize = true;
            lbSupplierID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbSupplierID.Location = new System.Drawing.Point(51, 90);
            lbSupplierID.Name = "lbSupplierID";
            lbSupplierID.Size = new System.Drawing.Size(89, 23);
            lbSupplierID.TabIndex = 120;
            lbSupplierID.Text = "SupplierID";
            // 
            // lbSuppliermng
            // 
            lbSuppliermng.AutoSize = true;
            lbSuppliermng.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSuppliermng.Location = new System.Drawing.Point(43, 24);
            lbSuppliermng.Name = "lbSuppliermng";
            lbSuppliermng.Size = new System.Drawing.Size(375, 46);
            lbSuppliermng.TabIndex = 119;
            lbSuppliermng.Text = "Supplier Management";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new System.Drawing.Point(158, 90);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new System.Drawing.Size(242, 27);
            txtSupplierID.TabIndex = 134;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new System.Drawing.Point(111, 253);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(99, 34);
            btnSave.TabIndex = 136;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(5, 253);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(99, 34);
            btnCreate.TabIndex = 135;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // frmManageSupplier
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(880, 352);
            Controls.Add(btnSave);
            Controls.Add(btnCreate);
            Controls.Add(txtSupplierID);
            Controls.Add(txtTelephone);
            Controls.Add(lbTelephone);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(dgvSuppliers);
            Controls.Add(txtSupplierName);
            Controls.Add(txtAddress);
            Controls.Add(lbName);
            Controls.Add(lbAddress);
            Controls.Add(lbSupplierID);
            Controls.Add(lbSuppliermng);
            Name = "frmManageSupplier";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Supplier";
            Load += frmManageSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbSupplierID;
        private System.Windows.Forms.Label lbSuppliermng;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
    }
}