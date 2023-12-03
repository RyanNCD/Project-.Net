namespace SaleManagementWinApp
{
    partial class frmManageCustomer
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
            System.Windows.Forms.Label lbCity;
            btnSave = new System.Windows.Forms.Button();
            txtPassword = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            dgvCustomers = new System.Windows.Forms.DataGridView();
            txtEmail = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbCustomerName = new System.Windows.Forms.Label();
            txtCustomerID = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            lbBirthday = new System.Windows.Forms.Label();
            lbCustomerID = new System.Windows.Forms.Label();
            lbCustomermng = new System.Windows.Forms.Label();
            dtpBirthday = new System.Windows.Forms.DateTimePicker();
            lbCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCity.Location = new System.Drawing.Point(78, 227);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(39, 23);
            lbCity.TabIndex = 87;
            lbCity.Text = "City";
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new System.Drawing.Point(116, 339);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(99, 34);
            btnSave.TabIndex = 102;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(155, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(242, 27);
            txtPassword.TabIndex = 100;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(334, 339);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(99, 34);
            btnDelete.TabIndex = 99;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(164, 397);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(99, 34);
            btnClose.TabIndex = 98;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(10, 339);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(99, 34);
            btnCreate.TabIndex = 97;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(221, 339);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(99, 34);
            btnUpdate.TabIndex = 96;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Dock = System.Windows.Forms.DockStyle.Right;
            dgvCustomers.Location = new System.Drawing.Point(495, 0);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 29;
            dgvCustomers.Size = new System.Drawing.Size(448, 463);
            dgvCustomers.TabIndex = 95;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(155, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(242, 27);
            txtEmail.TabIndex = 94;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(155, 259);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(242, 27);
            txtCountry.TabIndex = 93;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(155, 193);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(242, 27);
            txtCustomerName.TabIndex = 92;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(155, 226);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(242, 27);
            txtCity.TabIndex = 91;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCountry.Location = new System.Drawing.Point(46, 260);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(71, 23);
            lbCountry.TabIndex = 90;
            lbCountry.Text = "Country";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbEmail.Location = new System.Drawing.Point(66, 129);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(51, 23);
            lbEmail.TabIndex = 89;
            lbEmail.Text = "Email";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCustomerName.Location = new System.Drawing.Point(61, 194);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new System.Drawing.Size(56, 23);
            lbCustomerName.TabIndex = 88;
            lbCustomerName.Text = "Name";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new System.Drawing.Point(155, 94);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(242, 27);
            txtCustomerID.TabIndex = 86;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPassword.Location = new System.Drawing.Point(37, 161);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(80, 23);
            lbPassword.TabIndex = 84;
            lbPassword.Text = "Password";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbBirthday.Location = new System.Drawing.Point(44, 293);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new System.Drawing.Size(73, 23);
            lbBirthday.TabIndex = 83;
            lbBirthday.Text = "Birthday";
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCustomerID.Location = new System.Drawing.Point(21, 95);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new System.Drawing.Size(101, 23);
            lbCustomerID.TabIndex = 82;
            lbCustomerID.Text = "CustomerID";
            // 
            // lbCustomermng
            // 
            lbCustomermng.AutoSize = true;
            lbCustomermng.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbCustomermng.Location = new System.Drawing.Point(46, 22);
            lbCustomermng.Name = "lbCustomermng";
            lbCustomermng.Size = new System.Drawing.Size(395, 46);
            lbCustomermng.TabIndex = 81;
            lbCustomermng.Text = "Customer Management";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new System.Drawing.Point(155, 293);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new System.Drawing.Size(242, 27);
            dtpBirthday.TabIndex = 125;
            // 
            // frmManageCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(943, 463);
            Controls.Add(dtpBirthday);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(dgvCustomers);
            Controls.Add(txtEmail);
            Controls.Add(txtCountry);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCity);
            Controls.Add(lbCountry);
            Controls.Add(lbEmail);
            Controls.Add(lbCustomerName);
            Controls.Add(lbCity);
            Controls.Add(txtCustomerID);
            Controls.Add(lbPassword);
            Controls.Add(lbBirthday);
            Controls.Add(lbCustomerID);
            Controls.Add(lbCustomermng);
            Name = "frmManageCustomer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += frmManageCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label lbCustomermng;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
    }
}