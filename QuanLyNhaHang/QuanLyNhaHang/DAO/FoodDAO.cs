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

        public List<FoodDTO> GetListFood()
        {
            List<FoodDTO> list = new List<FoodDTO>();

            string query = "select * from Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                list.Add(food);
            }

            return list;
        }

        public bool AddMeal(string name, int id, float price)
        {
            string query = string.Format("INSERT dbo.Food ( name, idCategory, price ) VALUES  ( N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool EditMeal(int idFood, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteMeal(int idFood)
        {
            string query = string.Format("Delete Food where id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
