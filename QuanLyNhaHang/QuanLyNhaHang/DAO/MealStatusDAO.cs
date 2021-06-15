using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    class MealStatusDAO
    {
        private static MealStatusDAO instance;

        public static MealStatusDAO Instance
        {
            get { if (instance == null) instance = new MealStatusDAO(); return MealStatusDAO.instance; }
            private set { MealStatusDAO.instance = value; }
        }

        private MealStatusDAO() { }

        public List<MealStatusDTO> GetListMealStatuses(int id)
        {
            List<MealStatusDTO> listMealStatuses = new List<MealStatusDTO>();

            string query = "SELECT f.name, bi.count,ms.des,ms.status from BillInfo as bi, Bill as b , Food as f , MealStatus ms where bi.idBill = b.id and bi.idFood = f.id and bi.id = ms.idBillInfo and b.idTable = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MealStatusDTO mealStatus = new MealStatusDTO(item);
                listMealStatuses.Add(mealStatus);
            }

            return listMealStatuses;
        }

        public void InsertMealStatus(int id,string des)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertMealStatus @idBillInfo , @des", new object[] { id,des });
        }

        public void UpdateDes(int idBillInfo,string des)
        {
            string query = "Update dbo.MealStatus set des = "+des+" where idBillInfo ="+idBillInfo;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void DeleteMealStatusByBillInfo(int idBillInfo)
        {
            string query = "DELETE dbo.MealStatus WHERE idBillInfo =" + idBillInfo;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void DeleteMealStatusByTable(int idTable)
        {
            string query = "DELETE dbo.MealStatus FROM BillInfo as bi, Bill as b , Food as f , MealStatus ms WHERE bi.idBill = b.id and bi.idFood = f.id and bi.id = ms.idBillInfo and b.idTable = " + idTable;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
