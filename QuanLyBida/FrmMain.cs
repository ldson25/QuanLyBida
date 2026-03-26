using BIDABLL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static QuanLyBida.UCTable;

namespace QuanLyBida
{
    public partial class FrmMain : Form
    {
        private static FrmMain _instance;
        public static FrmMain Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmMain();
                return _instance;
            }
        }

        private Account loginAccount;

        public FrmMain()
        {
            InitializeComponent();
            SetupLoiVao();
            LoadTables();
        }

        public FrmMain(Account acc)
        {
            InitializeComponent();
            loginAccount = acc;
            _instance = this;
            SetupLoiVao();

            LoadTables();
            PhanQuyen();
            HienThiThongTinTaiKhoan();
        }

        private void SetupLoiVao()
        {
            if (pnlLoiVaoContainer != null)
            {
                UC_LoiVao loiVao = new UC_LoiVao();
                loiVao.Margin = new Padding(10, 15, 0, 0);
                loiVao.Location = new Point(10, 15); 
                pnlLoiVaoContainer.Controls.Add(loiVao);

                loiVao.BringToFront();
            }
        }

        void HienThiThongTinTaiKhoan()
        {
            if (loginAccount != null)
            {
                string chucVu = (loginAccount.Type == 1) ? "Quản lý (Admin)" : "Nhân viên";
                lblLoginInfo.Text = $"Xin chào: {loginAccount.DisplayName} | Quyền: {chucVu}";
            }
        }

        void PhanQuyen()
        {
            if (loginAccount.Type == 1)
            {
                btnNhanVien.Visible = true;
                btnDoanhThu.Visible = true;
                btnDanhMuc.Visible = true;
                btnNhapKho.Visible = true;
                btnKiemKe.Visible = true;
                btnKhuyenMai.Visible = true;
            }
            else
            {
                btnNhanVien.Visible = false;
                btnDoanhThu.Visible = true;
                btnDanhMuc.Visible = false;
                btnNhapKho.Visible = false;
                btnKiemKe.Visible = true;
                btnKhuyenMai.Visible = false;
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (flpTables.Parent != null && flpTables.Parent.Parent is TabControl tabControl)
            {
                tabControl.Visible = true;
                tabControl.BringToFront();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (loginAccount.Type != 1)
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new FrmEmployee().ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (loginAccount.Type != 1)
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            new FrmFood().ShowDialog();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            new FrmRevenue().ShowDialog();
        }
        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            if (loginAccount.Type != 1)
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmPromotion frm = new FrmPromotion();
            frm.ShowDialog();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            if (loginAccount.Type != 1)
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmImport frm = new FrmImport();
            frm.ShowDialog();
        }

        private void btnKiemKe_Click(object sender, EventArgs e)
        {
            FrmKiemKe frm = new FrmKiemKe();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void LoadTables()
        {
            List<TableDTO> allTables = TableBLL.Instance.GetAllTables();

            List<TableDTO> listTang1 = new List<TableDTO>();
            List<TableDTO> listTang2 = new List<TableDTO>();

            foreach (var t in allTables)
            {
                if (t.KhuVuc == "Tầng 2")
                    listTang2.Add(t);
                else
                    listTang1.Add(t);
            }

            UpdatePanel(flpTables, listTang1);
            UpdatePanel(flpTang2, listTang2);
        }
        private void UpdatePanel(FlowLayoutPanel flp, List<TableDTO> tableList)
        {
            if (flp == null) return;

            foreach (TableDTO t in tableList)
            {
                UCTable banDangHienThi = null;

                foreach (Control c in flp.Controls)
                {
                    if (c is UCTable uc && uc.TableId == t.IdTable)
                    {
                        banDangHienThi = uc;
                        break;
                    }
                }

                if (banDangHienThi != null)
                {
                    banDangHienThi.UpdateTableData(t);
                }
                else
                {
                    UCTable banMoi = new UCTable(t);
                    banMoi.OnTableUpdated += (s, e) => { LoadTables(); };
                    banMoi.TableSwitched += Uc_TableSwitched;
                    banMoi.Margin = new Padding(10);
                    flp.Controls.Add(banMoi);
                }
            }

            for (int i = flp.Controls.Count - 1; i >= 0; i--)
            {
                if (flp.Controls[i] is UCTable uc)
                {
                    bool conTonTai = false;
                    foreach (var item in tableList)
                    {
                        if (item.IdTable == uc.TableId)
                        {
                            conTonTai = true;
                            break;
                        }
                    }

                    if (!conTonTai)
                    {
                        flp.Controls.Remove(uc);
                        uc.Dispose();
                    }
                }
            }
        }

        private void Uc_TableSwitched(object sender, TableSwitchedEventArgs e)
        {
            if (!TimVaKichHoatBan(flpTables, e))
            {
                TimVaKichHoatBan(flpTang2, e);
            }
        }

        private bool TimVaKichHoatBan(FlowLayoutPanel flp, TableSwitchedEventArgs e)
        {
            if (flp == null) return false;

            foreach (Control control in flp.Controls)
            {
                if (control is UCTable ucMoi && ucMoi.TableId == e.NewTableId)
                {
                    ucMoi.StartTimerForSwitchedTable(e.SessionStartTime);
                    return true;
                }
            }
            return false;
        }
    }
}