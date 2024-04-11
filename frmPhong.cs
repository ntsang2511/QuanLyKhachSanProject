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
    public partial class frmPhong : Form
    {
        string conn = @"Data Source=THUAN;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        public frmPhong()
        {
            InitializeComponent();

            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MAPHONG, LOAIPHONG, GIAPHONG, SONGUOI, TINHTRANG from PHONG", sqlConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlConnection.Close();
            }

            cbbLoaiPhong.Items.Add("Thường");
            cbbLoaiPhong.Items.Add("VIP");
            cbbLoaiPhong.Items.Add("S-VIP");
        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbLoaiPhong.SelectedIndex == 0)
            {
                txtGiaPhong.Text = "500000";
            }
            else if(cbbLoaiPhong.SelectedIndex == 1)
            {
                txtGiaPhong.Text = "1500000";
            }
            else
            {
                txtGiaPhong.Text = "3500000";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                if (cbbCon.Checked && !cbbHet.Checked)
                {
                    string insert = "Insert into PHONG (MAPHONG, LOAIPHONG, GIAPHONG, SONGUOI, TINHTRANG) values ('"
                    + txtMaPhong.Text + "','" + cbbLoaiPhong.Text + "','" + txtGiaPhong.Text + "','" + nudSoNguoi.Text + "','" + cbbCon.Text + "')";

                    SqlCommand sqlCommand = new SqlCommand(insert, sqlConnection);
                    sqlCommand.ExecuteNonQuery();


                    SqlDataAdapter da = new SqlDataAdapter("select MAPHONG, LOAIPHONG, GIAPHONG, SONGUOI, TINHTRANG from PHONG", sqlConnection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Thêm phòng thành công!", "Thông báo");
                    sqlConnection.Close();
                }
                else if (!cbbCon.Checked && cbbHet.Checked)
                {
                    string insert = "Insert into PHONG (MAPHONG, LOAIPHONG, GIAPHONG, SONGUOI, TINHTRANG) values ('"
                    + txtMaPhong.Text + "','" + cbbLoaiPhong.Text + "','" + txtGiaPhong.Text + "','" + nudSoNguoi.Text + "','" + cbbHet.Text + "')";

                    SqlCommand sqlCommand = new SqlCommand(insert, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("select MAPHONG, LOAIPHONG, GIAPHONG, SONGUOI, TINHTRANG from PHONG", sqlConnection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dt.Rows.Add(txtMaPhong.Text, cbbLoaiPhong.Text, txtGiaPhong.Text, nudSoNguoi.Text, cbbHet.Text);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Thêm phòng thành công!", "Thông báo");
                    sqlConnection.Close();
                }
            }
        }   

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the unique identifier of the record from the selected row
                string id = selectedRow.Cells["MAPHONG"].Value.ToString(); // Replace "ID" with the actual name of the unique identifier column

                // Delete the record from the database
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    string deleteQuery = "delete from PHONG WHERE MAPHONG = @id"; // Replace "tableName" with the actual name of the table

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@id", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Deletion from the database was successful

                        // Remove the row from the DataGridView
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                    else
                    {
                        // Deletion from the database failed
                    }
                }
            }
        }
    }
}
