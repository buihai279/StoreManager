﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data;
using System.Data.SqlClient;
namespace StoreManager.DAO
{
    public static class DataProvider
    {
        private static SqlConnection sqlCn = null;
        private static string strConnection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True";

        public static void OpenConnection(string strconnect)
        {
            sqlCn = new SqlConnection();
            sqlCn.ConnectionString = strconnect;
            sqlCn.Open();
        }
        public static void CloseConnection()
        {
            sqlCn.Close();
        }
        public static DataTable ExcuteQuery(string query)
        {
            DataTable dt = new DataTable();
            OpenConnection(strConnection);
            SqlCommand cmd = new SqlCommand(query, sqlCn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }
        public static int ExcuteNonQuery(string query)
        {
            int rowcount = 0;
            OpenConnection(strConnection);
            SqlCommand cmd = new SqlCommand(query, sqlCn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            rowcount = cmd.ExecuteNonQuery();
            CloseConnection();
            return rowcount;
        }

        public static object ExcuteScalar(string query)
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
