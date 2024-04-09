using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    internal class Phong
    {
        public Phong(string maphong, string loaiphong, double giaphong, int songuoi, int tinhtrang)
        {
            this.MaPhong = maphong;
            this.LoaiPhong = loaiphong;
            this.GiaPhong = giaphong;
            this.SoNguoi = songuoi;
            this.TinhTrang = tinhtrang;
        }
        public Phong(DataRow row)
        {
            this.MaPhong = row["MAPHONG"].ToString();
            this.LoaiPhong = row["LOAIPHONG"].ToString();
            this.GiaPhong = (double)row["GIAPHONG"];
            this.SoNguoi = (int)row["SONGUOI"];
            this.TinhTrang = (int)row["TINHTRANG"];
        }
        private string maphong;
        public string MaPhong
        {
            get { return maphong; }
            set { maphong = value; }
        }
        private string loaiphong;
        public string LoaiPhong
        {
            get { return loaiphong; }
            set { loaiphong = value; }
        }

        private double giaphong;
        public double GiaPhong
        {
            get { return giaphong; }
            set { giaphong = value; }
        }
        private int songuoi;
        public int SoNguoi
        {
            get { return songuoi; }
            set { songuoi = value; }
        }
        private int tinhtrang;
        public int TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
    }
}
