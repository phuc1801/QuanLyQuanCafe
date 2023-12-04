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
            txtID.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "ID"));
            txtTenMon.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name"));
            txtPrice.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Price"));

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
            if(dgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;               
                Category category = CategoryDAO.Instance.GetCategoryByID(id);
                cbFoodCategory.SelectedItem = category;

                int index = -1;
                int i = 0;
                foreach(Category item in cbFoodCategory.Items)
                {
                    if(item.ID == category.ID)
                    {
                        index = i; break;
                    }
                    i++;
                }
                cbFoodCategory.SelectedIndex = index;
            }
            
        }
    }
}
