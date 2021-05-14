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

        public bool UpdateAccount(string userName, string displayName, string password, string newPass)
        {
            string query = "exec USP_UpdateAccount @userName , @displayName , @password , @newPassword";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, displayName, password, newPass });

            return result > 0;
        }

        public DataTable GetListAccount()
        {
            string query = string.Format("SELECT UserName, DisplayName,Type FROM Account");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool InsertAccount(string userName, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.Account( UserName, DisplayName, Type) VALUES (N'{0}', N'{1}', {2})", userName, displayName, type);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}', Type = {2} WHERE UserName = N'{0}'", userName, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = string.Format("Delete Account where UserName = {0}", userName);
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
