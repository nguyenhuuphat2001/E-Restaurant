using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    class BillDAO
    {
        private static BillDAO instance;

        internal static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
            set
            {
                BillDAO.instance = value;
            }
        }
        private BillDAO() { }
        public string GetDateCheckOut()
        {
            return DateTime.Now.ToString();
        }

        public string GetDateCheckInByTable(int id)
        {
            string query = "select b.DateCheckIn from Bill b where b.idTable = " + id + " and b.status = 0";
            string dateCheckIn;
            
            dateCheckIn = Convert.ToString(DataProvider.Instance.ExecuteScalar(query));
            
            
            return dateCheckIn;
        }
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill where idTable = " + id + "AND status = 0");
            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        public void CheckOut(int id)
        {
            string query = "UPDATE dbo.Bill SET status = 1 WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void UpdateDiscount(int id,int discount)
        {
            string query = "UPDATE dbo.Bill SET discount =" + discount + "WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int GetDiscount(int id)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT discount FROM Bill where id=" + id);
            }
            catch
            {
                return 0;
            }
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
    }
}
