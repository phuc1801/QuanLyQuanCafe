using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;



namespace QuanLyQuanCafe
{
    public partial class Danhsachban : Form
    {

        BindingSource tableFoodList = new BindingSource();
        public Danhsachban()
        {
            InitializeComponent();
            dgvDanhsachban.DataSource = tableFoodList;
            loadTableFood();
            addTableBinding();
           
        }

        void loadTableFood()
        {
            tableFoodList.DataSource = TableDAO.Instance.getListTableFood();
        }


        void addTableBinding()
        {
            txtID.DataBindings.Add("Text", dgvDanhsachban.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtTenBan.DataBindings.Add("Text", dgvDanhsachban.DataSource, "Name", true, DataSourceUpdateMode.Never);
            cbTrangThai.DataBindings.Add("Text", dgvDanhsachban.DataSource, "Status", true, DataSourceUpdateMode.Never);
        }


        


        private void iBtnDSBxem_Click(object sender, EventArgs e)
        {
            loadTableFood();
        }

        void insertTableFood(string name)
        {
            if (TableDAO.Instance.InsertTableFood(name))
            {
                MessageBox.Show("Thêm bàn thành công");
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }
            loadTableFood();
        }

        void updateTableFood(int id, string name)
        {
            if (TableDAO.Instance.UpdateTableFood(id, name))
            {
                MessageBox.Show("Thêm bàn thành công");
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }
            loadTableFood();
        }

        void deleteTableFood(int id)
        {
            if (TableDAO.Instance.DeleteTableFood(id))
            {
                MessageBox.Show("Thêm bàn thành công");
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }
            loadTableFood();
        }

        private void iBtnDSBthem_Click(object sender, EventArgs e)
        {
           // int id = Convert.ToInt32(txtID.Text);
            string name = txtTenBan.Text;
            
            insertTableFood(name);
        }

        private void iBtnDSBxoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            
            deleteTableFood(id);
        }

        private void iBtnDSBsua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtTenBan.Text;
            string status = cbTrangThai.Text;
            updateTableFood(id, name);
        }
    }
}
