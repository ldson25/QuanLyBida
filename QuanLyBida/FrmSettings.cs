using BIDABLL;
using BIDADTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBida
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();

            ShowPanel(pnlTableManager, btnTableManager);
            btnDeleteTable.Click += btnDeleteTable_Click;

            LoadTables();
            LoadPrices();
            LoadTableTypes();

            if (cboKhuVuc.Items.Count > 0)
            {
                cboKhuVuc.SelectedIndex = 0; 
            }
        }

        private void ShowPanel(Panel pnlToShow, Button activeBtn)
        {
            pnlTableManager.Visible = false;
            pnlPriceConfig.Visible = false;

            pnlToShow.Visible = true;
            pnlToShow.Dock = DockStyle.Fill;

            ResetButtonColor();
            activeBtn.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void ResetButtonColor()
        {
            btnTableManager.BackColor = Color.FromArgb(44, 62, 80);
            btnPriceConfig.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void btnTableManager_Click(object sender, EventArgs e)
        {
            pnlTableManager.Visible = true;
            pnlPriceConfig.Visible = false;
            pnlTableManager.Dock = DockStyle.Fill;

            ResetButtonColor();
            btnTableManager.BackColor = Color.FromArgb(52, 73, 94);

            LoadTables();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idTable = Convert.ToInt32(dgvTables.SelectedRows[0].Cells["IdTable"].Value);
            string tableName = dgvTables.SelectedRows[0].Cells["Name"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa '{tableName}' không?\nCảnh báo: Dữ liệu hóa đơn cũ của bàn này cũng sẽ bị xóa!",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int result = TableBLL.Instance.DeleteTable(idTable);

                if (result == 1)
                {
                    MessageBox.Show("Xóa bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTables();

                    if (FrmMain.Instance != null) FrmMain.Instance.LoadTables();
                }
                else
                {
                    MessageBox.Show("Không thể xóa bàn đang có người chơi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPriceConfig_Click(object sender, EventArgs e)
        {
            pnlPriceConfig.Visible = true;
            pnlTableManager.Visible = false;
            pnlPriceConfig.Dock = DockStyle.Fill;

            ResetButtonColor();
            btnPriceConfig.BackColor = Color.FromArgb(52, 73, 94);

            LoadPrices();
        }

        void LoadTables()
        {
            dgvTables.DataSource = TableBLL.Instance.GetAllTables();
            FormatGrid();
        }

        void FormatGrid()
        {
            if (dgvTables.Columns.Count == 0) return;

            if (dgvTables.Columns.Contains("IdTable"))
            {
                dgvTables.Columns["IdTable"].HeaderText = "Mã Bàn";
                dgvTables.Columns["IdTable"].Width = 80;
            }

            if (dgvTables.Columns.Contains("Name"))
            {
                dgvTables.Columns["Name"].HeaderText = "Tên Bàn";
                dgvTables.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgvTables.Columns.Contains("TypeName"))
                dgvTables.Columns["TypeName"].HeaderText = "Loại Bàn";

            if (dgvTables.Columns.Contains("Status"))
                dgvTables.Columns["Status"].HeaderText = "Trạng Thái";

            if (dgvTables.Columns.Contains("KhuVuc"))
                dgvTables.Columns["KhuVuc"].HeaderText = "Khu Vực";

            if (dgvTables.Columns.Contains("TypeId")) dgvTables.Columns["TypeId"].Visible = false;
            if (dgvTables.Columns.Contains("StartTime")) dgvTables.Columns["StartTime"].Visible = false;
            if (dgvTables.Columns.Contains("PlayTime")) dgvTables.Columns["PlayTime"].Visible = false;
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên bàn!", "Cảnh báo");
                return;
            }

            if (cboTableType.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại bàn!", "Cảnh báo");
                return;
            }
            int typeId = (int)cboTableType.SelectedValue;
            string khuVuc = "Tầng 1"; 
            if (cboKhuVuc.SelectedItem != null)
            {
                khuVuc = cboKhuVuc.SelectedItem.ToString();
            }

            if (TableBLL.Instance.AddTable(name, typeId, khuVuc))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo");
                LoadTables();
                if (FrmMain.Instance != null) FrmMain.Instance.LoadTables();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Có thể tên bàn bị trùng hoặc lỗi hệ thống.", "Lỗi");
            }
        }

        void LoadPrices()
        {
            txtPrice3Bi.Text = TableBLL.Instance.GetPricePerHour(1).ToString("N0");
            txtPriceLo.Text = TableBLL.Instance.GetPricePerHour(2).ToString("N0");
        }

        void LoadTableTypes()
        {
            cboTableType.DataSource = TableBLL.Instance.GetTableTypes();
            cboTableType.DisplayMember = "TYPENAME";
            cboTableType.ValueMember = "IDTYPE";
        }

        private void btnSavePrice_Click(object sender, EventArgs e)
        {
            decimal ParseCurrency(string input)
            {
                if (string.IsNullOrEmpty(input)) return 0;

                string cleanStr = input.Replace(",", "")
                                       .Replace(".", "")
                                       .Replace(" ", "")
                                       .Replace("đ", "")
                                       .Trim();

                if (decimal.TryParse(cleanStr, out decimal result))
                {
                    return result;
                }
                return 0;
            }

            try
            {
                decimal price3Bi = ParseCurrency(txtPrice3Bi.Text);
                decimal priceLo = ParseCurrency(txtPriceLo.Text);

                if (price3Bi <= 0 || priceLo <= 0)
                {
                    MessageBox.Show("Giá tiền phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TableBLL.Instance.UpdatePrice(1, price3Bi);
                TableBLL.Instance.UpdatePrice(2, priceLo);

                MessageBox.Show("Cập nhật giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrices();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống");
            }
        }
    }
}