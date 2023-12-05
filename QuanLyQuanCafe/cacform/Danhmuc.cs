using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanCafe
{
    public partial class Danhmuc : Form
    {

        BindingSource DanhMucList = new BindingSource();
        public Danhmuc()
        {
            InitializeComponent();
            dgvDanhMuc.DataSource = DanhMucList;
            addDanhMuc();
            loadDanhMuc();
        }    


        void loadDanhMuc()
        {
            DanhMucList.DataSource = CategoryDAO.Instance.getListDanhMuc();
        }
        void addDanhMuc()
        {
            txtIDDM.DataBindings.Add("Text", dgvDanhMuc.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtTenDM.DataBindings.Add("Text", dgvDanhMuc.DataSource, "Name", true, DataSourceUpdateMode.Never);
        }

        private void iBtnDSBxem_Click(object sender, EventArgs e)
        {
            loadDanhMuc();
        }

        void addDanhMuc(string name)
        {
            if (CategoryDAO.Instance.InsertDanhMuc(name)) 
            {
                MessageBox.Show("Thêm danh mục thành công");
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại");
            }
            loadDanhMuc();
        }

        void editDanhMuc(int id, string name)
        {
            if (CategoryDAO.Instance.UpdateDanhMuc(id, name))
            {
                MessageBox.Show("Sửa danh mục thành công");
            }
            else
            {
                MessageBox.Show("Sửa danh mục thất bại");
            }
            loadDanhMuc();
        }

        void deleteDanhMuc(int id)
        {
            if (CategoryDAO.Instance.DeleteDanhMuc(id))
            {
                MessageBox.Show("Xoá danh mục thành công");
            }
            else
            {
                MessageBox.Show("Xoá danh mục thất bại");
            }
            loadDanhMuc();
        }

        private void iBtnDSBthem_Click(object sender, EventArgs e)
        {
            string name = txtTenDM.Text;
            addDanhMuc(name);
        }

        private void iBtnDSBxoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDM.Text);
            deleteDanhMuc(id);
        }

        private void iBtnDSBsua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDM.Text);
            string name = txtTenDM.Text;
            editDanhMuc(id, name);
        }
    }
}
