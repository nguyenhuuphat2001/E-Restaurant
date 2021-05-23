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
        private int iD;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int ID { get => iD; set => iD = value; }
        public int IDStaff { get => iDStaff; set => iDStaff = value; }

        public AccountDTO(string userName, int idStaff, int id, string password = null)
        {
            this.UserName = userName;
            this.IDStaff = idStaff;
            this.Password = password;
            this.ID = id;
        }
        public AccountDTO(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.IDStaff = (int)row["idStaff"];
            this.Password = row["passWord"].ToString();
            this.ID = (int)row["id"];
        }
    }
}
