using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        private TableDAO() { }

        public static TableDAO Instance
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return TableDAO.instance;
            }
            private set => instance = value;
        }

        public List<TableDTO> LoadTableList()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            string query = "SELECT * FROM dbo.TableFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public void SwitchTable(int id1, int id2)
        {
            string query = "EXEC USP_SwitchTable @idTable1 , @idTable2";
            DataProvider.Instance.ExecuteQuery(query, new object[] { id1, id2 });
        }

        public void SetTableStatus()
        {
            string query = "UPDATE TableFood SET TableFood.status = 'Using' where EXISTS (SELECT * from Bill where TableFood.id = Bill.idTable and Bill.status = 0)";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool AddTable(string name)
        {
            string query = "INSERT dbo.TableFood VALUES ('" + name + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditTable(string name, string status, int id)
        {
            string query = string.Format("UPDATE dbo.TableFood Set name = N'{0}', status = {1}, where id = {2}", name,status, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
            string query = string.Format("Delete dbo.TableFood where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
