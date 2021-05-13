using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class AccountDTO
    {
        private string userName;
        private int iDStaff;
        private string password;
        private int type;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
        public int IDStaff { get => iDStaff; set => iDStaff = value; }

        public AccountDTO(string userName, int idStaff, int type, string password = null)
        {
            this.UserName = userName;
            this.IDStaff = idStaff;
            this.Password = password;
            this.Type = type;
        }
        public AccountDTO(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.IDStaff = (int)row["idStaff"];
            this.Password = row["password"].ToString();
            this.Type = (int)row["type"];
        }
    }
}
