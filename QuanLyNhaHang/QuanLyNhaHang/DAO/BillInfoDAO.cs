using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return instance;
            }
            private set => instance = value;
        }
        private BillInfoDAO() { }

        public List<BillInfoDTO> GetListMenuByTable(int id)
        {
            List<BillInfoDTO> listMenu = new List<BillInfoDTO>();
         
            string query = "SELECT f.name, bi.count,f.price, f.price*bi.count as totalPrice from BillInfo as bi, Bill as b , Food as f where bi.idBill = b.id and bi.idFood = f.id and b.status=0 and b.idTable = " + id + "group by f.name, bi.count, f.price";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInfoDTO menu = new BillInfoDTO(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

    }
}
