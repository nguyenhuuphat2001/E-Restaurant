using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;
using System.Data;

namespace QuanLyNhaHang.DAO
{
    class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAO();
                return FoodDAO.instance;

            }
            private set => instance = value;
        }

        private FoodDAO() { }

        public List<FoodDTO> GetFoodByCategoryID(int id)
        {
            List<FoodDTO> list = new List<FoodDTO>();

            string query = "select * from Food where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                list.Add(food);
            }

            return list;
        }

        public int GetOrderQuantityByID(int idFood)
        {
            string query = string.Format("select sum(bf.count) from BillInfo bf where bf.idFood = " + idFood);
            int quantity;

            try
            {
                quantity = (int)DataProvider.Instance.ExecuteScalar(query);
            }
            catch
            {
                quantity = 0;
            }
            return quantity;
        }
        public List<FoodDTO> GetListFood()
        {
            List<FoodDTO> list = new List<FoodDTO>();

            string query = "SELECT * FROM Food ORDER BY idCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                list.Add(food);
            }

            return list;
        }

        public bool AddMeal(string name,int idCategory, float price)
        {
            string query = string.Format("INSERT dbo.Food ( name,idCategory, price ) VALUES  ( N'{0}', {1},{2})", name,idCategory, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool EditMeal(int idFood, string name, int idCategory, float price)
        {
            string query = string.Format("UPDATE dbo.Food SET name = N'{0}', price = {1}, idCategory={2} WHERE id = {3}", name, price, idCategory, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteMeal(string name)
        {
            string query = string.Format("Delete FROM Food where Food.name = N'{0}'",name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int GetIDFoodByName(string name)
        {
            string query = string.Format("Select food.id from Food where food.name = N'{0}'", name);
            int id = DataProvider.Instance.ExecuteNonQuery(query);
            return id;
        }
    }
}
