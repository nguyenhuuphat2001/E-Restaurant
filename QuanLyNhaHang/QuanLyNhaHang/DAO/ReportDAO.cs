using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    class ReportDAO
    {
        private static ReportDAO instance;

        public static ReportDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReportDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private ReportDAO() { }

        public List<ReportDTO> GetListRevenue(int month)
        {
            List<ReportDTO> list = new List<ReportDTO>();
            string query = "select b.id , sum(bf.count*f.price) as price from BillInfo bf, Bill b, food f where b.id = bf.idBill and f.id = bf.idFood and b.status = 1 and month(b.DateCheckIn) = " + month + " group by b.id, bf.idFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ReportDTO report = new ReportDTO(row);
                list.Add(report);
            }
            return list;
        }

        public List<ReportDTO> GetListRevenue(int month, int year)
        {
            List<ReportDTO> list = new List<ReportDTO>();
            string query = "select b.id , sum(bf.count*f.price) as price from BillInfo bf, Bill b, food f where b.id = bf.idBill and f.id = bf.idFood and b.status = 1 and month(b.DateCheckIn) = " + month + " and year(b.DateCheckIn) =" + year + " group by b.id, bf.idFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ReportDTO report = new ReportDTO(row);
                list.Add(report);
            }
            return list;
        }
    }
}
