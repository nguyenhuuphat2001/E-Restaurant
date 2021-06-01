using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class ReportDTO
    {
        int id;
        float price;

        public int Id { get => id; set => id = value; }
        public ReportDTO(int id, int price = 0)
        {
            this.id = id;
            this.price = price;
        }
        public ReportDTO(DataRow row)
        {
            this.id = (int)row["id"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
        }
        public float Price { get => price; set => price = value; }
    }
}
