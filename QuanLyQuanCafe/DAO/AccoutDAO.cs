using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuanCafe.DAO
{
    public class AccoutDAO
    {
        private static AccoutDAO instance;
        public static AccoutDAO Instance
        {
            get { if (instance == null) instance = new AccoutDAO(); return AccoutDAO.instance; }
            private set { AccoutDAO.instance = value; }
        }
        private AccoutDAO() { }
        public bool Login(String userName, String passWord)
        {
            String Query = "Select * from Account Where userName='"+userName+"' and passWordAccount = '"+passWord+ "' ";
            DataTable res = DataProvider.Instance.ExecuteQuery(Query);
            return res.Rows.Count > 0;
        }
       
    }
    
}
