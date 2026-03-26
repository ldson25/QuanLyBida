using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BIDABLL;
using BIDADTO;

namespace QuanLyBida
{
    public partial class FrmImport : Form
    {
        DataTable dtImport;

        public FrmImport()
        {
            InitializeComponent();
            InitTableStruct();
            LoadFood();
        }

        void InitTableStruct()
        {
            dtImport = new DataTable();
            dtImport.Columns.Add("IdFood", typeof(int));
            dtImport.Columns.Add("Tên hàng hóa", typeof(string));
            dtImport.Columns.Add("ĐVT", typeof(string)); 
            dtImport.Columns.Add("Số lượng", typeof(int));
            dtImport.Columns.Add("Giá bán", typeof(decimal));
            dtImport.Columns.Add("Thành tiền", typeof(decimal));

            dtImport.Columns.Add("IdCategory", typeof(int));
            dtImport.Columns.Add("Images", typeof(string));

            dgvList.DataSource = dtImport;

            dgvList.Columns["Giá bán"].DefaultCellStyle.Format = "N0";
            dgvList.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";

            dgvList.Columns["IdFood"].Visible = false;
            dgvList.Columns["IdCategory"].Visible = false;
            dgvList.Columns["Images"].Visible = false;

            dgvList.Columns["Tên hàng hóa"].FillWeight = 200;
            dgvList.Columns["ĐVT"].FillWeight = 80;
        }

        void LoadFood()
        {
            cboFood.DataSource = FoodBLL.Instance.GetAllFood();
            cboFood.DisplayMember = "Name";
            cboFood.ValueMember = "IdFood";
            cboFood.SelectedIndex = -1; 
        }

        private void cboFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFood.SelectedIndex == -1) return;

            FoodDTO selected = cboFood.SelectedItem as FoodDTO;
            if (selected != null)
            {
                txtPrice.Text = selected.Price.ToString();

                if (!string.IsNullOrEmpty(selected.Unit))
                {
                    cboUnit.Text = selected.Unit;
                }
                else
                {
                    cboUnit.SelectedIndex = 0; 
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboFood.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hàng hóa!", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(cboUnit.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính!", "Thông báo");
                return;
            }

            FoodDTO selectedFood = cboFood.SelectedItem as FoodDTO;

            int idFood = selectedFood.IdFood;
            string name = selectedFood.Name;
            int sl = (int)numSL.Value;

            string unit = cboUnit.Text.Trim();

            int idCate = selectedFood.IdCategory;
            string img = selectedFood.Images;

            decimal price = 0;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Giá tiền không hợp lệ!"); return;
            }

            bool exists = false;
            foreach (DataRow row in dtImport.Rows)
            {
                if (Convert.ToInt32(row["IdFood"]) == idFood)
                {
                    row["Số lượng"] = Convert.ToInt32(row["Số lượng"]) + sl;
                    row["Thành tiền"] = Convert.ToInt32(row["Số lượng"]) * price;
                    row["Giá bán"] = price;
                    row["ĐVT"] = unit; 
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                dtImport.Rows.Add(idFood, name, unit, sl, price, sl * price, idCate, img);
            }

            UpdateTotal();
        }

        void UpdateTotal()
        {
            decimal totalBill = 0;
            foreach (DataRow row in dtImport.Rows) totalBill += Convert.ToDecimal(row["Thành tiền"]);
            lblTotal.Text = "TỔNG TIỀN: " + totalBill.ToString("N0") + " đ";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtImport.Rows.Count == 0) { MessageBox.Show("Danh sách trống!"); return; }

            if (MessageBox.Show("Xác nhận nhập kho?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                decimal totalBill = 0;
                foreach (DataRow row in dtImport.Rows) totalBill += Convert.ToDecimal(row["Thành tiền"]);

                string note = txtNote.Text == "" ? "Nhập kho " + DateTime.Now.ToString("dd/MM") : txtNote.Text;
                int idBill = ImportBLL.Instance.CreateImportBill(totalBill, note);

                if (idBill != -1)
                {
                    foreach (DataRow row in dtImport.Rows)
                    {
                        int idFood = Convert.ToInt32(row["IdFood"]); 

                        string foodName = row["Tên hàng hóa"].ToString();
                        int cateId = Convert.ToInt32(row["IdCategory"]);
                        decimal price = Convert.ToDecimal(row["Giá bán"]);
                        int qty = Convert.ToInt32(row["Số lượng"]);
                        string unit = row["ĐVT"].ToString();
                        string image = row["Images"].ToString();

                        FoodBLL.Instance.SmartImportFood(idBill, idFood, foodName, cateId, (double)price, qty, unit, image);
                    }

                    MessageBox.Show("Nhập kho thành công! Đã gộp số lượng chính xác.", "Thông báo");
                    dtImport.Clear();
                    UpdateTotal();
                    txtNote.Clear();
                }
            }
        }
    }
}