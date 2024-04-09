using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
            //string query = "USP_LoadReportDay @date";
            string sdate = date.ToString("yyyy-MM-dd");
            string query = "SELECT P.LOAIPHONG AS name, SUM(H.TONGTIEN) AS value, '' AS rate FROM PHONG P INNER JOIN DATPHONG D ON D.MAPHONG = P.MAPHONG INNER JOIN HOADON H ON H.MADP = D.MADP AND H.NGAYLAP = '" + sdate + "' GROUP BY P.LOAIPHONG";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { date });
        }

        public DataTable LoadReportMonth(DateTime date)
        {
            //string query = "USP_LoadReportMonth @date";
            string query = "SELECT P.LOAIPHONG AS name, SUM(H.TONGTIEN) AS value, '' AS rate FROM PHONG P INNER JOIN DATPHONG D ON D.MAPHONG = P.MAPHONG INNER JOIN HOADON H ON H.MADP = D.MADP AND MONTH(H.NGAYLAP) = " + date.Month + " AND YEAR(H.NGAYLAP) = " + date.Year + " GROUP BY P.LOAIPHONG";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { date });
        }

        public DataTable LoadReportYear(DateTime date)
        {
            //string query = "USP_LoadReportYear @date";
            string query = "SELECT P.LOAIPHONG AS name, SUM(H.TONGTIEN) AS value, '' AS rate FROM PHONG P INNER JOIN DATPHONG D ON D.MAPHONG = P.MAPHONG INNER JOIN HOADON H ON H.MADP = D.MADP AND YEAR(H.NGAYLAP) = " + date.Year + " GROUP BY P.LOAIPHONG";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { date });
        }
        #endregion
    }
}
