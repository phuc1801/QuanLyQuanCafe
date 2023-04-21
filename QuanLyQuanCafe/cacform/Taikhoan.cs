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

namespace QuanLyQuanCafe
{
    public partial class Taikhoan : Form
    {
        public Taikhoan()
        {
            InitializeComponent();
            dgvAccount.DataSource = DataProvider.Instance.ExecuteQuery("Select * from Account");

        }

       




        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

    }
}
