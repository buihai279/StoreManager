using StoreManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace StoreManager
{
    class OrderDAO
    {
        private DataTable dt;
        private string query = "";

        public DataTable GetAllOrder()
        {
            query = "SELECT * FROM v_GetAllOrder";

            dt = DataProvider.ExcuteQuery(query);

            return dt;
        }
    }
}
