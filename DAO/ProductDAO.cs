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
    }
}
