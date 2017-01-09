using StoreManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace StoreManager
{
    class ProductDAO
    {
        private DataTable dt;
        private string query = "";
        public DataTable GetAllProduct()
        {
            query = "SELECT * FROM v_GetAllProducts";

            dt = DataProvider.ExcuteQuery(query);

            return dt;
        }
        public DataTable SearchProduct(string str)
        {
            query = string.Format("EXEC spSearchProduct @keyword=N'{0}'",str);

            dt = DataProvider.ExcuteQuery(query);

            return dt;
        }
        public bool DeleteProduct(int id)
        {
            query = string.Format("EXEC spDeleteProduct @ProductID={0};", id);

            int result = DataProvider.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool AddProduct(string name, string des, string img, int cateid, int qtl, int pri, int brandid)
        {
            query = string.Format("EXEC spInsertProduct @ProductName='{0}',@ProductDes='{1}',@ProductImg='{2}',@CategoryID={3},@Quantity={4},@Price={5},@brandid={6}", name, des, img, cateid, qtl, pri, brandid);

            int result = DataProvider.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool EditProduct(int id,string name, string des, string img, int cateid, int qtl, int pri, int brandid)
        {
            query = string.Format("EXEC spUpdateProduct @ProductID={0},@ProductName='{1}',@ProductDes='{2}',@ProductImg='{3}',@CategoryID={4},@Quantity={5},@Price={6},@Brand={7}", id, name, des, img, cateid, qtl, pri, brandid);

            int result = DataProvider.ExcuteNonQuery(query);

            return result > 0;
        }

    }
}