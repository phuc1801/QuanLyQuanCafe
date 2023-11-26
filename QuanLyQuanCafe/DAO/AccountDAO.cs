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
            string query = "USP_Login @userName , @passWord";
            DataTable res = DataProvider.Instance.ExecuteQuery(query, new object[] {userName, passWord});
            return res.Rows.Count > 0;
        }
    }
}
