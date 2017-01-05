
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data;
using System.Data.SqlClient;
namespace StoreManager
{
    public class DataProvider
    {

        private SqlConnection sqlCn = null;
        private string strConnection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True";

        private DataTable dt = new DataTable();
        public void OpenConnection(string strconnect)
        {
            sqlCn = new SqlConnection();
            sqlCn.ConnectionString = strconnect;
            sqlCn.Open();
        }
        public void CloseConnection()
        {
            sqlCn.Close();
        }
        public DataTable ExcuteQuery(string query, object[] parameterNames  = null, object[] parameterValues = null)
        {
            OpenConnection(strConnection);
            SqlCommand cmd = new SqlCommand(query, sqlCn);
            if (parameterNames != null && parameterValues != null && parameterNames.Length==parameterValues.Length)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                int i = 0;
                foreach (string item in parameterNames )
                {
                    cmd.Parameters.AddWithValue(item, parameterValues[i]);
                    i++;
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }
        public int ExcuteNonQuery(string query, object[] parameterNames  = null, object[] parameterValues = null)
        {
            int dt = 0;
            OpenConnection(strConnection);
            SqlCommand cmd = new SqlCommand(query, sqlCn);
            if (parameterNames != null && parameterValues != null && parameterNames.Length == parameterValues.Length)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                int i = 0;
                foreach (string item in parameterNames)
                {
                    cmd.Parameters.AddWithValue(item, parameterValues[i]);
                    i++;
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dt = cmd.ExecuteNonQuery();
            CloseConnection();
            return dt;
        }

        public object ExcuteScalar(string query, object[] parameterNames = null, object[] parameterValues = null)
        {
            object dt = 0;
            OpenConnection(strConnection);
            SqlCommand cmd = new SqlCommand(query, sqlCn);
            if (parameterNames != null && parameterValues != null && parameterNames.Length == parameterValues.Length)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                int i = 0;
                foreach (string item in parameterNames)
                {
                    cmd.Parameters.AddWithValue(item, parameterValues[i]);
                    i++;
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dt = cmd.ExecuteScalar();
            CloseConnection();
            return dt;
        }
    }
}
