using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class Taikhoan : Form
    {

       
        public Taikhoan()
        {
           
            InitializeComponent();
            loadAccountLisr();
        }

      
        



        void loadAccountLisr()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";
            
            dgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"phuc"});
        }
    }
}
