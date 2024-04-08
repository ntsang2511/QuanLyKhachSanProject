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
    public partial class frmNhanVien : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=SANG-ADVICE\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MAPHONG, TENNV, MABP, CHUCVU, p.MADV from NHANVIEN as nv inner join PHONG as p on nv.MADV = p.MADV and TINHTRANGDICHVU = 0";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgv.DataSource = table;
        }
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.ReadOnly = true;
            int i;
            i = dtgv.CurrentRow.Index;
            txtMaPhong.Text = dtgv.Rows[i].Cells[0].Value.ToString();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update PHONG set TINHTRANGDICHVU = 1";
            command.ExecuteNonQuery();
            loadData();
            txtMaPhong.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from PHONG where MAPHONG = '" + txtMaPhong.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }
    }
}
