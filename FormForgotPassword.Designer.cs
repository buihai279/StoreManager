namespace StoreManager
{
    partial class fForgotPassword
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.gbForgotPassword = new System.Windows.Forms.GroupBox();
            this.gbForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(68, 71);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 1;
            this.btnSendMail.Text = "Gửi mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // gbForgotPassword
            // 
            this.gbForgotPassword.Controls.Add(this.txtEmail);
            this.gbForgotPassword.Controls.Add(this.btnSendMail);
            this.gbForgotPassword.Location = new System.Drawing.Point(21, 21);
            this.gbForgotPassword.Name = "gbForgotPassword";
            this.gbForgotPassword.Size = new System.Drawing.Size(251, 148);
            this.gbForgotPassword.TabIndex = 2;
            this.gbForgotPassword.TabStop = false;
            this.gbForgotPassword.Text = "Nhập mail để lấy lại mật khẩu";
            // 
            // fForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.gbForgotPassword);
            this.Name = "fForgotPassword";
            this.Text = "FormForgotPassword";
            this.gbForgotPassword.ResumeLayout(false);
            this.gbForgotPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.GroupBox gbForgotPassword;
    }
}