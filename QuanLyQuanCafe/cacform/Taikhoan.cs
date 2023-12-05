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
        BindingSource accountList = new BindingSource();
       
        public Taikhoan()
        {
           
            InitializeComponent();
            loadAccountLisr();
            dgvAccount.DataSource = accountList;
            addAcountBinding();
            loadAccount();
        }

      
        void addAcountBinding()
        {
            txtUserName.DataBindings.Add("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never);
            txtDisplayName.DataBindings.Add("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never);
            txtType.DataBindings.Add("Text", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never);
           // txtMatKhau.DataBindings.Add("Text", dgvAccount.DataSource, "PassWord", true, DataSourceUpdateMode.Never);
            
        }

        void loadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.getListAccount();
        }


        void loadAccountLisr()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";
            
            dgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"phuc"});
        }

        private void iBtnDSBxem_Click(object sender, EventArgs e)
        {
            loadAccount();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }


        void addAccount(string userName, string displayName, int type)
        {
            if(AccountDAO.Instance.InsertAccount(userName, displayName, type)) {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            loadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhập tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhập tài khoản thất bại");
            }
            loadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xoá tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xoá tài khoản thất bại");
            }
            loadAccount();
        }

        void ThaydoiAccount(string passWord)
        {
            if (AccountDAO.Instance.ChangePass(passWord))
            {
                MessageBox.Show("Thay đổi tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thay đổi tài khoản thất bại");
            }
            loadAccount();
        }

        private void iBtnDSBthem_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;   
            int type = Convert.ToInt32(txtType.Text);
            addAccount(userName, displayName, type);
        }

        private void iBtnDSBxoa_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
      
            DeleteAccount(userName);
        }

        private void iBtnDSBsua_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = Convert.ToInt32(txtType.Text);
            EditAccount(userName, displayName, type);
        }


        
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            //string passWord = txtPassWord.Text;

            //ThaydoiAccount(passWord);
        }
    }
}
