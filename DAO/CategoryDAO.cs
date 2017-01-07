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
        private string query = "";
        public DataTable GetAllCategory()
        {
            query = "SELECT * FROM v_GetAllCategory";

            dt = DataProvider.ExcuteQuery(query);

            return dt;
        }
        public bool DeleteCategory(int CateId)
        {
            
            query = string.Format("EXEC dbo.spDeleteCategory @CateID={0}",CateId.ToString());

            int result = DataProvider.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool AddCategory(string Catename)
        {
            query = string.Format(@"EXEC dbo.spInsertCategory @Catename=N'{0}'", Catename);

            int result = DataProvider.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool EditCategory(int cateid,string Catename)
        {
            query = string.Format(@"EXEC spUpdateCategory @CateID={0},@CateName=N'{1}'", cateid,Catename);

            int result = DataProvider.ExcuteNonQuery(query);

            return result>0;
        }
    }
}
