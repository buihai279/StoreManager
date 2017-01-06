using StoreManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace StoreManager
{
    class BrandDAO
    {
        private DataTable dt;
        private string query = "";
        public DataTable GetAllBrand()
        {
            query = "SELECT * FROM v_GetAllBrand";

            dt = DataProvider.ExcuteQuery(query);

            return dt;
        }
    }
}
