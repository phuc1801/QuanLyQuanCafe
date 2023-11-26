using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord) {
            string query = "SELECT * FROM Account WHERE UserName = '"+userName+"' AND PassWord = '"+passWord+"'";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            return res.Rows.Count > 0;
        }
    }
}
