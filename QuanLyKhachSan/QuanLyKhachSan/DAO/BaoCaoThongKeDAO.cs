using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    internal class BaoCaoThongKeDAO
    {
        private static BaoCaoThongKeDAO instance;
        public static BaoCaoThongKeDAO Instance { get { if (instance == null) instance = new BaoCaoThongKeDAO(); return instance; } }
        private BaoCaoThongKeDAO()
        {

        }

        #region Method
        public DataTable LoadReportDay(DateTime date)
        {
            string query = "USP_LoadReportDay @date";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { date });
        }

        public DataTable LoadReportMonth(DateTime date)
        {
            string query = "USP_LoadReportMonth @date";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { date });
        }

        public DataTable LoadReportYear(DateTime date)
        {
            string query = "USP_LoadReportYear @date";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { date });
        }
        #endregion
    }
}
