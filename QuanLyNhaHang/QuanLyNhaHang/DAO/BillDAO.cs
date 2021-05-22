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

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill where idTable = " + id + "AND status = 0");
            if(data.Rows.Count>0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
    }
}
