namespace StoreManager
{
    partial class fControl
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Logout,
            this.tsmi_ChangePassword});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // tsmi_Logout
            // 
            this.tsmi_Logout.Name = "tsmi_Logout";
            this.tsmi_Logout.Size = new System.Drawing.Size(152, 22);
            this.tsmi_Logout.Text = "Đăng xuất";
            this.tsmi_Logout.Click += new System.EventHandler(this.tsmi_Logout_Click);
            // 
            // tsmi_ChangePassword
            // 
            this.tsmi_ChangePassword.Name = "tsmi_ChangePassword";
            this.tsmi_ChangePassword.Size = new System.Drawing.Size(152, 22);
            this.tsmi_ChangePassword.Text = "Đổi mật khẩu";
            this.tsmi_ChangePassword.Click += new System.EventHandler(this.tsmi_ChangePassword_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(54, 108);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Bán hàng";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(255, 108);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(75, 23);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Quản lý";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // fControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 266);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Logout;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ChangePassword;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnManager;
    }
}