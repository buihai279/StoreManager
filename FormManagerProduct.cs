using StoreManager.DAO;
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
    public partial class fManagerProduct : Form
    {
        
        public fManagerProduct()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofdImage.ShowDialog();
        }
        /*
        void LoadAccoutList()
        {
            DataProvider provider = new DataProvider();
            string query = "spCheckPassword";
            dgvListProduct.DataSource = provider.ExcuteNonQuery(query, new object[] { "UserName", "Password" }, new object[] { "UserName", "Password" });
            int i=provider.ExcuteNonQuery(query, new object[] { "UserName", "Password" }, new object[] { "admin", "123456" });
            MessageBox.Show(i.ToString());
        }*/
    }
}
