using StoreManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace StoreManager
{
    class UserDAO
    {
        private static DataProvider provider = new DataProvider();
        private DataTable dt;
        private string query="";
        public bool Login(string userName, string passWord)
        {
            query = "exec spCheckPassword @UserName='" + userName + "', @Password='" + passWord + "'";

            dt = provider.ExcuteQuery(query);

            return dt.Rows.Count > 0;
        }

        public bool ChangePassword(string emailAdress, string passWord, string newPassWord, string phone, string fullname)
        {
            query = "exec spChangePassword @email='" + emailAdress + "', @password='" + passWord + "', @newpassword='" + newPassWord + "', @phone='" + phone + "', @fullname='" + fullname + "'";

            int result = provider.ExcuteNonQuery(query);
            return result > 0;
        }
        public DataTable GetInfoAccount(string emailAdress)
        {
            query = "EXEC dbo.spGetAccountByMail @mail =N'"+emailAdress+"'";

            dt = provider.ExcuteQuery(query);

            return dt;
        }
    }
}
