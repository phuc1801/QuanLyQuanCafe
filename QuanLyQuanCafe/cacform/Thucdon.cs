using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanCafe
{
    public partial class Thucdon : Form
    {

        BindingSource foodList = new BindingSource();
        public Thucdon()
        {
            InitializeComponent();
            dgvFood.DataSource = foodList;
            loadListFood();
            addFoodBinding();
            loadCategoryIntoCombobox(cbFoodCategory);
        }

        void addFoodBinding()
        {
            txtID.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenMon.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtPrice.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));

        }

        void loadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void loadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            loadListFood();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFood.SelectedCells.Count > 0 &&
                    dgvFood.SelectedCells[0].OwningRow != null &&
                    dgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"] != null &&
                    dgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value != null)
                {
                    int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    if (cateogory != null)
                    {
                        cbFoodCategory.SelectedItem = cateogory;

                        int index = -1;
                        int i = 0;
                        foreach (Category item in cbFoodCategory.Items)
                        {
                            if (item.ID == cateogory.ID)
                            {
                                index = i;
                                break;
                            }
                            i++;
                        }

                        cbFoodCategory.SelectedIndex = index;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
            }


        }

        private void iBtnDSBthem_Click(object sender, EventArgs e)
        {
            string name = txtTenMon.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = float.Parse( txtPrice.Text);

            if(FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                loadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món ăn");
            }
        }

        private void iBtnDSBsua_Click(object sender, EventArgs e)
        {
            string name = txtTenMon.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = float.Parse(txtPrice.Text);
            int id = Convert.ToInt32(txtID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                loadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa món ăn");
            }
        }

        private void iBtnDSBxoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xoá món thành công");
                loadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xoá món ăn");
            }
        }


        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txtSearchFood.Text);
        }
    }
}
