using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    internal class DichVuDAO
    {
        private static DichVuDAO instance;

        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return instance; }
            private set { instance = value; }
        }
        private DichVuDAO() { }

        public List<DichVu> GetListDichVu()
        {
            List<DichVu> listDichVu = new List<DichVu>();
            string query = "SELECT MADV, TENDV, DONGIA, ANH FROM dbo.DICHVU order by MADV ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DichVu dichvu = new DichVu(item);
                listDichVu.Add(dichvu);
            }

            return listDichVu;
        }

        public List<DichVu> GetNextDichVu(string id)
        {
            List<DichVu> listDichVu = new List<DichVu>();
            string query = "SELECT MADV, TENDV, DONGIA, ANH FROM dbo.DICHVU WHERE MADV > '" + id + "' order by MADV ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DichVu dichvu = new DichVu(item);
                listDichVu.Add(dichvu);
            }

            return listDichVu;
        }

        public List<DichVu> GetPrevDichVu(string id)
        {
            List<DichVu> listDichVu = new List<DichVu>();
            string query = "SELECT MADV, TENDV, DONGIA, ANH FROM dbo.DICHVU WHERE MADV < '" + id + "' order by MADV ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DichVu dichvu = new DichVu(item);
                listDichVu.Add(dichvu);
            }

            return listDichVu;
        }
    }
}
