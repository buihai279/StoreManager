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
    public partial class fControl : Form
    {
        private string mail;
        public fControl(string email)
        {
            InitializeComponent();
            this.mail = email;
        }

        private void tsmi_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmi_ChangePassword_Click(object sender, EventArgs e)
        {

            fInfo fInfo = new fInfo(mail);
            this.Hide();
            fInfo.ShowDialog();
            this.Show();
        }


        private void btnSell_Click(object sender, EventArgs e)
        {
            fSell fSell = new fSell();
            this.Hide();
            fSell.ShowDialog();
            this.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {

            fManager fmt = new fManager();
            this.Hide();
            fmt.ShowDialog();
            this.Show();
        }

    }
}
