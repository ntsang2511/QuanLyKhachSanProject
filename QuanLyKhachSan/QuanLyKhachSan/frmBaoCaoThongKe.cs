using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyKhachSan
{
    public partial class frmBaoCaoThongKe : Form
    {
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadReport(DateTime.Parse(dtDate.Text));
        }

        private void LoadReport(DateTime date)
        {
            DataTable table = new DataTable();
            if (rbNgay.Checked)
            {
                table = GetReportDay(date);
            }
            else if (rbThang.Checked)
            {
                table = GetReportMonth(date);
            }
            else
            {
                table = GetReportYear(date);
            }
            BindingSource source = new BindingSource();
            CalcRate(table);
            source.DataSource = table;
            dataGridReport.DataSource = source;
            bindingReport.BindingSource = source;
            DrawChart(source);
        }

        #region Data
        private DataTable GetReportDay(DateTime date)
        {
            return BaoCaoThongKeDAO.Instance.LoadReportDay(date);
        }

        private DataTable GetReportMonth(DateTime date)
        {
            return BaoCaoThongKeDAO.Instance.LoadReportMonth(date);
        }

        private DataTable GetReportYear(DateTime date)
        {
            return BaoCaoThongKeDAO.Instance.LoadReportYear(date);
        }
        #endregion

        private void DrawChart(BindingSource source)
        {
            chartReport.DataSource = source;
            chartReport.DataBind();
        }

        private void CalcRate(DataTable table)
        {
            double sum = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                double node = ((double)table.Rows[i]["value"]);
                sum += node;
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["rate"] = (((double)table.Rows[i]["value"]) / sum * 100).ToString("#0.##");
            }
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            dtDate.Text = DateTime.Now.ToString();
            rbNgay.Checked = true;
            LoadReport(DateTime.Now);
        }

        private void tslXuat_Click(object sender, EventArgs e)
        {
            if (dataGridReport.Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String sFilename = "Doanh thu ";
            
            if (rbNgay.Checked)
            {
                saveReport.FileName = sFilename + "ngày " + DateTime.Parse(dtDate.Text).Day + '-' + DateTime.Parse(dtDate.Text).Month + '-' + DateTime.Parse(dtDate.Text).Year;
            }
            else if (rbThang.Checked)
            {
                saveReport.FileName = sFilename + "tháng " + DateTime.Parse(dtDate.Text).Month + '-' + DateTime.Parse(dtDate.Text).Year;
            }
            else
            {
                saveReport.FileName = sFilename + "năm " + DateTime.Parse(dtDate.Text).Year;
            }
                
            if (saveReport.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                bool check;
                try
                {
                    switch (saveReport.FilterIndex)
                    {
                        case 2:
                            check = ExportToExcel.Instance.Export(dataGridReport, saveReport.FileName, ModeExportToExcel.XLSX);
                            break;
                        case 3:
                            check = ExportToExcel.Instance.Export(dataGridReport, saveReport.FileName, ModeExportToExcel.PDF);
                            break;
                        default:
                            check = ExportToExcel.Instance.Export(dataGridReport, saveReport.FileName, ModeExportToExcel.XLS);
                            break;
                    }
                    if (check)
                        MessageBox.Show("Xuất thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi xuất thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Lỗi (Cần cài đặt Office)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
