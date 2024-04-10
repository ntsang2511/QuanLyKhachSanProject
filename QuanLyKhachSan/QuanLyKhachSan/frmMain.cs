using QuanLyKhachSan;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCafe
{
    public partial class frmMain : Form
    {
        string path = @"..\..\images\";
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        string tenDangNhap;
        string matkhau;
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=SANG-ADVICE\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string userName, string passWord)
        {
            this.tenDangNhap = userName;
            this.matkhau = passWord;
            InitializeComponent();
        }

        #region Init
        private void SetVisibleMenu()
        {
            pnMenu1.Visible = false;
            pnMenu2.Visible = false;
            pnMenu3.Visible = false;
            pnMenu4.Visible = false;
            pnMenu5.Visible = false;
            pnMenu6.Visible = false;
            pnMenu7.Visible = false;
            pnMenu8.Visible = false;
            pnMenu9.Visible = false;
            pnMenu10.Visible = false;
            pnMenu11.Visible = false;
            pnMenu12.Visible = false;
            pnMenu13.Visible = false;
            pnMenu14.Visible = false;
            pnMenu15.Visible = false;
        }
        private void SetEmptyMenu()
        {
            pbImage1.Image = null;
            pbImage2.Image = null;
            pbImage3.Image = null;
            pbImage4.Image = null;
            pbImage5.Image = null;
            pbImage6.Image = null;
            pbImage7.Image = null;
            pbImage8.Image = null;
            pbImage9.Image = null;
            pbImage10.Image = null;
            pbImage11.Image = null;
            pbImage12.Image = null;
            pbImage13.Image = null;
            pbImage14.Image = null;
            pbImage15.Image = null;
            lblName1.Text = string.Empty;
            lblName2.Text = string.Empty;
            lblName3.Text = string.Empty;
            lblName4.Text = string.Empty;
            lblName5.Text = string.Empty;
            lblName6.Text = string.Empty;
            lblName7.Text = string.Empty;
            lblName8.Text = string.Empty;
            lblName9.Text = string.Empty;
            lblName10.Text = string.Empty;
            lblName11.Text = string.Empty;
            lblName12.Text = string.Empty;
            lblName13.Text = string.Empty;
            lblName14.Text = string.Empty;
            lblName15.Text = string.Empty;
            lblGia1.Text = string.Empty;
            lblGia2.Text = string.Empty;
            lblGia3.Text = string.Empty;
            lblGia4.Text = string.Empty;
            lblGia5.Text = string.Empty;
            lblGia6.Text = string.Empty;
            lblGia7.Text = string.Empty;
            lblGia8.Text = string.Empty;
            lblGia9.Text = string.Empty;
            lblGia10.Text = string.Empty;
            lblGia11.Text = string.Empty;
            lblGia12.Text = string.Empty;
            lblGia13.Text = string.Empty;
            lblGia14.Text = string.Empty;
            lblGia15.Text = string.Empty;
        }

        //NOT USE STT
        private void SetRadiobuttonMenu()
        {
            rbSizeM1.Checked = true;
            rbSizeM2.Checked = true;
            rbSizeM3.Checked = true;
            rbSizeM4.Checked = true;
            rbSizeM5.Checked = true;
            rbSizeM6.Checked = true;
            rbSizeM7.Checked = true;
            rbSizeM8.Checked = true;
            rbSizeM9.Checked = true;
            rbSizeM10.Checked = true;
            rbSizeM11.Checked = true;
            rbSizeM12.Checked = true;
            rbSizeM13.Checked = true;
            rbSizeM14.Checked = true;
            rbSizeM15.Checked = true;
            rbSizeM1.Enabled = true;
            rbSizeM2.Enabled = true;
            rbSizeM3.Enabled = true;
            rbSizeM4.Enabled = true;
            rbSizeM5.Enabled = true;
            rbSizeM6.Enabled = true;
            rbSizeM7.Enabled = true;
            rbSizeM8.Enabled = true;
            rbSizeM9.Enabled = true;
            rbSizeM10.Enabled = true;
            rbSizeM11.Enabled = true;
            rbSizeM12.Enabled = true;
            rbSizeM13.Enabled = true;
            rbSizeM14.Enabled = true;
            rbSizeM15.Enabled = true;
            rbSizeL1.Enabled = true;
            rbSizeL2.Enabled = true;
            rbSizeL3.Enabled = true;
            rbSizeL4.Enabled = true;
            rbSizeL5.Enabled = true;
            rbSizeL6.Enabled = true;
            rbSizeL7.Enabled = true;
            rbSizeL8.Enabled = true;
            rbSizeL9.Enabled = true;
            rbSizeL10.Enabled = true;
            rbSizeL11.Enabled = true;
            rbSizeL12.Enabled = true;
            rbSizeL13.Enabled = true;
            rbSizeL14.Enabled = true;
            rbSizeL15.Enabled = true;
        }
        //NOT USE END
        private void SetVisiblePhong()
        {
            btnPhong1.Visible = false;
            btnPhong2.Visible = false;
            btnPhong3.Visible = false;
            btnPhong4.Visible = false;
            btnPhong5.Visible = false;
            btnPhong6.Visible = false;
            btnPhong7.Visible = false;
            btnPhong8.Visible = false;
            btnPhong9.Visible = false;
            btnPhong10.Visible = false;
            btnPhong11.Visible = false;
            btnPhong12.Visible = false;
            btnPhong13.Visible = false;
            btnPhong14.Visible = false;
            btnPhong15.Visible = false;
        }
        private void SetEmptyPhong()
        {
            btnPhong1.Text = string.Empty;
            btnPhong2.Text = string.Empty;
            btnPhong3.Text = string.Empty;
            btnPhong4.Text = string.Empty;
            btnPhong5.Text = string.Empty;
            btnPhong6.Text = string.Empty;
            btnPhong7.Text = string.Empty;
            btnPhong8.Text = string.Empty;
            btnPhong9.Text = string.Empty;
            btnPhong10.Text = string.Empty;
            btnPhong11.Text = string.Empty;
            btnPhong12.Text = string.Empty;
            btnPhong13.Text = string.Empty;
            btnPhong14.Text = string.Empty;
            btnPhong15.Text = string.Empty;
        }
        private void ClearBill()
        {
            txtGhiChu.Text = string.Empty;
            txtTongTien.Text = "0";
            txtKhachDua.Text = "0";
            txtTienThua.Text = "0";
            GiamGia.Value = 0;
        }
        #endregion
        private void ShowPhong()
        {
            SetEmptyPhong();
            SetVisiblePhong();
            List<Phong> listPhong = PhongDAO.Instance.GetListPhong();
            if (listPhong.Count > 0)
            {
                int count = 1;
                foreach (Phong item in listPhong)
                {
                    if (count > 15)
                    {
                        break;
                    }
                    SetItemPhong(item, count);
                    count++;
                }
                btnPrevPhong.Visible = false;
                btnNextPhong.Visible = false;
                if (listPhong.Count > 15)
                {
                    btnPrevPhong.Visible = true;
                    btnPrevPhong.Enabled = false;
                    btnNextPhong.Visible = true;
                    btnNextPhong.Enabled = true;
                }
            }
        }

        private void SetItemPhong(Phong tb, int id)
        {
            Color color = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            string stt = "";
            if (tb.TinhTrang == 0)
            {
                stt = "Trống";
                color = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else if (tb.TinhTrang == 1)
            {
                stt = "Đang sử dụng";
                color = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
            switch (id)
            {
                case 1:
                    btnPhong1.Visible = true;
                    btnPhong1.BackColor = color;
                    btnPhong1.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong1.Tag = tb;
                    break;
                case 2:
                    btnPhong2.Visible = true;
                    btnPhong2.BackColor = color;
                    btnPhong2.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong2.Tag = tb;
                    break;
                case 3:
                    btnPhong3.Visible = true;
                    btnPhong3.BackColor = color;
                    btnPhong3.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong3.Tag = tb;
                    break;
                case 4:
                    btnPhong4.Visible = true;
                    btnPhong4.BackColor = color;
                    btnPhong4.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong4.Tag = tb;
                    break;
                case 5:
                    btnPhong5.Visible = true;
                    btnPhong5.BackColor = color;
                    btnPhong5.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong5.Tag = tb;
                    break;
                case 6:
                    btnPhong6.Visible = true;
                    btnPhong6.BackColor = color;
                    btnPhong6.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong6.Tag = tb;
                    break;
                case 7:
                    btnPhong7.Visible = true;
                    btnPhong7.BackColor = color;
                    btnPhong7.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong7.Tag = tb;
                    break;
                case 8:
                    btnPhong8.Visible = true;
                    btnPhong8.BackColor = color;
                    btnPhong8.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong8.Tag = tb;
                    break;
                case 9:
                    btnPhong9.Visible = true;
                    btnPhong9.BackColor = color;
                    btnPhong9.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong9.Tag = tb;
                    break;
                case 10:
                    btnPhong10.Visible = true;
                    btnPhong10.BackColor = color;
                    btnPhong10.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong10.Tag = tb;
                    break;
                case 11:
                    btnPhong11.Visible = true;
                    btnPhong11.BackColor = color;
                    btnPhong11.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong11.Tag = tb;
                    break;
                case 12:
                    btnPhong12.Visible = true;
                    btnPhong12.BackColor = color;
                    btnPhong12.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong12.Tag = tb;
                    break;
                case 13:
                    btnPhong13.Visible = true;
                    btnPhong13.BackColor = color;
                    btnPhong13.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong13.Tag = tb;
                    break;
                case 14:
                    btnPhong14.Visible = true;
                    btnPhong14.BackColor = color;
                    btnPhong14.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong14.Tag = tb;
                    break;
                case 15:
                    btnPhong15.Visible = true;
                    btnPhong15.BackColor = color;
                    btnPhong15.Text = tb.MaPhong + Environment.NewLine + stt;
                    btnPhong15.Tag = tb;
                    break;

            }
        }

        private void ShowMenuDichVu()
        {
            SetEmptyMenu();
            //SetRadiobuttonMenu();
            SetVisibleMenu();
            List<DichVu> listDichVu = DichVuDAO.Instance.GetListDichVu();
            if (listDichVu.Count > 0)
            {
                int count = 1;
                foreach (DichVu item in listDichVu)
                {
                    if (count > 15)
                    {
                        break;
                    }
                    SetItemMenu(item, count);
                    count++;
                }
                btnPrevDV.Visible = false;
                btnNextDV.Visible = false;
                if (listDichVu.Count > 15)
                {
                    btnPrevDV.Visible = true;
                    btnPrevDV.Enabled = false;
                    btnNextDV.Visible = true;
                    btnNextDV.Enabled = true;
                }
            }
        }

        private void SetItemMenu(DichVu dv, int id)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            System.Drawing.Image image = null;
            if (dv.Anh != "")
            {
                if (File.Exists(path + dv.Anh.Trim()))
                {
                    image = System.Drawing.Image.FromFile(path + dv.Anh.Trim());
                }
            }
            else
            {
                image = System.Drawing.Image.FromFile(path + "noimage.jpg");
            }
            switch (id)
            {
                case 1:
                    pnMenu1.Visible = true;
                    pbImage1.Image = image;
                    pbImage1.Text = id.ToString();
                    pbImage1.Tag = dv;
                    lblName1.Text = dv.TenDV;
                    lblGia1.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 2:
                    pnMenu2.Visible = true;
                    pbImage2.Image = image;
                    pbImage2.Text = id.ToString();
                    pbImage2.Tag = dv;
                    lblName2.Text = dv.TenDV;
                    lblGia2.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 3:
                    pnMenu3.Visible = true;
                    pbImage3.Image = image;
                    pbImage3.Text = id.ToString();
                    pbImage3.Tag = dv;
                    lblName3.Text = dv.TenDV;
                    lblGia3.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 4:
                    pnMenu4.Visible = true;
                    pbImage4.Image = image;
                    pbImage4.Text = id.ToString();
                    pbImage4.Tag = dv;
                    lblName4.Text = dv.TenDV;
                    lblGia4.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 5:
                    pnMenu5.Visible = true;
                    pbImage5.Image = image;
                    pbImage5.Text = id.ToString();
                    pbImage5.Tag = dv;
                    lblName5.Text = dv.TenDV;
                    lblGia5.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 6:
                    pnMenu6.Visible = true;
                    pbImage6.Image = image;
                    pbImage6.Text = id.ToString();
                    pbImage6.Tag = dv;
                    lblName6.Text = dv.TenDV;
                    lblGia6.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 7:
                    pnMenu7.Visible = true;
                    pbImage7.Image = image;
                    pbImage7.Text = id.ToString();
                    pbImage7.Tag = dv;
                    lblName7.Text = dv.TenDV;
                    lblGia7.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 8:
                    pnMenu8.Visible = true;
                    pbImage8.Image = image;
                    pbImage8.Text = id.ToString();
                    pbImage8.Tag = dv;
                    lblName8.Text = dv.TenDV;
                    lblGia8.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 9:
                    pnMenu9.Visible = true;
                    pbImage9.Image = image;
                    pbImage9.Text = id.ToString();
                    pbImage9.Tag = dv;
                    lblName9.Text = dv.TenDV;
                    lblGia9.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 10:
                    pnMenu10.Visible = true;
                    pbImage10.Image = image;
                    pbImage10.Text = id.ToString();
                    pbImage10.Tag = dv;
                    lblName10.Text = dv.TenDV;
                    lblGia10.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 11:
                    pnMenu11.Visible = true;
                    pbImage11.Image = image;
                    pbImage11.Text = id.ToString();
                    pbImage11.Tag = dv;
                    lblName11.Text = dv.TenDV;
                    lblGia11.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 12:
                    pnMenu12.Visible = true;
                    pbImage12.Image = image;
                    pbImage12.Text = id.ToString();
                    pbImage12.Tag = dv;
                    lblName12.Text = dv.TenDV;
                    lblGia12.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 13:
                    pnMenu13.Visible = true;
                    pbImage13.Image = image;
                    pbImage13.Text = id.ToString();
                    pbImage13.Tag = dv;
                    lblName13.Text = dv.TenDV;
                    lblGia13.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 14:
                    pnMenu14.Visible = true;
                    pbImage14.Image = image;
                    pbImage14.Text = id.ToString();
                    pbImage14.Tag = dv;
                    lblName14.Text = dv.TenDV;
                    lblGia14.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
                case 15:
                    pnMenu15.Visible = true;
                    pbImage15.Image = image;
                    pbImage15.Text = id.ToString();
                    pbImage15.Tag = dv;
                    lblName15.Text = dv.TenDV;
                    lblGia15.Text = "Giá: " + dv.DonGia.ToString() + "đ";
                    break;
            }
        }


        bool kiemTraChucVu(string username, string password)
        {
            string connectionString = "Data Source=SANG-ADVICE\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Thực thi câu lệnh SQL
            string sql = "SELECT CHUCVU FROM NHANVIEN WHERE TAIKHOAN ='" + username + "' AND MATKHAU = '" + password + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu và gán vào textbox
            if (reader.Read())
            {
                string chucVu = reader["CHUCVU"].ToString();
                if (chucVu.Equals("Admin"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Đóng kết nối
            reader.Close();
            connection.Close();
            return false;
        }

        string kiemTraNhanVien(string username, string password)
        {
            string connectionString = "Data Source=SANG-ADVICE\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Thực thi câu lệnh SQL
            string sql = "SELECT MADV FROM NHANVIEN WHERE TAIKHOAN ='" + username + "' AND MATKHAU = '" + password + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu và gán vào textbox
            if (reader.Read())
            {
                string dichVu = reader["MADV"].ToString();
                return dichVu;
            }
            // Đóng kết nối
            reader.Close();
            connection.Close();
            return "0";
        }


        void loadfrmNhanVien(String tenTo)
        {
            frmNhanVien frm = new frmNhanVien(tenTo);
            frm.ShowDialog();
        }
        private void btnGiatLa_Click(object sender, EventArgs e)
        {
            if(kiemTraNhanVien(this.tenDangNhap, this.matkhau).Equals("2"))
            {
                loadfrmNhanVien("2");
            }
            else
            {
                return;
            }
        }

        private void btnDonPhong_Click(object sender, EventArgs e)
        {
            if (kiemTraNhanVien(this.tenDangNhap, this.matkhau).Equals("1"))
            {
                loadfrmNhanVien("1");
            }
            else
            {
                return;
            }

        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            if (kiemTraNhanVien(this.tenDangNhap, this.matkhau).Equals("3"))
            {
                loadfrmNhanVien("3");
            }
            else
            {
                return;
            }
        }

        private void btnTongDai_Click(object sender, EventArgs e)
        {
            if (kiemTraNhanVien(this.tenDangNhap, this.matkhau).Equals("4"))
            {
                loadfrmNhanVien("4");
            }
            else
            {
                return;
            }
        }

        private void btnBep_Click(object sender, EventArgs e)
        {
            if (kiemTraNhanVien(this.tenDangNhap, this.matkhau).Equals("5"))
            {
                loadfrmNhanVien("5");
            }
            else
            {
                return;
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemTraChucVu(this.tenDangNhap, this.matkhau))
            {
                frmQuanLyTaiKhoan frmQuanLy = new frmQuanLyTaiKhoan();
                frmQuanLy.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Activate();
            lblUser.Text = "Xin chào, " + this.tenDangNhap;
            lblPhong.Text = "";
            ShowPhong();
            ShowMenuDichVu();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            Phong phong = ((System.Windows.Forms.Button)sender).Tag as Phong;
            if (phong.TinhTrang == 1)
            {
                lblPhong.Text = phong.MaPhong;
                tcMenu.SelectedTab = tpMenu;

                lviHoaDon.Items.Clear();
                string maPhong = phong.MaPhong;

                //Get thong tin dat phong
                //...
                DataTable data = PhongDAO.Instance.GetTTDatPhong(maPhong);
                string maDP = "";
                double tongtien = 0;
                if (data.Rows.Count > 0)
                {
                    DataRow dr = data.Rows[0];
                    maDP = dr["MADP"].ToString();
                    int soNgay = 0;
                    TimeSpan time;
                    if (dr["NGAYTRA"].ToString() == "")
                    {
                        time = DateTime.Now - Convert.ToDateTime(dr["NGAYDEN"].ToString());
                    }
                    else
                    {
                        time = Convert.ToDateTime(dr["NGAYTRA"].ToString()) - Convert.ToDateTime(dr["NGAYDEN"].ToString());
                    }
                    soNgay = time.Days;
                    if (soNgay < 0) { soNgay = 0; }
                    ListViewItem lv = new ListViewItem(dr["MAPHONG"].ToString() + " - Tiền phòng");
                    lv.SubItems.Add(dr["GIAPHONG"].ToString());
                    lv.SubItems.Add(soNgay.ToString());
                    lviHoaDon.Items.Add(lv);
                    tongtien = soNgay * Convert.ToInt32(dr["GIAPHONG"].ToString());

                    DataTable dt = PhongDAO.Instance.GetTTDVPhong(maDP);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            lv = new ListViewItem(row["TENDV"].ToString());
                            lv.SubItems.Add(row["DONGIA"].ToString());
                            lv.SubItems.Add(row["SOLUONG"].ToString());
                            tongtien = tongtien + Convert.ToInt32(row["DONGIA"].ToString()) * Convert.ToInt32(row["SOLUONG"].ToString());
                            lviHoaDon.Items.Add(lv);
                        }
                    }

                    //txtGhiChu.Text = drBill["ghichu"].ToString();
                    txtTongTien.Text = tongtien.ToString("0,00");
                    //GiamGia.Value = Convert.ToInt32(drBill["discount"]);
                }
                else
                {
                    txtGhiChu.Text = "";
                    txtTongTien.Text = "0";
                    GiamGia.Value = 0;
                }

                lviHoaDon.Tag = phong;
            }
            else
            {
                if (MessageBox.Show("Có phải bạn muốn đăng ký thuê phòng không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    frmDangKyThuePhong frm = new frmDangKyThuePhong();
                    frm.ShowDialog();
                }
            }
            txtKhachDua.Text = "0";
        }

        private void btnPrevDV_Click(object sender, EventArgs e)
        {
            SetEmptyMenu();
            SetVisibleMenu();
            List<DichVu> listDichVu = DichVuDAO.Instance.GetPrevDichVu((pbImage1.Tag as DichVu).MaDV);
            if (listDichVu.Count > 0)
            {
                int count = 1;
                foreach (DichVu item in listDichVu)
                {
                    if (count > 15)
                    {
                        break;
                    }
                    SetItemMenu(item, count);
                    count++;
                }
                btnPrevDV.Visible = true;
                btnPrevDV.Enabled = false;
                btnNextDV.Visible = true;
                btnNextDV.Enabled = true;
                if (listDichVu.Count > 15)
                {
                    btnPrevDV.Visible = true;
                    btnPrevDV.Enabled = true;
                }
            }
        }

        private void btnNextDV_Click(object sender, EventArgs e)
        {
            SetEmptyMenu();
            SetVisibleMenu();
            List<DichVu> listDichVu = DichVuDAO.Instance.GetNextDichVu((pbImage15.Tag as DichVu).MaDV);
            if (listDichVu.Count > 0)
            {
                int count = 1;
                foreach (DichVu item in listDichVu)
                {
                    if (count > 15)
                    {
                        break;
                    }
                    SetItemMenu(item, count);
                    count++;
                }
                btnPrevDV.Visible = true;
                btnPrevDV.Enabled = true;
                btnNextDV.Visible = true;
                btnNextDV.Enabled = false;
                if (listDichVu.Count > 15)
                {
                    btnNextDV.Visible = true;
                    btnNextDV.Enabled = true;
                }
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((PictureBox)sender).Text);
            string sTen = "";
            double dGia = 0;
            bool isUpdate = false;
            switch (id)
            {
                case 1:
                    sTen = lblName1.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia1.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 2:
                    sTen = lblName2.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia2.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 3:
                    sTen = lblName3.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia3.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 4:
                    sTen = lblName4.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia4.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 5:
                    sTen = lblName5.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia5.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 6:
                    sTen = lblName6.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia6.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 7:
                    sTen = lblName7.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia7.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 8:
                    sTen = lblName8.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia8.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 9:
                    sTen = lblName9.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia9.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 10:
                    sTen = lblName10.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia10.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 11:
                    sTen = lblName11.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia11.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 12:
                    sTen = lblName12.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia12.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 13:
                    sTen = lblName13.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia13.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 14:
                    sTen = lblName14.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia14.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
                case 15:
                    sTen = lblName15.Text;
                    dGia = Convert.ToDouble((Regex.Split(lblGia15.Text.Replace("đ", ""), ":")[1].ToString()));
                    break;
            }
            if (lviHoaDon.Items.Count > 0)
            {
                foreach (ListViewItem itm in lviHoaDon.Items)
                {
                    if (itm.SubItems[0].Text.Trim() == sTen)
                    {
                        itm.SubItems[2].Text = (Convert.ToInt32(itm.SubItems[2].Text) + 1).ToString();
                        isUpdate = true;
                    }
                }
            }
            if (isUpdate == false)
            {
                ListViewItem item = new ListViewItem(sTen);
                item.SubItems.Add(dGia.ToString());
                item.SubItems.Add("1");
                lviHoaDon.Items.Add(item);
            }
            if (txtTongTien.Text != "")
            {
                txtTongTien.Text = (Convert.ToInt32(txtTongTien.Text.Replace(",", "")) + dGia).ToString("0,00");
            }
            else
            {
                txtTongTien.Text = dGia.ToString("0,00");
            }
        }

        private void lviHoadon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int total = 0;
            if (lviHoaDon.Items.Count < 1) return;
            foreach (int i in lviHoaDon.SelectedIndices)
            {
                if (i == 0) { MessageBox.Show("Không thể xoá phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; } 
                if (Convert.ToInt32(lviHoaDon.Items[i].SubItems[2].Text) == 1)
                {
                    lviHoaDon.Items.Remove(lviHoaDon.Items[i]);
                }
                else
                {
                    lviHoaDon.Items[i].SubItems[2].Text = (Convert.ToInt32(lviHoaDon.Items[i].SubItems[2].Text) - 1).ToString();
                }
            }
            foreach (ListViewItem item in lviHoaDon.Items)
            {
                total = total + Convert.ToInt32(item.SubItems[1].Text) * Convert.ToInt32(item.SubItems[2].Text);
            }
            int giamgia = (int)GiamGia.Value;
            total = total - total * giamgia / 100;
            txtTongTien.Text = String.Format(culture, "{0:N0}", total);
        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThongKe frm = new frmBaoCaoThongKe();
            frm.ShowDialog();
        }

        private void GiamGia_ValueChanged(object sender, EventArgs e)
        {
            if (lviHoaDon.Items.Count > 0)
            {
                decimal total = 0;
                foreach (ListViewItem item in lviHoaDon.Items)
                {
                    total = total + Convert.ToInt32(item.SubItems[1].Text) * Convert.ToInt32(item.SubItems[2].Text);
                }
                int giamgia = (int)GiamGia.Value;
                total = total - total * giamgia / 100;
                txtTongTien.Text = String.Format(culture, "{0:N0}", total);
            }
        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            decimal tienKhach;
            if (decimal.TryParse(txtKhachDua.Text, out tienKhach))
            {
                if (tienKhach > 0)
                {
                    txtTienThua.Text = String.Format(culture, "{0:N0}", tienKhach - Convert.ToDecimal(txtTongTien.Text));
                    txtKhachDua.Text = String.Format(culture, "{0:N0}", tienKhach);
                    txtKhachDua.Select(txtKhachDua.Text.Length, 0);
                }
            }
        }

        private void tcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMenu.SelectedIndex == 0)
            {
                ShowPhong();
            }
            else if (tcMenu.SelectedIndex == 1)
            {
                if (lblPhong.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn phòng để order dịch vụ hoặc thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ShowMenuDichVu();
            }
        }






        // LƯU THÔNG TIN + THANH TOÁN
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lblPhong.Text == "") return;
            string flag = ((System.Windows.Forms.Button)sender).Text;

            //Gọi tới hàm lưu thông tin
            //LuuThongTin(flag);
        }
        public void LuuThongTin(string flag)
        {
            //int stThanhToan = 0; // Trạng thái thanh toán (0:chưa 1: đã thanh toán)
            //int stPhong = 1; // Trạng thái phòng(Đang sử dụng hoặc trống)
            //string message = "Lưu thông tin thành công!";
            //// Nếu nhấn button thanh toán
            //if (flag == "Thanh toán")
            //{
            //    stThanhToan = 1;
            //    stBan = 0;
            //    message = "Thanh toán thành công!";
            //}
            //string idPhong = (lviHoaDon.Tag as Phong).MaPhong;
            ////DataTable dt = ThongTinBillDAO.Instance.GetThongTinBill(idBan);
            //int idBill;
            //bool updateFlag = false;
            ////T/hợp xóa dòng đã order
            //if (dt.Rows.Count > 0)
            //{
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        foreach (ListViewItem item in lviHoaDon.Items)
            //        {
            //            if (row["name"].ToString().Trim() == item.SubItems[0].Text.Trim() && row["size"].ToString().Trim() == item.SubItems[2].Text.Trim())
            //            {
            //                break;
            //            }
            //            ThongTinBillDAO.Instance.deleteThongTinBill(Convert.ToInt32(row["idBill"]), Convert.ToInt32(row["idMon"]), row["size"].ToString());
            //        }
            //    }
            //}
            ////Load lại data bill
            //DataTable data = ThongTinBillDAO.Instance.GetThongTinBill(idBan);
            //if (data.Rows.Count > 0)
            //{
            //    idBill = data.Rows[0].Field<int>("idBill");
            //    // T/hợp thêm hoặc sửa thông tin order
            //    foreach (ListViewItem item in lviHoaDon.Items)
            //    {
            //        updateFlag = false;
            //        foreach (DataRow row in data.Rows)
            //        {
            //            if (item.SubItems[0].Text.Trim() == row["name"].ToString().Trim() && item.SubItems[2].Text.Trim() == row["size"].ToString().Trim())
            //            {
            //                if (item.SubItems[3].Text.Trim() != row["count"].ToString())
            //                {
            //                    ThongTinBillDAO.Instance.updateThongTinBill(Convert.ToInt32(row["idBill"]), Convert.ToInt32(row["idMon"]), row["size"].ToString(), Convert.ToInt32(item.SubItems[3].Text));
            //                }
            //                updateFlag = true;
            //                break;
            //            }
            //        }
            //        if (!updateFlag)
            //        {
            //            int idMon = MenuDAO.Instance.GetIdMon(item.SubItems[0].Text);
            //            ThongTinBillDAO.Instance.InsertThongTinBill(idBill, idMon, item.SubItems[2].Text, Convert.ToInt32(item.SubItems[3].Text));
            //        }
            //    }
            //    BillDAO.Instance.updateBill(idBill, stThanhToan, Convert.ToInt32(GiamGia.Value), Convert.ToDecimal(txtTongTien.Text.Replace(",", "")), txtGhiChu.Text);
            //    TableDAO.Instance.UpdateStatusBan(idBan, stBan);
            //    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    if (lviHoaDon.Items.Count > 0)
            //    {
            //        idBill = BillDAO.Instance.GetMaxIDBill() + 1;
            //        decimal total = 0;
            //        foreach (ListViewItem item in lviHoaDon.Items)
            //        {
            //            total = total + Convert.ToInt32(item.SubItems[1].Text) * Convert.ToInt32(item.SubItems[3].Text);
            //        }
            //        int giamgia = (int)GiamGia.Value;
            //        total = total - total * giamgia / 100;
            //        txtTongTien.Text = String.Format(culture, "{0:N0}", total);
            //        BillDAO.Instance.InsertBill(idBill, idBan, userLogin.IDNhanVien, stThanhToan, giamgia, total, txtGhiChu.Text);
            //        foreach (ListViewItem item in lviHoaDon.Items)
            //        {
            //            int idMon = MenuDAO.Instance.GetIdMon(item.SubItems[0].Text);
            //            ThongTinBillDAO.Instance.InsertThongTinBill(idBill, idMon, item.SubItems[2].Text, Convert.ToInt32(item.SubItems[3].Text));
            //        }
            //        TableDAO.Instance.UpdateStatusBan(idBan, stBan);
            //        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Mời chọn đồ uống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //}
            //if (flag == "Thanh toán")
            //{
            //    if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //    {
            //        PaperSize pageSize = new PaperSize();
            //        pageSize.Width = 302;
            //        printPreviewDialog1.Document = printDocument1;
            //        printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pz", 302, 600);
            //        printPreviewDialog1.ShowDialog();
            //    }
            //    lviHoaDon.Items.Clear();
            //    ClearBill();
            //}
        }

        //XUẤT HÓA ĐƠN
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //string shopName = "COFFE UEF";
            //Font FontHeader = new Font("Time New Roman", 13, FontStyle.Bold);
            //e.Graphics.DrawString(shopName, FontHeader, Brushes.Black, 90, 30);

            //string add = "141 Điện Biên Phủ, P.15, Q.Bình Thạnh";
            //Font FontHeader2 = new Font("Time New Roman", 9, FontStyle.Bold);
            //e.Graphics.DrawString(add, FontHeader2, Brushes.Black, 30, 60);

            //string billName = "HÓA ĐƠN " + lblTable.Text;
            //e.Graphics.DrawString(billName, FontHeader, Brushes.Black, 80, 90);

            //string timeIn = "Giờ vào:    ";
            //e.Graphics.DrawString(timeIn, FontHeader2, Brushes.Black, 30, 120);

            //string timeOut = "Giờ ra:    ";
            //e.Graphics.DrawString(timeOut, FontHeader2, Brushes.Black, 30, 140);


            //Font FontDetail = new Font("Time New Roman", 8, FontStyle.Regular);
            //string header = "Tên hàng" + new string(' ', 30) + "SL" + new string(' ', 5) + "Đơn giá" + new string(' ', 8) + "Thành tiền";
            //e.Graphics.DrawString(header, FontDetail, Brushes.Black, 5, 160);

            //e.Graphics.DrawLine(new Pen(Color.Black, 1), 5, 180, 295, 180);
            //int x = 5;
            //int y = 200;
            //foreach (ListViewItem item in lviHoaDon.Items)
            //{
            //    string name = item.SubItems[0].Text;
            //    int sl = Convert.ToInt32(item.SubItems[3].Text);
            //    int dongia = Convert.ToInt32(item.SubItems[1].Text);
            //    string detail = name + new string(' ', 38 - name.Length) + sl + new string(' ', 7 - sl.ToString().Length) + dongia + new string(' ', 15 - dongia.ToString().Length) + (sl * dongia);
            //    e.Graphics.DrawString(detail, FontDetail, Brushes.Black, x, y);
            //    y += 20;
            //}
            //e.Graphics.DrawLine(new Pen(Color.Black, 1), 5, y, 295, y);


            //Font FontFooter = new Font("Time New Roman", 9, FontStyle.Bold);
            //string giamgia = "Giảm giá: " + new string(' ', 40) + GiamGia.Text + "%";
            //e.Graphics.DrawString(giamgia, FontFooter, Brushes.Black, 5, y + 20);

            //string thanhtien = "Tổng tiền: " + new string(' ', 40) + txtTongTien.Text;
            //e.Graphics.DrawString(thanhtien, FontFooter, Brushes.Black, 5, y + 40);

            //string khachDua = "Khách đưa: " + new string(' ', 40) + txtKhachDua.Text;
            //e.Graphics.DrawString(khachDua, FontFooter, Brushes.Black, 5, y + 60);

            //string tienThua = "Tiền thừa: " + new string(' ', 40) + txtTienThua.Text;
            //e.Graphics.DrawString(tienThua, FontFooter, Brushes.Black, 5, y + 80);
        }
    }
}