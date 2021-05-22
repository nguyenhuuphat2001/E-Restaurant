using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class MenuDTO
    {
        public MenuDTO(string foodName, int count, float price, float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public MenuDTO(DataRow row )
        {
            this.FoodName = row["foodName"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)row["price"];
            this.TotalPrice = (float)row["totalPrice"];
        }

        private float totalPrice;
        private float price;
        private string foodName;
        private int count;
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public float Price { get => price; set => price = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
    }
}
