using StoreManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace StoreManager
{
    class ComboBoxUserType
    {
        private string query="";
        private DataTable dt;
        public DataTable GetAllUserType()
        {
            query = "SELECT  * FROM rules";

            dt = DataProvider.ExcuteQuery(query);

            return dt;
        }
    }
}
