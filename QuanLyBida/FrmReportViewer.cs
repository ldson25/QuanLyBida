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
using CrystalDecisions.CrystalReports.Engine;
namespace QuanLyBida
{
    public partial class FrmReportViewer : Form
    {
        private int _billId;
        public FrmReportViewer(int billId)
        {
            InitializeComponent();
            _billId = billId;
            this.Text = "Hóa đơn Thanh toán #" + billId;
            LoadReport();
        }
        public FrmReportViewer(ReportDocument rpt)
        {
            InitializeComponent();
            this.Text = "Xem Báo Cáo";
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void LoadReport()
        {
            try
            {
                DataTable dtReport = BillBLL.Instance.GetReceiptData(_billId);

                RptHoaDon rpt = new RptHoaDon();
                rpt.SetDataSource(dtReport);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo: " + ex.Message, "Lỗi Crystal Reports");
            }
        }
    }
}
