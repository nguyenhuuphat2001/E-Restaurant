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

        public List<BillInfoDTO>GetListRevenue(int month)
        {
            List<BillInfoDTO> list = new List<BillInfoDTO>();
            string query = "SELECT f.name, bf.count,f.price, f.price* bf.count as totalPrice from BillInfo as bf, Bill as b , Food as f where b.id = bf.idBill and f.id = bf.idFood and b.status = 1 and month(b.DateCheckIn) = "+month+" group by f.name, bf.count, f.price"; 
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                BillInfoDTO bill = new BillInfoDTO(row);
                list.Add(bill);
            }
            return list;
        }
        public List<BillInfoDTO>GetListRevenue(int month, int year)
        {
            List<BillInfoDTO> list = new List<BillInfoDTO>();
            string query = "SELECT f.name, bf.count,f.price, f.price*bf.count as totalPrice from BillInfo as bf, Bill as b , Food as f where b.id = bf.idBill and f.id = bf.idFood and b.status = 1 and month(b.DateCheckIn) = "+month+" and year(b.DateCheckIn) = "+year+" group by f.name, bf.count, f.price";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillInfoDTO bill = new BillInfoDTO(row);
                list.Add(bill);
            }
            return list;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }

        public int GetBillInfo(int idBill,int idFood)
        {
         
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT id FROM BillInfo where idBill="+idBill+ "and idFood= "+idFood);
            }
            catch
            {
                return -1;
            }
        }

        public int GetCount(int idBillInfo)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT count FROM BillInfo where id = " +idBillInfo);
            }
            catch
            {
                return -1;
            }
        }
    }
}
