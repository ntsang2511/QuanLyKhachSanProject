using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    internal class DichVu
    {
        public DichVu(string maDV, string tenDV, double donGia, string anh)
        {
            this.MaDV = maDV;
            this.TenDV = tenDV;
            this.donGia = donGia;
            this.Anh = anh;
        }
        public DichVu(DataRow row)
        {
            this.MaDV = row["MADV"].ToString();
            this.TenDV = row["TENDV"].ToString();
            this.Anh = row["ANH"].ToString();
            this.DonGia = row["DONGIA"] == DBNull.Value ? 0 : (double)row["DONGIA"];
        }
        private string maDV;
        public string MaDV
        {
            get { return maDV; }
            set { maDV = value; }
        }
        private string tenDV;
        public string TenDV
        {
            get { return tenDV; }
            set { tenDV = value; }
        }
        private string anh;
        public string Anh
        {
            get { return anh; }
            set { anh = value; }
        }
        private double? donGia;
        public double? DonGia
        {
            get
            {
                if (donGia != null) return donGia;
                else return 0;
            }
            set { donGia = value; }
        }
    }
}
