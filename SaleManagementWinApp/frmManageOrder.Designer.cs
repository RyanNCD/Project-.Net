namespace SaleManagementWinApp
{
    partial class frmManageOrder
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
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnUpload = new System.Windows.Forms.Button();
            dgvOrders = new System.Windows.Forms.DataGridView();
            txtCustomerID = new System.Windows.Forms.TextBox();
            lbCustomerID = new System.Windows.Forms.Label();
            lbOrderDate = new System.Windows.Forms.Label();
            lbOrderID = new System.Windows.Forms.Label();
            lbSuppliermng = new System.Windows.Forms.Label();
            txtTotal = new System.Windows.Forms.TextBox();
            lbShippedDate = new System.Windows.Forms.Label();
            dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            lbTotal = new System.Windows.Forms.Label();
            lbOrderStatus = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.TextBox();
            txtOrderStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(265, 287);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(99, 34);
            btnDelete.TabIndex = 114;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(168, 345);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(99, 34);
            btnClose.TabIndex = 113;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new System.Drawing.Point(72, 287);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new System.Drawing.Size(99, 34);
            btnUpload.TabIndex = 111;
            btnUpload.Text = "Update";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpdate_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = System.Windows.Forms.DockStyle.Right;
            dgvOrders.Location = new System.Drawing.Point(464, 0);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.Size = new System.Drawing.Size(443, 396);
            dgvOrders.TabIndex = 110;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new System.Drawing.Point(162, 118);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(242, 27);
            txtCustomerID.TabIndex = 109;
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCustomerID.Location = new System.Drawing.Point(42, 119);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new System.Drawing.Size(101, 23);
            lbCustomerID.TabIndex = 107;
            lbCustomerID.Text = "CustomerID";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbOrderDate.Location = new System.Drawing.Point(53, 155);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(90, 23);
            lbOrderDate.TabIndex = 106;
            lbOrderDate.Text = "OrderDate";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbOrderID.Location = new System.Drawing.Point(72, 90);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(71, 23);
            lbOrderID.TabIndex = 105;
            lbOrderID.Text = "OrderID";
            // 
            // lbSuppliermng
            // 
            lbSuppliermng.AutoSize = true;
            lbSuppliermng.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSuppliermng.Location = new System.Drawing.Point(47, 24);
            lbSuppliermng.Name = "lbSuppliermng";
            lbSuppliermng.Size = new System.Drawing.Size(334, 46);
            lbSuppliermng.TabIndex = 104;
            lbSuppliermng.Text = "Order Management";
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(162, 217);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(242, 27);
            txtTotal.TabIndex = 118;
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbShippedDate.Location = new System.Drawing.Point(35, 188);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new System.Drawing.Size(108, 23);
            lbShippedDate.TabIndex = 117;
            lbShippedDate.Text = "ShippedDate";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new System.Drawing.Point(162, 151);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new System.Drawing.Size(242, 27);
            dtpOrderDate.TabIndex = 126;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new System.Drawing.Point(162, 184);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new System.Drawing.Size(242, 27);
            dtpShippedDate.TabIndex = 127;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new System.Drawing.Point(101, 224);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new System.Drawing.Size(42, 20);
            lbTotal.TabIndex = 128;
            lbTotal.Text = "Total";
            // 
            // lbOrderStatus
            // 
            lbOrderStatus.AutoSize = true;
            lbOrderStatus.Location = new System.Drawing.Point(56, 257);
            lbOrderStatus.Name = "lbOrderStatus";
            lbOrderStatus.Size = new System.Drawing.Size(87, 20);
            lbOrderStatus.TabIndex = 130;
            lbOrderStatus.Text = "OrderStatus";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(162, 90);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(242, 27);
            txtOrderID.TabIndex = 131;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new System.Drawing.Point(162, 250);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new System.Drawing.Size(242, 27);
            txtOrderStatus.TabIndex = 132;
            // 
            // frmManageOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(907, 396);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderStatus);
            Controls.Add(lbTotal);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtTotal);
            Controls.Add(lbShippedDate);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnUpload);
            Controls.Add(dgvOrders);
            Controls.Add(txtCustomerID);
            Controls.Add(lbCustomerID);
            Controls.Add(lbOrderDate);
            Controls.Add(lbOrderID);
            Controls.Add(lbSuppliermng);
            Name = "frmManageOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Order";
            Load += frmManageOrder_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbSuppliermng;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbOrderStatus;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtOrderStatus;
    }
}