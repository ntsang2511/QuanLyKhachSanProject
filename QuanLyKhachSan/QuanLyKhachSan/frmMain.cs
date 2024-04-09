using QuanLyKhachSan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public frmMain()
        {
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

        void loadfrmNhanVien(String tenTo)
        {
            frmNhanVien frm = new frmNhanVien(tenTo);
            frm.ShowDialog();
        }
        private void btnGiatLa_Click(object sender, EventArgs e)
        {
            loadfrmNhanVien("2");
        }

        private void btnDonPhong_Click(object sender, EventArgs e)
        {
            loadfrmNhanVien("1");

        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            loadfrmNhanVien("3");
        }

        private void btnTongDai_Click(object sender, EventArgs e)
        {
            loadfrmNhanVien("4");
        }

        private void btnBep_Click(object sender, EventArgs e)
        {
            loadfrmNhanVien("5");
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frmQuanLy = new frmQuanLyTaiKhoan();
            frmQuanLy.ShowDialog();
        }
    }
}