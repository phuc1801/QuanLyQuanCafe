
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
using System.Globalization;
using System.Threading;

namespace QuanLyQuanCafe
{
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
            loadTable();
            loadCategory();
        }
        
        void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void loadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Price";
        }

        void loadTable()
        {
            List<Table> tableList = TableDAO.Instance.loadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                //bill

                void showBill(int id)
                {
                    listBill.Items.Clear();
                    List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
                    float totalPrice = 0;
                    foreach(QuanLyQuanCafe.DTO.Menu info in listBillInfo)
                    {
                        ListViewItem lsvItem = new ListViewItem(info.FoodName.ToString());
                        lsvItem.SubItems.Add(info.Count.ToString());
                        lsvItem.SubItems.Add(info.Price.ToString());
                        lsvItem.SubItems.Add(info.TotalPrice.ToString());
                        totalPrice += info.TotalPrice;
                        listBill.Items.Add(lsvItem);
                    }
                    CultureInfo culture = new CultureInfo("vi-VN");
                    Thread.CurrentThread.CurrentCulture = culture;
                    txtTotalPrice.Text = totalPrice.ToString("c");
                }

                void btn_Click(object sender, EventArgs e)
                {
                    int tableID = ((sender as Button).Tag as Table).ID;
                    listBill.Tag = (sender as Button).Tag;
                    showBill(tableID);
                }



                // them ban an
                switch (item.Status)
                {
                    case "Trống":
                            btn.BackColor = Color.White; break;
                    default: btn.BackColor = Color.SkyBlue; break;
                }
                flptabFood.Controls.Add(btn);
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if(cb.SelectedIndex == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            loadFoodListByCategoryID(id);
        }

        private void btnThemmon_Click(object sender, EventArgs e)
        {
            Table table = listBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = 0; // fix32p
            if(idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
        }
    }
}
