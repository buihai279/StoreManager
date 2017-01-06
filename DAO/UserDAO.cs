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
        private string query="";
        private DataTable dt;
        public bool Login(string userName, string passWord)
        {
            query = "exec spCheckPassword @UserName='" + userName + "', @Password='" + passWord + "'";

            dt = DataProvider.ExcuteQuery(query);

            return dt.Rows.Count > 0;
        }

        public bool ChangePassword(string emailAdress, string passWord, string newPassWord, int phone, string fullname)
        {
            query = "exec spChangePassword @email='" + emailAdress + "', @password='" + passWord + "', @newpassword='" + newPassWord + "', @phone='" + phone + "', @fullname=N'" + fullname + "'";

            int result = DataProvider.ExcuteNonQuery(query);
            return result > 0;
        }
        public DataTable GetInfoAccount(string emailAdress)
        {
            query = "EXEC dbo.spGetAccountByMail @mail =N'"+emailAdress+"'";

            dt = DataProvider.ExcuteQuery(query);

            return dt;
        }
        public DataTable GetAllUser()
        {
            query = "SELECT DISTINCT * FROM v_GetAllUser";

            dt = DataProvider.ExcuteQuery(query);

            return dt;
        }
    }
}
