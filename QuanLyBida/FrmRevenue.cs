using BIDABLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyBida
{
    public partial class FrmRevenue : Form
    {
        public FrmRevenue()
        {
            InitializeComponent();
            LoadDateTimePickerBill();

            DecorateChart();

            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadChartRevenue();
        }

        void DecorateChart()
        {
            chartRevenue.Titles[0].Text = "BIỂU ĐỒ DOANH THU";
            chartRevenue.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartRevenue.Titles[0].ForeColor = Color.DimGray;

            ChartArea ca = chartRevenue.ChartAreas[0];
            ca.BackColor = Color.White;
            ca.AxisX.MajorGrid.Enabled = false;
            ca.AxisY.MajorGrid.LineColor = Color.LightGray;
            ca.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            ca.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            ca.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

            Series series = chartRevenue.Series[0];
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(65, 140, 240);
            series.BorderWidth = 0;
            series["PointWidth"] = "0.7";
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            DataTable dt = BillBLL.Instance.GetBillListByDate(checkIn, checkOut);
            dtgvBill.DataSource = dt;
            FormatGrid();

            CalculateTotalRevenue(dt);
        }
        void FormatGrid()
        {
            if (dtgvBill.Columns.Count == 0) return;
            string currencyFormat = "#,##0 VNĐ";

            if (dtgvBill.Columns.Contains("Tổng tiền"))
            {
                dtgvBill.Columns["Tổng tiền"].DefaultCellStyle.Format = currencyFormat;
                dtgvBill.Columns["Tổng tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dtgvBill.Columns.Contains("Tiền giờ"))
            {
                dtgvBill.Columns["Tiền giờ"].DefaultCellStyle.Format = currencyFormat;
                dtgvBill.Columns["Tiền giờ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dtgvBill.Columns.Contains("Tiền món"))
            {
                dtgvBill.Columns["Tiền món"].DefaultCellStyle.Format = currencyFormat;
                dtgvBill.Columns["Tiền món"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dtgvBill.Columns.Contains("Giảm giá"))
            {
                dtgvBill.Columns["Giảm giá"].DefaultCellStyle.Format = currencyFormat;
                dtgvBill.Columns["Giảm giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        void LoadChartRevenue()
        {
            int year = dtpkFromDate.Value.Year;
            DataTable dt = BillBLL.Instance.GetMonthlyRevenue(year);

            chartRevenue.Series[0].Points.Clear();
            chartRevenue.Titles[0].Text = $"BIỂU ĐỒ DOANH THU NĂM {year}";

            for (int t = 1; t <= 12; t++)
            {
                decimal tongTien = 0;
                DataRow[] foundRows = dt.Select("Thang = " + t);
                if (foundRows.Length > 0 && foundRows[0]["TongTien"] != DBNull.Value)
                {
                    tongTien = Convert.ToDecimal(foundRows[0]["TongTien"]);
                }

                DataPoint point = new DataPoint();
                point.SetValueXY($"T{t}", tongTien);
                point.ToolTip = $"Tháng {t}: {tongTien:N0} VNĐ";

                if (tongTien > 0)
                {
                    point.Label = (tongTien / 1000000).ToString("0.##") + " Tr";
                }
                chartRevenue.Series[0].Points.Add(point);
            }
        }

        void CalculateTotalRevenue(DataTable dt)
        {
            decimal totalRevenue = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["Tổng tiền"] != DBNull.Value && row["Tổng tiền"].ToString() != "")
                {
                    totalRevenue += Convert.ToDecimal(row["Tổng tiền"]);
                }
            }
            lblTotalRevenue.Text = totalRevenue.ToString("N0") + " VNĐ";

            int totalBills = dt.Rows.Count;
            if (this.Controls.Find("lblTotalBillCount", true).Length > 0)
                this.Controls.Find("lblTotalBillCount", true)[0].Text = totalBills.ToString();
            else
                lblTotalBillCount.Text = totalBills.ToString();

            decimal average = 0;
            if (totalBills > 0)
            {
                average = totalRevenue / totalBills;
            }

            if (this.Controls.Find("lblAverageRevenue", true).Length > 0)
                this.Controls.Find("lblAverageRevenue", true)[0].Text = average.ToString("N0") + " VNĐ";
            else
                lblAverageRevenue.Text = average.ToString("N0") + " VNĐ";
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadChartRevenue();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dtpkFromDate.Value;
            DateTime checkOut = dtpkToDate.Value;

            DataTable dt = BillBLL.Instance.GetBillListByDate(checkIn, checkOut);

            if (dt.Rows.Count > 0)
            {
                RptDoanhThu rpt = new RptDoanhThu();
                rpt.SetDataSource(dt);
                FrmReportViewer f = new FrmReportViewer(rpt);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để in!", "Thông báo");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dtgvBill.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            sfd.FileName = "BaoCaoDoanhThu_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dtgvBill, sfd.FileName);
            }
        }

        private void ToExcel(DataGridView dgv, string fileName)
        {
            Excel.Application excelApp = new Excel.Application();
            try
            {
                excelApp.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = null;
                worksheet = excelApp.ActiveSheet;
                worksheet.Name = "Báo Cáo Doanh Thu";

                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    Excel.Range cell = worksheet.Cells[1, i];
                    cell.Font.Bold = true;
                    cell.Interior.Color = Color.LightGray;
                    cell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                worksheet.Columns.AutoFit();
                excelApp.ActiveWorkbook.SaveCopyAs(fileName);
                excelApp.ActiveWorkbook.Saved = true;

                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                excelApp.Quit();
            }
            finally
            {
                ReleaseObject(excelApp);
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Lỗi giải phóng bộ nhớ: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}