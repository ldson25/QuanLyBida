using BIDABLL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBida
{
    public partial class FrmPromotion : Form
    {
        BindingSource promoList = new BindingSource();

        public FrmPromotion()
        {
            InitializeComponent();
            LoadDataFirstTime();

        }

        void LoadDataFirstTime()
        {
            dgvPromo.DataSource = promoList;
            LoadPromoList();
            LoadFoodToCombobox();
            LoadTypeToCombobox();

            if (dgvPromo.Columns["Id"] != null)
            {
                dgvPromo.Columns["Id"].HeaderText = "Mã KM";
                dgvPromo.Columns["Id"].Width = 60; 
            }
            if (dgvPromo.Columns["Name"] != null)
            {
                dgvPromo.Columns["Name"].HeaderText = "Tên Khuyến Mãi";
                dgvPromo.Columns["Name"].Width = 200; 
            }
            if (dgvPromo.Columns["Type"] != null) dgvPromo.Columns["Type"].HeaderText = "Loại KM";
            if (dgvPromo.Columns["Value"] != null) dgvPromo.Columns["Value"].HeaderText = "Giá Trị Giảm";
            if (dgvPromo.Columns["Status"] != null) dgvPromo.Columns["Status"].HeaderText = "Trạng Thái";
            if (dgvPromo.Columns["ApplyForFoodId"] != null) dgvPromo.Columns["ApplyForFoodId"].HeaderText = "Mã Món Áp Dụng";
            if (dgvPromo.Columns.Contains("RequiredQty")) dgvPromo.Columns["RequiredQty"].HeaderText = "SL Yêu Cầu";
        }

        void LoadPromoList()
        {
            promoList.DataSource = PromotionBLL.Instance.GetActivePromotions();
        }

        void LoadFoodToCombobox()
        {
            cboFood.DataSource = FoodBLL.Instance.GetAllFood();
            cboFood.DisplayMember = "Name";
            cboFood.ValueMember = "IdFood";
            cboFood.SelectedIndex = -1;
        }

        void LoadTypeToCombobox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(0, "Giảm % Tổng Bill");
            dt.Rows.Add(1, "Giảm % Tiền Giờ");
            dt.Rows.Add(2, "Mua Món Tặng Món");

            cboType.DataSource = dt;
            cboType.DisplayMember = "Name";
            cboType.ValueMember = "ID";
            cboType.SelectedIndex = 0;
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedValue == null) return;
            int type = 0;
            if (int.TryParse(cboType.SelectedValue.ToString(), out type))
            {
                if (type == 2) 
                {
                    lblApplyFood.Visible = true; cboFood.Visible = true;
                    lblReqQty.Visible = true; numReqQty.Visible = true;

                    lblValue.Text = "Số lượng được tặng (cái):";
                }
                else
                {
                    lblApplyFood.Visible = false; cboFood.Visible = false;
                    lblReqQty.Visible = false; numReqQty.Visible = false;

                    lblValue.Text = "Giá trị giảm (%):";
                    cboFood.SelectedIndex = -1;
                    numReqQty.Value = 0;
                }
            }
        }

        private void dgvPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPromo.SelectedRows.Count > 0)
            {
                var item = dgvPromo.SelectedRows[0].DataBoundItem as PromotionDTO;
                if (item != null)
                {
                    txtName.Text = item.Name;
                    cboType.SelectedValue = item.Type;
                    numValue.Value = (decimal)item.Value;

                    if (item.ApplyForFoodId != null)
                        cboFood.SelectedValue = item.ApplyForFoodId;
                    else
                        cboFood.SelectedIndex = -1;

                    numReqQty.Value = item.RequiredQty;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) { MessageBox.Show("Vui lòng nhập tên!"); return; }

            string name = txtName.Text;
            int type = Convert.ToInt32(cboType.SelectedValue);
            double value = (double)numValue.Value;

            int? foodId = null;
            if (type == 2 && cboFood.SelectedValue != null)
                foodId = Convert.ToInt32(cboFood.SelectedValue);

            int reqQty = type == 2 ? (int)numReqQty.Value : 0;

            if (PromotionBLL.Instance.InsertPromotion(name, type, value, foodId, reqQty))
            {
                MessageBox.Show("Thêm thành công!");
                LoadPromoList();
                ResetForm();
            }
            else MessageBox.Show("Lỗi khi thêm!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPromo.SelectedRows.Count == 0) return;
            int id = (dgvPromo.SelectedRows[0].DataBoundItem as PromotionDTO).Id;

            string name = txtName.Text;
            int type = Convert.ToInt32(cboType.SelectedValue);
            double value = (double)numValue.Value;

            int? foodId = null;
            if (type == 2 && cboFood.SelectedValue != null)
                foodId = Convert.ToInt32(cboFood.SelectedValue);

            int reqQty = type == 2 ? (int)numReqQty.Value : 0;

            if (PromotionBLL.Instance.UpdatePromotion(id, name, type, value, foodId, reqQty))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadPromoList();
                ResetForm();
            }
            else MessageBox.Show("Lỗi khi sửa!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPromo.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Xóa khuyến mãi này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (dgvPromo.SelectedRows[0].DataBoundItem as PromotionDTO).Id;
                if (PromotionBLL.Instance.DeletePromotion(id))
                {
                    MessageBox.Show("Đã xóa!");
                    LoadPromoList();
                    ResetForm();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        void ResetForm()
        {
            txtName.Clear();
            numValue.Value = 0;
            cboType.SelectedIndex = 0;
            cboFood.SelectedIndex = -1;
            numReqQty.Value = 0;
            txtName.Focus();
        }
    }
}