using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return instance; 
            }
            private set => instance = value; 
        }
        private MenuDAO() { }

        public List<MenuDTO> GetListMenuByTable(int id)
        {
            List<MenuDTO> listMenu = new List<MenuDTO>();
            
            string query = "SELECT f.name, bi.count,f.price, f.price*bi.count as totalPrice from BillInfo as bi, Bill as b , Food as f where bi.idBill = b.id and bi.idFood = f.id and b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
