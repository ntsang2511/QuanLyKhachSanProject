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
    public partial class frmThuePhong : Form
    {
        string conn = @"Data Source=THUAN;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        public frmThuePhong()
        {
            InitializeComponent();
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                string query = "select MAKH from KHACHHANG";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    cbbMaKH.Items.Add(dr["MAKH"].ToString());
                }
                dr.Close();
            }

            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                string query = "select MAPHONG from PHONG";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    cbbMaPhong.Items.Add(dr["MAPHONG"].ToString());
                }
                dr.Close();
            }
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();

                SqlDataAdapter da = new SqlDataAdapter("select MADP, MAKH, MAPHONG, NGAYDEN, NGAYTRA, SONGUOI from DATPHONG", sqlConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                string insert = "insert into DATPHONG (MADP, MAKH, MAPHONG, NGAYDEN, NGAYTRA, SONGUOI) values ('"
                    + txtMaDatPhong.Text + "','" + cbbMaKH.Text + "','" + cbbMaPhong.Text + "','" + dtpCheckin.Text
                    + "','" + dtpCheckout.Text + "','" + nudSoNguoi.Value + "')";
                SqlCommand sqlCommand = new SqlCommand(insert, sqlConnection);
                sqlCommand.ExecuteNonQuery();


                SqlDataAdapter da = new SqlDataAdapter("select MADP, MAKH, MAPHONG, NGAYDEN, NGAYTRA, SONGUOI from DATPHONG", sqlConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                string update = "update PHONG set TINHTRANG = @tinhtrang where MAPHONG = @phong";
                sqlCommand = new SqlCommand(update, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@tinhtrang", "Het");
                sqlCommand.Parameters.AddWithValue("@phong", cbbMaPhong.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thuê phòng thành công!", "Thông báo");
                sqlConnection.Close();
            }
        }
    }
}
