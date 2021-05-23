using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        private AccountDAO() { }

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set => instance = value;
        }

        public bool Login(string username, string password)
        {

            string query = "EXEC USP_Login @UserName , @PassWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public AccountDTO GetAccountByUserName(string userName)
        {
            string query = "SELECT * FROM Account WHERE userName = '" + userName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }

        public int GetPositionByUserName(string userName)
        {
            string query = "exec USP_GetPositionByUserName @userName";
            int position= (int)DataProvider.Instance.ExecuteScalar(query, new object[] { userName });
            return position;
        }

        public bool UpdateAccount(string userName, string password, string newPass)
        {
            string query = "exec USP_UpdateAccount @userName , @password , @newPassword";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, password, newPass });

            return result > 0;
        }

        public List<AccountDTO> GetListAccount()
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            string query = string.Format("SELECT * FROM Account");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                accounts.Add(account);
            }
            return accounts;
        }

        public int GetIDStaffByPhone(string phone)
        {
            string query = string.Format("SELECT id FROM dbo.Staff WHERE phone='{0}'", phone);
            int id = DataProvider.Instance.ExecuteNonQuery(query);
            return id;
        }

        public int GetIDStaffByUserName(string username)
        {
            string query = string.Format("SELECT id FROM dbo.Staff WHERE userName='{0}'", username);
            int id = DataProvider.Instance.ExecuteNonQuery(query);
            return id;
        }

        public bool InsertAccount(string userName, int idStaff)
        {
            string query = string.Format("INSERT dbo.Account( userName, idStaff) VALUES (N'{0}', {1})", userName, idStaff);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = string.Format("Delete dbo.Account where UserName = {0}", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("UPDATE dbo.Account SET PassWord = 0 where UserName = {0}", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
