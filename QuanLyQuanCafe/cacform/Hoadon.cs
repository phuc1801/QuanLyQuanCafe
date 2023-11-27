
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
            loadTable();
        }
        
        void loadTable()
        {
            List<Table> tableList = TableDAO.Instance.loadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                switch (item.Status)
                {
                    case "Trống":
                            btn.BackColor = Color.White; break;
                    default: btn.BackColor = Color.SkyBlue; break;
                }
                flptabFood.Controls.Add(btn);
            }
        }

       
    }
}
