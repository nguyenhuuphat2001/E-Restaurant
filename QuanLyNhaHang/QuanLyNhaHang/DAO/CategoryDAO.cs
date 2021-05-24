using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return CategoryDAO.instance;
            }
            private set => instance = value; 
        }

        private CategoryDAO() { }

        public List<CategoryDTO> GetListCategory()
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                CategoryDTO category = new CategoryDTO(item);
                categories.Add(category);
            }
            return categories;
        }
        public bool InsertCategory(string name)
        {
            string query = "INSERT FoodCategory VALUES ('" + name + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCategory(string name, int id)
        {
            string query = string.Format("UPDATE FoodCategory Set name = '{0}' where id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
            string query = string.Format("Delete FoodCategory where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public string GetCategoryByID(int id)
        {
            string query = string.Format("select fc.name from FoodCategory fc where fc.id = " + id);
            string name = DataProvider.Instance.ExecuteScalar(query).ToString();
            return name;
        }
    }
}
