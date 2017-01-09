using StoreManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace StoreManager
{
    class OrderDetailDAO
    {
        private DataTable dt;
        private string query = "";
        public DataTable GetOrderDetail(int id)
        {
            query = string.Format("EXEC spViewOrderDetail @OrderID={0}",id);

            dt = DataProvider.ExcuteQuery(query);

            return dt;
        }
    }
}
