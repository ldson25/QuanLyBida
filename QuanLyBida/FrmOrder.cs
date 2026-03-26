using BIDABLL;
using BIDADAL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBida
{
    public partial class FrmOrder : Form
    {
        private int _tableId;
        private int _billId;

        public FrmOrder(int tableId)
        {
            InitializeComponent();

            _tableId = tableId;
            _billId = BillInfoDAL.Instance.GetOpenBillId(tableId);

            if (_billId == -1)
            {
                BillDAL.Instance.InsertBill(tableId);
                _billId = BillInfoDAL.Instance.GetOpenBillId(tableId);
            }

            dgvBill.AutoGenerateColumns = false;
            dgvBill.AllowUserToAddRows = false;
            dgvBill.ReadOnly = false; // không khóa toàn bộ grid
            dgvBill.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvBill.EditMode = DataGridViewEditMode.EditOnEnter;

            dgvBill.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvBill.IsCurrentCellDirty)
                    dgvBill.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            dgvBill.CellValueChanged += dgvBill_CellValueChanged;

            dgvBill.CellEnter += (s, e) =>
            {
                if (e.RowIndex >= 0 && dgvBill.Columns[e.ColumnIndex].Name == "COUNT")
                    dgvBill.BeginEdit(true);
            };

            LoadFoodList();
            LoadBillDetails();
            LoadCategory();
        }

        private void LoadCategory()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM FOODCATEGORY");

            DataRow newRow = data.NewRow();
            newRow["IDCATEGORY"] = 0;
            newRow["NAME"] = "Tất cả";
            data.Rows.InsertAt(newRow, 0);

            cboCategory.DataSource = data;
            cboCategory.DisplayMember = "NAME";
            cboCategory.ValueMember = "IDCATEGORY";
        }

        private void LoadFoodList(string search = "", int categoryId = 0)
        {
            flowFoods.Controls.Clear();

            List<FoodDTO> foods = FoodDAL.Instance.GetAllFood();

            if (categoryId != 0)
                foods = foods.Where(x => x.IdCategory == categoryId).ToList();

            if (!string.IsNullOrEmpty(search))
                foods = foods.Where(x => x.Name.ToLower().Contains(search.ToLower())).ToList();

            foreach (FoodDTO food in foods)
            {
                UC_FoodItem item = new UC_FoodItem(food);
                item.OnAddFood += (s, e) => AddFoodToBill(food.IdFood);
                flowFoods.Controls.Add(item);
            }
        }

        private void AddFoodToBill(int foodId)
        {
            int currentStock = FoodBLL.Instance.GetInventoryByFoodId(foodId);

            if (currentStock <= 0)
            {
                MessageBox.Show("Món này đã hết hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int daDatTrongBill = 0;

            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (Convert.ToInt32(row.Cells["IDFOOD"].Value) == foodId)
                {
                    daDatTrongBill = Convert.ToInt32(row.Cells["COUNT"].Value);
                    break;
                }
            }

            if (daDatTrongBill + 1 > currentStock)
            {
                MessageBox.Show($"Bạn đã đặt hết số lượng trong kho ({currentStock})!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            BillInfoDAL.Instance.AddBillInfo(_billId, foodId, 1);
            LoadBillDetails();
        }

        private void LoadBillDetails()
        {
            var dt = BillInfoDAL.Instance.GetBillDetails(_tableId);

            dgvBill.Columns.Clear();
            dgvBill.AutoGenerateColumns = false;

            dgvBill.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NAME",
                HeaderText = "NAME",
                ReadOnly = true,
                Name = "NAME"
            });

            var colQty = new DataGridViewNumericUpDownColumn
            {
                DataPropertyName = "COUNT",
                HeaderText = "COUNT",
                Name = "COUNT",
                ReadOnly = false
            };
            dgvBill.Columns.Add(colQty);

            var colPrice = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PRICE",
                HeaderText = "PRICE",
                ReadOnly = true,
                Name = "PRICE",
                DefaultCellStyle = { Format = "N0" }
            };
            dgvBill.Columns.Add(colPrice);

            var colTotal = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TOTALPRICE",
                HeaderText = "TOTALPRICE",
                ReadOnly = true,
                Name = "TOTALPRICE",
                DefaultCellStyle = { Format = "N0" }
            };
            dgvBill.Columns.Add(colTotal);

            dgvBill.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IDFOOD",
                Name = "IDFOOD",
                Visible = false,
                ReadOnly = true
            });

            dgvBill.DataSource = dt;
        }

        private void dgvBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               if (e.RowIndex < 0) return;
                if (dgvBill.Columns[e.ColumnIndex].Name != "COUNT") return;

                var row = dgvBill.Rows[e.RowIndex];

                int newQty = 1;
                if (row.Cells["COUNT"].Value != null && row.Cells["COUNT"].Value != DBNull.Value)
                {
                    int.TryParse(row.Cells["COUNT"].Value.ToString(), out newQty);
                }

                int idFood = Convert.ToInt32(((DataRowView)row.DataBoundItem)["IDFOOD"]);

                int currentStock = FoodBLL.Instance.GetInventoryByFoodId(idFood);

                if (newQty > currentStock)
                {
                    MessageBox.Show($"Kho chỉ còn {currentStock} đơn vị. Không đủ hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    newQty = currentStock; 

                    dgvBill.CellValueChanged -= dgvBill_CellValueChanged;
                    row.Cells["COUNT"].Value = newQty;
                    dgvBill.CellValueChanged += dgvBill_CellValueChanged;
                }

                if (newQty < 1) newQty = 1;
                BillInfoDAL.Instance.UpdateBillInfoCount(_billId, idFood, newQty);

                LoadBillDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex == -1) return;

            if (cb.SelectedValue is int categoryId)
            {
                LoadFoodList(txtSearch.Text, categoryId);
            }
            else if (cb.SelectedValue != null)
            {
                try
                {
                    int id = Convert.ToInt32(cb.SelectedValue);
                    LoadFoodList(txtSearch.Text, id);
                }
                catch { }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int catId = cboCategory.SelectedIndex > 0 ? (int)cboCategory.SelectedValue : 0;
            LoadFoodList(txtSearch.Text, catId);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int catId = cboCategory.SelectedIndex > 0 ? (int)cboCategory.SelectedValue : 0;
            LoadFoodList(txtSearch.Text, catId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
