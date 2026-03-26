using BIDADTO;
using BIDABLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBida
{
    public partial class UCTable : UserControl
    {
        public int TableId => _table.IdTable;
        private TableDTO _table;
        private Timer timerPlay;

        public TableDTO CurrentTable { get; set; }

        public event EventHandler OnTableUpdated;
        public event EventHandler<TableSwitchedEventArgs> TableSwitched;

        public UCTable(TableDTO table)
        {
            InitializeComponent();
            _table = table;
            this.CurrentTable = table;

            InitializeTimer();
            BindData();
        }

        private void InitializeTimer()
        {
            timerPlay = new Timer();
            timerPlay.Interval = 1000;
            timerPlay.Tick += TimerPlay_Tick;
        }

        // --- CẬP NHẬT DỮ LIỆU ---
        private void BindData()
        {
            lblTableName.Text = _table.Name.ToUpper();
            lblStatus.Text = _table.Status;
            lblTableType.Text = _table.TypeName;

            if (_table.Status == "Đang chơi" && _table.StartTime.HasValue)
            {
                DateTime startTime = _table.StartTime.Value;
                lblStartTime.Text = "Bắt đầu: " + startTime.ToString("HH:mm");
                TimeSpan playTime = DateTime.Now - startTime;
                lblTimePlay.Text = playTime.ToString(@"hh\:mm\:ss");
                timerPlay.Start();
            }
            else
            {
                timerPlay.Stop();
                lblStartTime.Text = "---";
                lblTimePlay.Text = "00:00:00";
            }

            UpdateUIState(); 
        }

        // ---  ĐỔI MÀU & ẨN HIỆN NÚT ---
        private void UpdateUIState()
        {
            btnStart.Visible = false;
            btnDatTruoc.Visible = false;
            btnOrder.Visible = false;
            btnChuyenBan.Visible = false;
            btnPay.Visible = false;
            btnHuyDat.Visible = false;

            switch (_table.Status)
            {
                case "Trống":
                    pnlHeader.BackColor = Color.FromArgb(52, 152, 219);
                    lblTimePlay.ForeColor = Color.DarkSlateGray;

                    btnStart.Visible = true;
                    btnStart.Text = "BẮT ĐẦU";
                    btnDatTruoc.Visible = true;
                    break;

                case "Đang chơi":
                    pnlHeader.BackColor = Color.FromArgb(231, 76, 60);
                    lblTimePlay.ForeColor = Color.Red;

                    btnOrder.Visible = true;
                    btnChuyenBan.Visible = true;
                    btnPay.Visible = true;
                    break;

                case "Đặt trước": 
                    pnlHeader.BackColor = Color.Goldenrod;
                    lblTimePlay.ForeColor = Color.Goldenrod;
                    lblTimePlay.Text = "ĐÃ ĐẶT";

                    btnStart.Visible = true;
                    btnStart.Text = "KHÁCH TỚI"; 
                    btnHuyDat.Visible = true;
                    break;

                default:
                    pnlHeader.BackColor = Color.Gray;
                    break;
            }
        }

        private void TimerPlay_Tick(object sender, EventArgs e)
        {
            if (_table.StartTime.HasValue)
            {
                TimeSpan playTime = DateTime.Now - _table.StartTime.Value;
                lblTimePlay.Text = playTime.ToString(@"hh\:mm\:ss");
            }
        }

        // --- CÁC SỰ KIỆN NÚT BẤM ---

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_table.Status == "Đang chơi") return;

            try
            {
                BillBLL.Instance.InsertBill(_table.IdTable);

                TableBLL.Instance.UpdateTableStatus(_table.IdTable, "Đang chơi");

                _table.Status = "Đang chơi";
                _table.StartTime = DateTime.Now;

                BindData();
                OnTableUpdated?.Invoke(this, EventArgs.Empty); // Báo FrmMain tải lại
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnDatTruoc_Click(object sender, EventArgs e)
        {
            if (_table.Status != "Trống") return;

            TableBLL.Instance.UpdateTableStatus(_table.IdTable, "Đặt trước");

            _table.Status = "Đặt trước";
            BindData();
        }

        private void btnHuyDat_Click(object sender, EventArgs e)
        {
            if (_table.Status != "Đặt trước") return;

            if (MessageBox.Show("Hủy đặt bàn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TableBLL.Instance.UpdateTableStatus(_table.IdTable, "Trống");

                _table.Status = "Trống";
                BindData();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_table.Status != "Đang chơi") return;

            timerPlay.Stop();
            DateTime startTime = _table.StartTime ?? DateTime.Now;

            FrmPay frm = new FrmPay(_table.IdTable, _table.Name, _table.TypeId, startTime);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _table.Status = "Trống";
                _table.StartTime = null;
                BindData();
                OnTableUpdated?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                timerPlay.Start();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (_table.Status != "Đang chơi")
            {
                MessageBox.Show("Vui lòng bấm 'Bắt đầu' trước khi gọi món!");
                return;
            }
            new FrmOrder(this.TableId).ShowDialog();
        }

        public void UpdateTableData(TableDTO newInfo)
        {
            this._table = newInfo;
            this.CurrentTable = newInfo;
            BindData();
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (_table.Status != "Đang chơi") return;

            FrmSwitchTable frm = new FrmSwitchTable(CurrentTable.IdTable, CurrentTable.Name);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                int idBanMoi = frm.NewTableId;
                DateTime originalStartTime = _table.StartTime ?? DateTime.Now;

                timerPlay.Stop();
                _table.Status = "Trống";
                _table.StartTime = null;
                BindData();

                TableSwitched?.Invoke(this, new TableSwitchedEventArgs
                {
                    OldTableId = CurrentTable.IdTable,
                    NewTableId = idBanMoi,
                    SessionStartTime = originalStartTime
                });
            }
        }

        public void StartTimerForSwitchedTable(DateTime originalStartTime)
        {
            _table.Status = "Đang chơi";
            _table.StartTime = originalStartTime;
            BindData();
        }
    }

    public class TableSwitchedEventArgs : EventArgs
    {
        public int OldTableId { get; set; }
        public int NewTableId { get; set; }
        public DateTime SessionStartTime { get; set; }
    }
}