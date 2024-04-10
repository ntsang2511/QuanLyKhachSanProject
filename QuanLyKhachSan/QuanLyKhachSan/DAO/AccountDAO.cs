using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO(){}

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.NHANVIEN WHERE TAIKHOAN = N'" + userName + "' AND MATKHAU = N'" + passWord + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

    }
}
