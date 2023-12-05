using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace QuanLyQuanCafe.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        public CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "SELECT * FROM FoodCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow row in data.Rows)
            {
                Category category = new Category(row);
                list.Add(category);
            }
            return list;
        }
        public Category GetCategoryByID(int id) {
            Category category = null;

            string query = "SELECT * FROM FoodCategory WHERE id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                category = new Category(row);
                return category;
            }
            

            return category;
        }
        public DataTable getListDanhMuc()
        {
            return DataProvider.Instance.ExecuteQuery("Select id, name from FoodCategory");
        }

        public bool InsertDanhMuc(string name)
        {
            string query = string.Format("INSERT FoodCategory(name) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDanhMuc(int id, string name)
        {
            string query = string.Format("UPDATE FoodCategory SET name = N'{1}' WHERE id = N'{0}'", id, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDanhMuc(int id)
        {


            string query = string.Format("Delete FoodCategory where id = N'{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
