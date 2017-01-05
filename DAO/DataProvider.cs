
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data;
using System.Data.SqlClient;
namespace StoreManager.DAO
{
    public class DataProvider
    {
        private static SqlConnection sqlCn = null;
        private string strConnection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True";

        private DataTable dt = new DataTable();
        public static void OpenConnection(string strconnect)
        {
            sqlCn = new SqlConnection();
            sqlCn.ConnectionString = strconnect;
            sqlCn.Open();
        }
        public void CloseConnection()
        {
            sqlCn.Close();
        }
        public DataTable ExcuteQuery(string query)
        {
            OpenConnection(strConnection);
            SqlCommand cmd = new SqlCommand(query, sqlCn);
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }
        public int ExcuteNonQuery(string query)
        {
            int rowcount = 0;
            OpenConnection(strConnection);
            SqlCommand cmd = new SqlCommand(query, sqlCn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            rowcount = cmd.ExecuteNonQuery();
            CloseConnection();
            return rowcount;
        }

        public object ExcuteScalar(string query)
        {
            object dt = 0;
            OpenConnection(strConnection);
            SqlCommand cmd = new SqlCommand(query, sqlCn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dt = cmd.ExecuteScalar();
            CloseConnection();
            return dt;
        }
    }
}
