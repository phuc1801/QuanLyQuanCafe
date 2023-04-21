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
        void loadTable() {
            List<TableDTO> tablelist =  TableDAO.Instance.loadTableList();
            foreach (TableDTO item in tablelist)
            {
                Button btn = new Button() { Width = TableDTO.TableWidth, Height = TableDTO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status1;
                btn.Click += btn_Click;
                btn.Tag= item;
                switch (item.Status1) {
                    case "Có người":
                        btn.BackColor= Color.SkyBlue;
                        break;

                }
                flptabFood.Controls.Add(btn);

            }

        }

        void showBill(int id) {
            listBill.Items.Clear();
            List<Billinfor> listBillinfor = BillinforDAO.Instance.GetListInfor(BillDAO.Instance.GetUncheckBillIDByTableID(id));
            foreach (Billinfor item in listBillinfor) { 
                ListViewItem lvitem = new ListViewItem(item.FoodID.ToString());
                lvitem.SubItems.Add(item.Count.ToString());
                listBill.Items.Add(lvitem); // listBill la thuoc tinh ben ngoai
            }
        }
        void btn_Click(object sender, EventArgs e) {
            int tableID = ((sender as Button).Tag as TableDTO).ID;
            showBill(tableID);
        }
    }
}
