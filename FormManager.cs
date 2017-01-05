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
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
        }

        private void tsmi_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmi_ChangePassword_Click(object sender, EventArgs e)
        {
            fInfo fInfo = new fInfo();
            this.Hide();
            fInfo.ShowDialog();
            this.Show();
        }

        private void tmsi_sell_Click(object sender, EventArgs e)
        {
            fSell fSell = new fSell();
            this.Hide();
            fSell.ShowDialog();
            this.Show();
        }

        private void tsmi_ManagerProduct_Click(object sender, EventArgs e)
        {
            fManagerProduct fmt = new fManagerProduct();
            this.Hide();
            fmt.ShowDialog();
            this.Show();
        }

    }
}
