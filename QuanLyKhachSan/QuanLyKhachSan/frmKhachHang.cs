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
    public partial class frmKhachHang : Form
    {

        string conn = @"Data Source=THUAN;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        public frmKhachHang()
        {
            InitializeComponent();

            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from KHACHHANG", sqlConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlConnection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MAKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TENKH"].Value.ToString();
                txtCMND.Text = row.Cells["CMND"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GIOITINH"].Value.ToString();
                txtSDT.Text = row.Cells["DIENTHOAILIENHE"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                string insert = "Insert into KHACHHANG (MAKH, TENKH, CMND, GIOITINH, DIENTHOAILIENHE, DIACHI) values ('"
                    + txtMaKH.Text + "','" + txtTenKH.Text + "','" + txtCMND.Text + "','" + txtGioiTinh.Text + "','" + txtSDT.Text + "','" + txtDiaChi.Text + "')";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(insert, sqlConnection);
                sqlCommand.ExecuteNonQuery();


                SqlDataAdapter da = new SqlDataAdapter("select * from KHACHHANG", sqlConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                sqlConnection.Close();
            }
        }
    }
}
