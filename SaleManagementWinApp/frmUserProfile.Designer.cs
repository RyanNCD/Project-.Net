namespace SaleManagementWinApp
{
    partial class frmUserProfile
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
            dtpBirthday = new System.Windows.Forms.DateTimePicker();
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbCustomerName = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbBirthday = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lbProfile = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCity.Location = new System.Drawing.Point(116, 183);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(39, 23);
            lbCity.TabIndex = 130;
            lbCity.Text = "City";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new System.Drawing.Point(193, 249);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new System.Drawing.Size(242, 27);
            dtpBirthday.TabIndex = 139;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(193, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(242, 27);
            txtPassword.TabIndex = 138;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(193, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(242, 27);
            txtEmail.TabIndex = 137;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(193, 215);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(242, 27);
            txtCountry.TabIndex = 136;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(193, 149);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(242, 27);
            txtCustomerName.TabIndex = 135;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(193, 182);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(242, 27);
            txtCity.TabIndex = 134;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCountry.Location = new System.Drawing.Point(84, 216);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(71, 23);
            lbCountry.TabIndex = 133;
            lbCountry.Text = "Country";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbEmail.Location = new System.Drawing.Point(104, 85);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(51, 23);
            lbEmail.TabIndex = 132;
            lbEmail.Text = "Email";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCustomerName.Location = new System.Drawing.Point(99, 150);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new System.Drawing.Size(56, 23);
            lbCustomerName.TabIndex = 131;
            lbCustomerName.Text = "Name";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPassword.Location = new System.Drawing.Point(75, 117);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(80, 23);
            lbPassword.TabIndex = 128;
            lbPassword.Text = "Password";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbBirthday.Location = new System.Drawing.Point(82, 249);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new System.Drawing.Size(73, 23);
            lbBirthday.TabIndex = 127;
            lbBirthday.Text = "Birthday";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(257, 315);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(99, 34);
            btnCancel.TabIndex = 141;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(144, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(99, 34);
            btnSave.TabIndex = 140;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbProfile
            // 
            lbProfile.AutoSize = true;
            lbProfile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbProfile.Location = new System.Drawing.Point(193, 20);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new System.Drawing.Size(126, 46);
            lbProfile.TabIndex = 142;
            lbProfile.Text = "Profile";
            // 
            // frmUserProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(520, 383);
            Controls.Add(lbProfile);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpBirthday);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtCountry);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCity);
            Controls.Add(lbCountry);
            Controls.Add(lbEmail);
            Controls.Add(lbCustomerName);
            Controls.Add(lbCity);
            Controls.Add(lbPassword);
            Controls.Add(lbBirthday);
            Name = "frmUserProfile";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "User Profile";
            Load += frmUserProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbProfile;
    }
}