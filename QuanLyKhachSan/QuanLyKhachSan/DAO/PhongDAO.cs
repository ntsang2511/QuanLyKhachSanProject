using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    internal class PhongDAO
    {
        private static PhongDAO instance;
        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return PhongDAO.instance; }
            private set { PhongDAO.instance = value; }
        }

        private PhongDAO() { }

        public List<Phong> GetListPhong()
        {
            List<Phong> listPhong = new List<Phong>();
            string query = "select MAPHONG,LOAIPHONG,GIAPHONG,SONGUOI,TINHTRANG from PHONG order by MAPHONG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                listPhong.Add(phong);
            }

            return listPhong;
        }

        public List<Phong> GetNextPhong(string id)
        {
            List<Phong> listPhong = new List<Phong>();
            string query = "select MAPHONG,LOAIPHONG,GIAPHONG,SONGUOI,TINHTRANG from PHONG where MAPHONG > '" + id + "' order by id ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                listPhong.Add(phong);
            }

            return listPhong;
        }
        public List<Phong> GetPrevPhong(string id)
        {
            List<Phong> listPhong = new List<Phong>();
            string query = "select MAPHONG,LOAIPHONG,GIAPHONG,SONGUOI,TINHTRANG from PHONG where MAPHONG < '" + id + "' order by id ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return listPhong;
        }

        public DataTable GetTTDatPhong(string id)
        {
            string query = "select p.MAPHONG, P.GIAPHONG, DP.MADP, DP.NGAYDEN, DP.NGAYTRA from PHONG P INNER JOIN DATPHONG DP ON DP.MAPHONG = P.MAPHONG AND DP.TRANGTHAI = 'FALSE' where P.MAPHONG = '" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public DataTable GetTTDVPhong(string id)
        {
            string query = "select TT.MADV, DV.TENDV, TT.SOLUONG, DV.DONGIA from THANHTOAN TT INNER JOIN DICHVU DV ON TT.MADV = DV.MADV where TT.MADP = '" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
