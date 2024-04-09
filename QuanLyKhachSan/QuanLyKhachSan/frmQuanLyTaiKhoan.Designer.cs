namespace QuanLyKhachSan
{
    partial class frmQuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbMaBoPhan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMaDV = new System.Windows.Forms.TextBox();
            this.txbChucVu = new System.Windows.Forms.TextBox();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTimMaNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbTimTenNV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbTimTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnTimMaNV = new System.Windows.Forms.Button();
            this.btnTimTheoTen = new System.Windows.Forms.Button();
            this.btnTimTaiKhoan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(85, 89);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(915, 239);
            this.dtgv.TabIndex = 1;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chức vụ";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(776, 346);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(224, 22);
            this.txbTaiKhoan.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mật khẩu";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(776, 395);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(224, 22);
            this.txbMatKhau.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã bộ phận";
            // 
            // txbMaBoPhan
            // 
            this.txbMaBoPhan.Location = new System.Drawing.Point(776, 446);
            this.txbMaBoPhan.Name = "txbMaBoPhan";
            this.txbMaBoPhan.Size = new System.Drawing.Size(224, 22);
            this.txbMaBoPhan.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(653, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã dịch vụ";
            // 
            // txbMaDV
            // 
            this.txbMaDV.Location = new System.Drawing.Point(776, 499);
            this.txbMaDV.Name = "txbMaDV";
            this.txbMaDV.Size = new System.Drawing.Size(224, 22);
            this.txbMaDV.TabIndex = 15;
            // 
            // txbChucVu
            // 
            this.txbChucVu.Location = new System.Drawing.Point(209, 479);
            this.txbChucVu.Name = "txbChucVu";
            this.txbChucVu.Size = new System.Drawing.Size(169, 22);
            this.txbChucVu.TabIndex = 16;
            // 
            // txbTenNV
            // 
            this.txbTenNV.Location = new System.Drawing.Point(209, 419);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(169, 22);
            this.txbTenNV.TabIndex = 17;
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(209, 358);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(169, 22);
            this.txbMaNV.TabIndex = 18;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(906, 564);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(94, 83);
            this.btnDangKy.TabIndex = 19;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tìm kiếm tài khoản";
            // 
            // txbTimMaNV
            // 
            this.txbTimMaNV.Location = new System.Drawing.Point(209, 565);
            this.txbTimMaNV.Name = "txbTimMaNV";
            this.txbTimMaNV.Size = new System.Drawing.Size(182, 22);
            this.txbTimMaNV.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 565);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tìm theo mã nhân viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 606);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tìm theo tên";
            // 
            // txbTimTenNV
            // 
            this.txbTimTenNV.Location = new System.Drawing.Point(209, 600);
            this.txbTimTenNV.Name = "txbTimTenNV";
            this.txbTimTenNV.Size = new System.Drawing.Size(182, 22);
            this.txbTimTenNV.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 642);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tìm theo tài khoản";
            // 
            // txbTimTaiKhoan
            // 
            this.txbTimTaiKhoan.Location = new System.Drawing.Point(209, 639);
            this.txbTimTaiKhoan.Name = "txbTimTaiKhoan";
            this.txbTimTaiKhoan.Size = new System.Drawing.Size(182, 22);
            this.txbTimTaiKhoan.TabIndex = 25;
            // 
            // btnTimMaNV
            // 
            this.btnTimMaNV.Location = new System.Drawing.Point(397, 564);
            this.btnTimMaNV.Name = "btnTimMaNV";
            this.btnTimMaNV.Size = new System.Drawing.Size(131, 23);
            this.btnTimMaNV.TabIndex = 27;
            this.btnTimMaNV.Text = "Tìm";
            this.btnTimMaNV.UseVisualStyleBackColor = true;
            this.btnTimMaNV.Click += new System.EventHandler(this.btnTimMaNV_Click);
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Location = new System.Drawing.Point(397, 599);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(131, 23);
            this.btnTimTheoTen.TabIndex = 28;
            this.btnTimTheoTen.Text = "Tìm";
            this.btnTimTheoTen.UseVisualStyleBackColor = true;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // btnTimTaiKhoan
            // 
            this.btnTimTaiKhoan.Location = new System.Drawing.Point(397, 638);
            this.btnTimTaiKhoan.Name = "btnTimTaiKhoan";
            this.btnTimTaiKhoan.Size = new System.Drawing.Size(131, 23);
            this.btnTimTaiKhoan.TabIndex = 29;
            this.btnTimTaiKhoan.Text = "Tìm";
            this.btnTimTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTimTaiKhoan.Click += new System.EventHandler(this.btnTimTaiKhoan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(656, 564);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 83);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(785, 564);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 83);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 680);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimTaiKhoan);
            this.Controls.Add(this.btnTimTheoTen);
            this.Controls.Add(this.btnTimMaNV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbTimTaiKhoan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbTimTenNV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbTimMaNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.txbTenNV);
            this.Controls.Add(this.txbChucVu);
            this.Controls.Add(this.txbMaDV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbMaBoPhan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "frmQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.txbChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbMaBoPhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbMaDV;
        private System.Windows.Forms.TextBox txbChucVu;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTimMaNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbTimTenNV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbTimTaiKhoan;
        private System.Windows.Forms.Button btnTimMaNV;
        private System.Windows.Forms.Button btnTimTheoTen;
        private System.Windows.Forms.Button btnTimTaiKhoan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}