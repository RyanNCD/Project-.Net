namespace SaleManagementWinApp
{
    partial class frmAdmin
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            mntrFlowerBouquet = new System.Windows.Forms.ToolStripMenuItem();
            mntrCustomer = new System.Windows.Forms.ToolStripMenuItem();
            mntrOrder = new System.Windows.Forms.ToolStripMenuItem();
            mntrCategory = new System.Windows.Forms.ToolStripMenuItem();
            mntrSupplier = new System.Windows.Forms.ToolStripMenuItem();
            mntrLogout = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mntrFlowerBouquet, mntrCustomer, mntrOrder, mntrCategory, mntrSupplier, mntrLogout });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(546, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mntrFlowerBouquet
            // 
            mntrFlowerBouquet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mntrFlowerBouquet.Name = "mntrFlowerBouquet";
            mntrFlowerBouquet.Size = new System.Drawing.Size(134, 24);
            mntrFlowerBouquet.Text = "Flower Bouquet";
            mntrFlowerBouquet.Click += mntrFlowerBouquet_Click;
            // 
            // mntrCustomer
            // 
            mntrCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mntrCustomer.Name = "mntrCustomer";
            mntrCustomer.Size = new System.Drawing.Size(91, 24);
            mntrCustomer.Text = "Customer";
            mntrCustomer.Click += mntrCustomer_Click;
            // 
            // mntrOrder
            // 
            mntrOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mntrOrder.Name = "mntrOrder";
            mntrOrder.Size = new System.Drawing.Size(63, 24);
            mntrOrder.Text = "Order";
            mntrOrder.Click += mntrOrder_Click;
            // 
            // mntrCategory
            // 
            mntrCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mntrCategory.Name = "mntrCategory";
            mntrCategory.Size = new System.Drawing.Size(87, 24);
            mntrCategory.Text = "Category";
            mntrCategory.Click += mntrCategory_Click;
            // 
            // mntrSupplier
            // 
            mntrSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mntrSupplier.Name = "mntrSupplier";
            mntrSupplier.Size = new System.Drawing.Size(80, 24);
            mntrSupplier.Text = "Supplier";
            mntrSupplier.Click += mntrSupplier_Click;
            // 
            // mntrLogout
            // 
            mntrLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mntrLogout.Name = "mntrLogout";
            mntrLogout.Size = new System.Drawing.Size(73, 24);
            mntrLogout.Text = "Logout";
            mntrLogout.Click += mntrLogout_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(546, 40);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAdmin";
            Text = "Admin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mntrFlowerBouquet;
        private System.Windows.Forms.ToolStripMenuItem mntrCustomer;
        private System.Windows.Forms.ToolStripMenuItem mntrOrder;
        private System.Windows.Forms.ToolStripMenuItem mntrCategory;
        private System.Windows.Forms.ToolStripMenuItem mntrSupplier;
        private System.Windows.Forms.ToolStripMenuItem mntrLogout;
    }
}