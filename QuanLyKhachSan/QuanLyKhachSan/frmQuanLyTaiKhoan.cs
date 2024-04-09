using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=SANG-ADVICE\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgv.DataSource = table;
        }
        void loadTextBox()
        {
            txbMaNV.Text = "";
            txbTenNV.Text = "";
            txbChucVu.Text = "";
            txbMaBoPhan.Text = "";
            txbMaDV.Text = "";
            txbTaiKhoan.Text = "";
            txbMatKhau.Text = "";
        }
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO NHANVIEN (MANV, TENNV, CHUCVU, MABP, MADV, TAIKHOAN, MATKHAU) VALUES ('"+txbMaNV.Text+"','" + txbTenNV.Text + "', '"+ txbChucVu.Text + "', '" + txbMaBoPhan.Text +"','" + txbMaDV.Text + "', '" + txbTaiKhoan.Text + "', '" + txbMatKhau.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void txbChucVu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv.CurrentRow.Index;
            txbMaNV.Text = dtgv.Rows[i].Cells[0].Value.ToString();
            txbTenNV.Text = dtgv.Rows[i].Cells[1].Value.ToString();
            txbChucVu.Text = dtgv.Rows[i].Cells[2].Value.ToString();
            txbMaBoPhan.Text = dtgv.Rows[i].Cells[3].Value.ToString();
            txbMaDV.Text = dtgv.Rows[i].Cells[4].Value.ToString();
            txbTaiKhoan.Text = dtgv.Rows[i].Cells[5].Value.ToString();
            txbMatKhau.Text = dtgv.Rows[i].Cells[6].Value.ToString();
        }

        private void btnTimMaNV_Click(object sender, EventArgs e)
        {
            if(txbTimMaNV.Text == "")
            {
                loadData();
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "select * from NHANVIEN WHERE MANV = '" + txbTimMaNV.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dtgv.DataSource = table;
            }
        }

        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            if (txbTimTenNV.Text == "")
            {
                loadData();
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "select * from NHANVIEN WHERE TENNV = '" + txbTimTenNV.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dtgv.DataSource = table;
            }
        }

        private void btnTimTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txbTimTaiKhoan.Text == "")
            {
                loadData();
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "select * from NHANVIEN WHERE TAIKHOAN = '" + txbTimTaiKhoan.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dtgv.DataSource = table;
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i;
            i = dtgv.CurrentRow.Index;
            String maBoPhan = dtgv.Rows[i].Cells[3].Value.ToString();
            String maDV = dtgv.Rows[i].Cells[4].Value.ToString();
            command = connection.CreateCommand();
            if(maBoPhan != txbMaBoPhan.Text)
            {
                if (maDV != txbMaDV.Text)
                {
                    command.CommandText = "update NHANVIEN set TENNV = '" + txbTenNV.Text + "', CHUCVU = '" + txbChucVu.Text + "', MABP = '" + txbMaBoPhan.Text + "', MADV = '" + txbMaDV.Text + "', TAIKHOAN = '" + txbTaiKhoan.Text + "', MATKHAU = '" + txbMatKhau.Text + "' WHERE MANV = '" + txbMaNV.Text + "'";
                }
                else
                {
                    command.CommandText = "update NHANVIEN set TENNV = '" + txbTenNV.Text + "', CHUCVU = '" + txbChucVu.Text + "', MABP = '" + txbMaBoPhan.Text + "', TAIKHOAN = '" + txbTaiKhoan.Text + "', MATKHAU = '" + txbMatKhau.Text + "' WHERE MANV = '" + txbMaNV.Text + "'";
                }
            }
            else
            {
                if (maDV != txbMaDV.Text)
                {
                    command.CommandText = "update NHANVIEN set TENNV = '" + txbTenNV.Text + "', CHUCVU = '" + txbChucVu.Text + "', MADV = '" + txbMaDV.Text + "', TAIKHOAN = '" + txbTaiKhoan.Text + "', MATKHAU = '" + txbMatKhau.Text + "' WHERE MANV = '" + txbMaNV.Text + "'";
                }
                else
                {
                    command.CommandText = "update NHANVIEN set TENNV = '" + txbTenNV.Text + "', CHUCVU = '" + txbChucVu.Text + "', TAIKHOAN = '" + txbTaiKhoan.Text + "', MATKHAU = '" + txbMatKhau.Text + "' WHERE MANV = '" + txbMaNV.Text + "'";
                }
            }
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NHANVIEN where MANV = '" + txbMaNV.Text +"'";
            command.ExecuteNonQuery();
            loadTextBox();
            loadData();
        }
    }
} 
