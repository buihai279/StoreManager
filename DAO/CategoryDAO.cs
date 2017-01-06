using StoreManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace StoreManager
{
    public class CategoryDAO
    {
        private DataTable dt;
        private string query="";
        public DataTable GetAllCategory()
        {
            query = "SELECT * FROM v_GetAllCategory";

            dt = DataProvider.ExcuteQuery(query);

            return dt;
        }
    }
}
