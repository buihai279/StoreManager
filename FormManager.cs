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
        BindingSource ProductList = new BindingSource();
        BindingSource CategoryList = new BindingSource();
        BindingSource BrandList = new BindingSource();
        BindingSource UserList = new BindingSource();
        BindingSource OrderList = new BindingSource();
        private DataTable dt;
        public fManager()
        {
            InitializeComponent();
            dgvListProduct.DataSource = ProductList;
            dgvCategory.DataSource = CategoryList;
            dgvBrand.DataSource = BrandList;
            dgvUser.DataSource = UserList;
            dgvOrder.DataSource = OrderList;
            Load();
           
        }
        #region method

        void Load() 
        {
            LoadCategory();
            LoadUserList();
            LoadBrandList();
            LoadProductList();
            LoadOrderList();

            AddProductBinding();
            AddCategoryBinding();
            AddBrandBinding();
            AddUserBinding();
        }
        void AddProductBinding()
        {
            txtNameProduct.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "ProductName"));
            txtDescription.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "ProductDescription"));
            txtPrice.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "Price"));
            txtQuantity.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "Quantity"));
            cbCategory.DataBindings.Add(new Binding("SelectedValue", dgvListProduct.DataSource, "CategoryId"));
            lblImageFileName.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "ProductImage"));
        }
        void AddCategoryBinding()
        {
            txtCategoryNameCanEdit.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "CategoryName"));
            txtCategoryId.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "CategoryId"));
            txtCategoryDate.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "ModifiedDate"));
        }
        void AddBrandBinding()
        {
            txtNameBrandEdit.DataBindings.Add(new Binding("Text", dgvBrand.DataSource, "BrandName"));
        }
        void AddUserBinding()
        {
            txtEditFullName.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "FullName"));
            txtEditEmailUser.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "EmailAdress"));
            txtEditIdUser.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "UserId"));
            txtEditPhone.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "PhoneNumber"));
            txtEditTypeUser.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "UserType"));
        }
        void LoadCategory()
        {
            CategoryDAO cate = new CategoryDAO();
            dt = cate.GetAllCategory();
            CategoryList.DataSource = dt;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
            cbCategory.DataSource = dt;
        }
        void LoadUserList()
        {
            UserDAO user = new UserDAO();
            dt = user.GetAllUser();
            UserList.DataSource = dt;
        }
        void LoadBrandList()
        {
            BrandDAO brand = new BrandDAO();
            DataTable dt = brand.GetAllBrand();
            BrandList.DataSource = dt;
            cbBand.DisplayMember = "BrandName";
            cbBand.ValueMember = "BrandId";
            cbBand.DataSource = dt;
        }
        void LoadProductList()
        {
            ProductDAO pro = new ProductDAO();
            ProductList.DataSource = pro.GetAllProduct();
        }
        void LoadOrderList()
        {
            OrderDAO ord = new OrderDAO();
            OrderList.DataSource = ord.GetAllOrder();
        }

        #endregion


        #region event
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofdImage.ShowDialog();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name=txtNameProduct.ToString();
            string description=txtDescription.ToString();
            string img = pbImage.ToString();
            string  brandname=cbBand.ToString();
            float price=float.Parse(txtPrice.ToString());
            int quality=int.Parse(txtQuantity.ToString());
            int cateid=int.Parse(cbCategory.ToString());
        }

        private void lblImageFileName_TextChanged(object sender, EventArgs e)
        {
            Image image = Image.FromFile( System.IO.Directory.GetCurrentDirectory()+@"\product-images\" + lblImageFileName.Text);
            pbImage.Image = image;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryDAO cate = new CategoryDAO();
            if (cate.AddCategory(txtCategoryName.Text.Replace("'", "''")))
            {
                MessageBox.Show("Thêm thành công!");
                LoadCategory();
            }
            else
                MessageBox.Show("Có lỗi xảy ra");
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            CategoryDAO cate = new CategoryDAO();
            if (cate.DeleteCategory(int.Parse(txtCategoryId.Text)))
            {
                MessageBox.Show("Xóa thành công!");
                LoadCategory();
            }
            else
                MessageBox.Show("Có lỗi xảy ra");

        }
        #endregion

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            CategoryDAO cate = new CategoryDAO();
            if (cate.EditCategory(int.Parse(txtCategoryId.Text),txtCategoryNameCanEdit.Text))
            {
                MessageBox.Show("Sửa thành công!");
                LoadCategory();
            }
            else
                MessageBox.Show("Có lỗi xảy ra");
        }

        private void fManager_Load(object sender, EventArgs e)
        {

        }



    }
}
