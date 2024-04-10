using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCafe
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblMessage.Text = "Vui lòng nhập username!";
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblMessage.Text = "Vui lòng nhập password!";
            }
            else
            {
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                if (Login(user, pass))
                {
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                }
                else
                {
                    lblMessage.Text = "Username hoặc password không đúng.";
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtUsername.Focus();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
