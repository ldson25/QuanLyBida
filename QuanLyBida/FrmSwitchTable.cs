using BIDABLL;
using BIDADAL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBida
{
    public partial class FrmSwitchTable : Form
    {

        private int _idBanCu;
        public int NewTableId { get; private set; }

        public FrmSwitchTable()
        {
            InitializeComponent();
        }
        public FrmSwitchTable(int idBan, string tenBan)
        {
            InitializeComponent();
            _idBanCu = idBan;

            lblBanCu.Text = "Chuyển từ: " + tenBan;
            LoadTables();
        }

        public void LoadTables()
        {
            
            List<TableDTO> listTatCaBan = TableBLL.Instance.GetAllTables();

         
            List<TableDTO> listBanChoChuyen = listTatCaBan
                .Where(t => t.IdTable != this._idBanCu) 
                .Where(t => t.Status == "Trống")        
                .ToList();

            cbBanMoi.DataSource = listBanChoChuyen;
            cbBanMoi.DisplayMember = "Name";
            cbBanMoi.ValueMember = "IdTable";

            if (listBanChoChuyen.Count > 0)
            {
                cbBanMoi.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không có bàn trống phù hợp để chuyển đến.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FrmSwitchTable_Load(object sender, EventArgs e)
        {
 
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbBanMoi.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn muốn chuyển đến.", "Lỗi chọn bàn");
                return;
            }

            int idBanMoi = (int)cbBanMoi.SelectedValue;

            if (_idBanCu == idBanMoi)
            {
                MessageBox.Show("Vui lòng chọn bàn khác bàn hiện tại!");
                return;
            }


            if (MessageBox.Show("Bạn chắc chắn muốn chuyển bàn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    TableBLL.Instance.SwitchTable(_idBanCu, idBanMoi);
                    this.NewTableId = idBanMoi;
                    MessageBox.Show("Chuyển bàn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}