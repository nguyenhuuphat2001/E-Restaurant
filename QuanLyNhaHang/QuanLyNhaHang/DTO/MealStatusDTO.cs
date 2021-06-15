using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    class MealStatusDTO
    {
        private String foodname;
        private int count;
        private String description;
        private int status;


        public MealStatusDTO()
        {
        }

        public MealStatusDTO(String foodname, int count, String des, int status)
        {
            this.foodname = foodname;
            this.count = count;
            this.description = des;
            this.status = status;
        }

        public MealStatusDTO(DataRow row)
        {
            this.foodname = (String)row["name"];
            this.count = (int)row["count"];
            this.description = (String)row["des"];
            this.status = (int)row["status"];
        }
        public string Description { get => description; set => description = value; }
        public int Status { get => status; set => status = value; }
        public string Foodname { get => foodname; set => foodname = value; }
        public int Count { get => count; set => count = value; }
    }
}
