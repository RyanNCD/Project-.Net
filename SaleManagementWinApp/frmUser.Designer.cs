namespace SaleManagementWinApp
{
    partial class frmUser
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            mntrProfile = new System.Windows.Forms.ToolStripMenuItem();
            mntrOrder = new System.Windows.Forms.ToolStripMenuItem();
            mntrLogout = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mntrProfile, mntrOrder, mntrLogout });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(264, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mntrProfile
            // 
            mntrProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mntrProfile.Name = "mntrProfile";
            mntrProfile.Size = new System.Drawing.Size(69, 24);
            mntrProfile.Text = "Profile";
            mntrProfile.Click += mntrProfile_Click;
            // 
            // mntrOrder
            // 
            mntrOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mntrOrder.Name = "mntrOrder";
            mntrOrder.Size = new System.Drawing.Size(63, 24);
            mntrOrder.Text = "Order";
            mntrOrder.Click += mntrOrder_Click;
            // 
            // mntrLogout
            // 
            mntrLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mntrLogout.Name = "mntrLogout";
            mntrLogout.Size = new System.Drawing.Size(73, 24);
            mntrLogout.Text = "Logout";
            mntrLogout.Click += mntrLogout_Click;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(264, 43);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmUser";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "User";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mntrProfile;
        private System.Windows.Forms.ToolStripMenuItem mntrOrder;
        private System.Windows.Forms.ToolStripMenuItem mntrLogout;
    }
}