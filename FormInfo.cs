using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class fInfo : Form
    {
        public fInfo(string mail)
        {
            InitializeComponent();
            loadInfoAccount(mail);
        }
        #region method
        void loadInfoAccount(string mail)
        {
            UserDAO user = new UserDAO();
            DataTable dt = user.GetInfoAccount(mail);
            foreach (DataRow row in dt.Rows)
            {
                txtUserId.Text = row["UserId"].ToString();
                txtEmail.Text = row["EmailAdress"].ToString();
                txtTypeUser.Text = row["UserType"].ToString();
                txtFullName.Text = row["Fullname"].ToString();
                txtPhone.Text = row["PhoneNumber"].ToString();

            }
        }
        public void changePassword(string mail, string password, string newpassword, string phone, string fullname)
        {
            UserDAO user = new UserDAO();
            bool result = user.ChangePassword(mail, password, newpassword,phone,fullname);
            if (result == true)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
                MessageBox.Show("Có lỗi xảy ra");
        }
        #endregion
        #region Event
        private void btnAply_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string newpassword = txtNewPassword.Text;
            string cfnewpassword = txtCfNewPassword.Text;
            string mail = txtEmail.Text;
            string phone = txtPhone.Text;
            string fullname = txtFullName.Text;
            if (cfnewpassword == newpassword && newpassword != password)
            {
                changePassword(mail, password, newpassword, phone, fullname);
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ phải khác mật khẩu mới!!!");
            }
        }
        #endregion

    }
}
