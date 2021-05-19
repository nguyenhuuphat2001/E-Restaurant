using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    class CategoryDTO
    {
        private int id;
        private string name;
        public CategoryDTO(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public CategoryDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = (string)row["name"].ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
