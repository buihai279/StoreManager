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
    public partial class fManager : Form
    {
        private DataTable dt;
        public fManager()
        {
            InitializeComponent();
            LoadCategory();
            LoadUserList();
            LoadBrandList();
            LoadProductList();
            LoadOrderList();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofdImage.ShowDialog();
        }
        void LoadCategory()
        {
            CategoryDAO cate = new CategoryDAO();

            dt = cate.GetAllCategory();
            dgvCategory.DataSource = dt;

            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
            cbCategory.DataSource = dt;
        }
        void LoadUserList()
        {
            UserDAO user1 = new UserDAO();
            dt = user1.GetAllUser();
            dgvUser.DataSource = null;
            dgvUser.DataSource = dt;

        }
        void LoadBrandList()
        {
            BrandDAO brand = new BrandDAO();

            DataTable dt = brand.GetAllBrand();
            dgvBrand.DataSource = dt;

            cbBand.DisplayMember = "BrandName";
            cbBand.ValueMember = "BrandId";
            cbBand.DataSource = dt;

        }
        void LoadProductList()
        {
            ProductDAO pro = new ProductDAO();
            dt = pro.GetAllProduct();
            dgvListProduct.DataSource = dt;


        }
        void LoadOrderList()
        {
            OrderDAO ord = new OrderDAO();
            dt = ord.GetAllOrder();
            dgvOrder.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name=txtNameProduct.ToString();
            string description=txtDescription.ToString();
            string img = pbImage.ToString();
            string  brandname=cbBand.ToString();
            float price=float.Parse(txtDescription.ToString());
            int quality=int.Parse(txtQuality.ToString());
            int cateid=int.Parse(cbCategory.ToString());
        }
        private void dgvLisstProduct_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }


    }
}
