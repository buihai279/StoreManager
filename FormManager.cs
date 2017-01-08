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
            Load();
        }
        #region method
        void Load() 
        {
            dgvListProduct.DataSource = ProductList;
            dgvAddProduct.DataSource = ProductList;
            dgvCategory.DataSource = CategoryList;
            dgvBrand.DataSource = BrandList;
            dgvUser.DataSource = UserList;
            dgvOrder.DataSource = OrderList;

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
            txtIdProduct.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "ProductId"));
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
            cbAddCategories.DisplayMember = "CategoryName";
            cbAddCategories.ValueMember = "CategoryId";
            cbAddCategories.DataSource = dt;
            cbCategory.SelectedIndex = 1;
            cbAddCategories.SelectedIndex = 1;
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
            cbbAddBrand.DisplayMember = "BrandName";
            cbbAddBrand.ValueMember = "BrandId";
            cbbAddBrand.DataSource = dt;
            cbBand.DataSource = dt;
            cbBand.SelectedIndex = 1;
            cbbAddBrand.SelectedIndex = 1;
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
        private void lblImageFileName_TextChanged(object sender, EventArgs e)
        {
            if (lblImageFileName.Text != null && lblImageFileName.Text != "")
            {
                Image image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\product-images\" + lblImageFileName.Text);
                pbImage.Image = image;
            }
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
        #endregion
        #region method for user
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string fullname=txtAddUserFullName.Text;
            string email=txtAddEmailUser.Text;
            string phone=txtAddPhoneUser.Text;
            string password=txtAddPhoneUser.Text;
            UserDAO us = new UserDAO();
            
            if (us.AddUser(fullname, email, password, phone))
            {
                MessageBox.Show("Thêm thành công thành công!");
                LoadUserList();
            }
            else
                MessageBox.Show("Có lỗi xảy ra");
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtEditIdUser.Text);
            UserDAO us = new UserDAO();
            if (us.DeleteUser(id))
            {
                MessageBox.Show("Xóa thành công thành công!");
                LoadUserList();
            }
            else
                MessageBox.Show("Có lỗi xảy ra");
        }
        #endregion

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            ProductDAO pro = new ProductDAO();
            dt=pro.SearchProduct(text);
            if(dt.Rows.Count>0){
                MessageBox.Show("Tìm kiếm thành công!");
                dgvListProduct.DataSource = dt;
            }
            else
                MessageBox.Show("Có lỗi xảy ra");
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdProduct.Text);
            ProductDAO pro = new ProductDAO();
            if (pro.DeleteProduct(id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadProductList();
            }
            else
                MessageBox.Show("Có lỗi xảy ra");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = txtAddProductName.Text;
            string des = txtAddDescription.Text;
            string img = lblImage.Text;
            int brand = cbbAddBrand.SelectedIndex;
            int cate = cbAddCategories.SelectedIndex;
            int price = int.Parse(txtAddPrice.Text);
            int qlt = int.Parse(txtAddQuality.Text);
            ProductDAO pro = new ProductDAO();
            if (pro.AddProduct(name, des, img, cate, qlt, price, brand))
            {
                MessageBox.Show("Thêm thành công!");
                dgvAddProduct.DataSource = pro.GetAllProduct();
            }
            else
                MessageBox.Show("Có lỗi xảy ra");

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdProduct.Text);
            string name = txtNameProduct.Text;
            string des = txtDescription.Text;
            string img = lblImageFileName.Text;
            int brand = cbBand.SelectedIndex;
            int cate = cbCategory.SelectedIndex;
            int price = int.Parse(txtPrice.Text);
            int qlt = int.Parse(txtQuantity.Text);
            ProductDAO pro = new ProductDAO();
            if (pro.EditProduct(id,name, des, img, cate, qlt, price, brand))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadProductList();
            }
            else
                MessageBox.Show("Có lỗi xảy ra");
        }
    }
}
