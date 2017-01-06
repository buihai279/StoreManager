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
        private UserDAO userDAO = new UserDAO();
        public fInfo(string mail)
        {
            InitializeComponent();
            loadInfoAccount(mail);
        }
        #region method
        void loadInfoAccount(string mail)
        {
            DataTable dt = userDAO.GetInfoAccount(mail);
            DataRow row = dt.Rows[0];
            txtUserId.Text = row["UserId"].ToString();
            txtEmail.Text = row["EmailAdress"].ToString();
            txtTypeUser.Text = row["UserType"].ToString();
            txtFullName.Text =  row["Fullname"].ToString();
            txtPhone.Text = row["PhoneNumber"].ToString();
        }

        public void changePassword(string mail, string password, string newpassword, int phone, string fullname)
        {
            bool result = userDAO.ChangePassword(mail, password, newpassword,phone,fullname);
            if (result == true)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
                MessageBox.Show("Không thành công!!!");
        }
        #endregion
        #region Event
        private void btnAply_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string newpassword = txtNewPassword.Text;
            string cfnewpassword = txtCfNewPassword.Text;
            string mail = txtEmail.Text;
            Int32 phone=0;
            if (!Int32.TryParse(txtPhone.Text, out phone))
            {
                MessageBox.Show("Trường dữ liệu Phone không đúng định dạng!!!");
                txtPhone.Text = "0";
            }
            string fullname = txtFullName.Text;
            if (txtPhone.Text == "" || txtFullName.Text == "")
                MessageBox.Show("Trường dữ liệu bắt buộc không được rỗng!!!");
            if (cfnewpassword == newpassword && newpassword != password )
                changePassword(mail, password, newpassword, phone, fullname);
            else
                MessageBox.Show("Mật khẩu cũ phải khác mật khẩu mới, mật khẩu và xác nhận mật khẩu phải giống nhau!!!");
         
        }
        #endregion


    }
}
