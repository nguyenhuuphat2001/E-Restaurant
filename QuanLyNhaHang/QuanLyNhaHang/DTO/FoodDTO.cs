using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhaHang.DTO
{
    class FoodDTO
    {
        public int id;
        private string name;
        private int categoryID;
        private float price;
        
        public FoodDTO(int id, string name, int categoryID, float price, int orderQuantity)
        {
            this.Id = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
            
        }

        public FoodDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = (string)row["name"].ToString();
            this.CategoryID = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());            
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name { get => name; set => name = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public float Price { get => price; set => price = value; }        
    }
}
