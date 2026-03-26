using BIDABLL;
using BIDADAL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBida
{
    public partial class FrmFood : Form
    {
        private bool isAdd = false;

        public FrmFood()
        {
            InitializeComponent();
            LoadCategory();
            LoadFood();
            LockTextbox();
        }

        private void LoadCategory()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM FOODCATEGORY");

            cboCategory.DataSource = data;
            cboCategory.DisplayMember = "NAME";
            cboCategory.ValueMember = "IDCATEGORY";
        }

        private void LoadFood()
        {
            dgvFood.DataSource = FoodDAL.Instance.GetAllFood();

            if (dgvFood.Columns["IdFood"] != null) dgvFood.Columns["IdFood"].HeaderText = "Mã Số";
            if (dgvFood.Columns["Name"] != null) dgvFood.Columns["Name"].HeaderText = "Tên Món Ăn";
            if (dgvFood.Columns["IdCategory"] != null) dgvFood.Columns["IdCategory"].HeaderText = "Mã Loại";
            if (dgvFood.Columns["Price"] != null) dgvFood.Columns["Price"].HeaderText = "Giá Bán";
            if (dgvFood.Columns["Images"] != null) dgvFood.Columns["Images"].HeaderText = "Hình Ảnh";

            if (dgvFood.Columns["Inventory"] != null) dgvFood.Columns["Inventory"].Visible = false;
            if (dgvFood.Columns["Unit"] != null) dgvFood.Columns["Unit"].Visible = false;
            if (dgvFood.Columns["CategoryName"] != null) dgvFood.Columns["CategoryName"].HeaderText = "Danh Mục";
            if (dgvFood.Columns["TypeName"] != null) dgvFood.Columns["TypeName"].Visible = false; 

            if (dgvFood.Columns["Price"] != null)
            {
                dgvFood.Columns["Price"].DefaultCellStyle.Format = "N0";
                dgvFood.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvFood.Columns["Inventory"] != null) dgvFood.Columns["Inventory"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgvFood.Columns["Unit"] != null) dgvFood.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            if (dgvFood.Columns["Name"] != null) dgvFood.Columns["Name"].FillWeight = 150; 

            dgvFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFood.MultiSelect = false;
            dgvFood.ReadOnly = true;
        }

        private void LockTextbox()
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtImage.Enabled = false;
            cboCategory.Enabled = false;

            btnLuu.Enabled = false;
        }

        private void UnlockTextbox()
        {
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtImage.Enabled = true;
            cboCategory.Enabled = true;

            btnLuu.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            UnlockTextbox();
            txtName.Clear();
            txtPrice.Clear();
            txtImage.Clear();
            txtName.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món cần sửa!");
                return;
            }
            this.dgvFood.SelectionChanged -= new System.EventHandler(this.dgvFood_SelectionChanged);

            isAdd = false;

            UnlockTextbox();
            txtName.Text = dgvFood.SelectedRows[0].Cells["Name"].Value.ToString();
            txtPrice.Text = dgvFood.SelectedRows[0].Cells["Price"].Value.ToString();
            txtImage.Text = dgvFood.SelectedRows[0].Cells["Images"].Value.ToString();
            cboCategory.SelectedValue = dgvFood.SelectedRows[0].Cells["IdCategory"].Value;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idFoodToDelete;

            object idValue = dgvFood.SelectedRows[0].Cells["IdFood"].Value;

            if (idValue == null || !int.TryParse(idValue.ToString(), out idFoodToDelete))
            {
                MessageBox.Show("Không thể lấy được ID món ăn. Vui lòng kiểm tra lại cấu trúc bảng.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (FoodBLL.Instance.DeleteFood(idFoodToDelete))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadFood();
                }
                else
                {
                    MessageBox.Show("Không thể xóa! Món ăn này có thể đang được sử dụng trong hóa đơn.", "Lỗi xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float price = 0;

            string cleanPriceText = txtPrice.Text.Replace(",", "").Replace(".", ""); 

            if (!float.TryParse(cleanPriceText,
                                System.Globalization.NumberStyles.Currency | System.Globalization.NumberStyles.Float,
                                System.Globalization.CultureInfo.InvariantCulture,
                                out price))
            {
                MessageBox.Show("Giá tiền không hợp lệ. Vui lòng kiểm tra lại định dạng số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (cboCategory.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FoodDTO food = new FoodDTO()
            {
                Name = txtName.Text,
                Price = price, 
                Images = txtImage.Text,
                IdCategory = Convert.ToInt32(cboCategory.SelectedValue)
            };

            if (isAdd)
            {
                if (FoodBLL.Instance.InsertFood(food))
                    MessageBox.Show("Thêm thành công!");
            }
            else 
            {
                if (dgvFood.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn món ăn cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvFood.SelectedRows[0].Cells["IdFood"].Value is int idFood)
                {
                    food.IdFood = idFood;
                }
                else
                {
                    food.IdFood = Convert.ToInt32(dgvFood.SelectedRows[0].Cells["IdFood"].Value);
                }

                if (FoodBLL.Instance.UpdateFood(food))
                    MessageBox.Show("Cập nhật thành công!");

            }

            LoadFood();
            LockTextbox();
            this.dgvFood.SelectionChanged += new System.EventHandler(this.dgvFood_SelectionChanged);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadFood();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = ofd.FileName;
                picFood.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void dgvFood_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0) return;

            txtName.Text = dgvFood.SelectedRows[0].Cells["Name"].Value.ToString();
            txtPrice.Text = dgvFood.SelectedRows[0].Cells["Price"].Value.ToString();
            txtImage.Text = dgvFood.SelectedRows[0].Cells["Images"].Value.ToString();
            cboCategory.SelectedValue = dgvFood.SelectedRows[0].Cells["IdCategory"].Value;
        }
    }
}
