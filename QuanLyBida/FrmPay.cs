using BIDABLL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBida
{
    public partial class FrmPay : Form
    {
        private int _idTable;
        private int _tableTypeId;
        private DateTime _startTime;

        private decimal _tableFee = 0;
        private decimal _foodFee = 0;
        private decimal _discount = 0;
        private decimal _surcharge = 0;
        private decimal _totalAmount = 0;

        public FrmPay(int idTable, string tableName, int tableTypeId, DateTime startTime)
        {
            InitializeComponent();

            this._idTable = idTable;
            this._tableTypeId = tableTypeId;
            this._startTime = startTime;

            this.txtCustomerMoney.TextChanged += new EventHandler(txtCustomerMoney_TextChanged);
            this.txtSurcharge.TextChanged += new EventHandler(txtSurcharge_TextChanged);
            this.txtDiscount.TextChanged += new EventHandler(txtDiscount_TextChanged);

            lblTableName.Text = tableName;

            ConfigGrid();

            LoadBillDetails();
            LoadBillData();
            LoadPromotions();
        }

        private void ConfigGrid()
        {
            dgvBillDetails.AutoGenerateColumns = false;
            dgvBillDetails.Columns.Clear();

            dgvBillDetails.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FoodName",
                HeaderText = "Tên Món",
                Name = "NAME",
                Width = 150,
                ReadOnly = true
            });

            dgvBillDetails.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Quantity",
                HeaderText = "SL",
                Name = "COUNT",
                Width = 50
            });

            dgvBillDetails.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Price",
                HeaderText = "Đơn Giá",
                Name = "PRICE",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } 
            });

            dgvBillDetails.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Total",
                HeaderText = "Thành Tiền",
                Name = "TOTAL",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } 
            });
        }

        private void LoadPromotions()
        {
            try
            {
                List<PromotionDTO> listPromo = PromotionBLL.Instance.GetActivePromotions();
                listPromo.Insert(0, new PromotionDTO(0, "--- Không áp dụng ---", 0, 0, true, null, 0));

                cboPromotion.DataSource = listPromo;
                cboPromotion.DisplayMember = "Name";
            }
            catch { }
        }

        // --- XỬ LÝ KHUYẾN MÃI  ---
        private void cboPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PromotionDTO selectedPromo = cboPromotion.SelectedItem as PromotionDTO;

                if (selectedPromo == null || selectedPromo.Id == 0)
                {
                    txtDiscount.Text = "0";
                    return;
                }

                decimal discountAmount = 0;

                if (selectedPromo.Type == 0)
                {
                    decimal totalTemp = _tableFee + _foodFee + _surcharge;
                    discountAmount = totalTemp * (decimal)(selectedPromo.Value / 100);
                }
                else if (selectedPromo.Type == 1)
                {
                    discountAmount = _tableFee * (decimal)(selectedPromo.Value / 100);
                }
                else if (selectedPromo.Type == 2)
                {
                    bool foundItem = false;

                    int targetFoodId = selectedPromo.ApplyForFoodId ?? 0;
                    int requiredQty = selectedPromo.RequiredQty;
                    int freeQty = (int)selectedPromo.Value;

                    if (targetFoodId == 0) return;

                    foreach (DataGridViewRow row in dgvBillDetails.Rows)
                    {
                        if (row.IsNewRow) continue;

                        BillDetailsDTO item = row.DataBoundItem as BillDetailsDTO;

                        if (item != null)
                        {
                            if (item.IDFOOD == targetFoodId)
                            {
                                foundItem = true;

                                if (item.Quantity >= requiredQty && requiredQty > 0)
                                {
                                    int numberOfFreeItems = (item.Quantity / requiredQty) * freeQty;
                                    discountAmount += numberOfFreeItems * item.Price;
                                }
                                else
                                {
                                    MessageBox.Show($"Chương trình '{selectedPromo.Name}' yêu cầu mua ít nhất {requiredQty} món.\nBạn mới gọi {item.Quantity} {item.FoodName}.",
                                                    "Gợi ý ưu đãi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }

                    if (!foundItem)
                    {
                        MessageBox.Show($"Hóa đơn không có món ăn phù hợp với chương trình '{selectedPromo.Name}'!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                txtDiscount.Text = discountAmount.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính khuyến mãi: " + ex.Message + "\n(Hãy kiểm tra lại BillDetailsDTO xem đã có IDFOOD chưa?)");
                txtDiscount.Text = "0";
            }
        }

        private void LoadBillData()
        {
            TimeSpan duration = DateTime.Now - _startTime;
            lblPlayTime.Text = string.Format("{0:00}:{1:00}:{2:00}", duration.Hours, duration.Minutes, duration.Seconds);

            _tableFee = TableBLL.Instance.CalculateTableFee(duration, _tableTypeId);
            lblTableFee.Text = _tableFee.ToString("N0") + " đ";

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            string cleanSurcharge = txtSurcharge.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim();
            if (!decimal.TryParse(cleanSurcharge, out _surcharge)) _surcharge = 0;

            string cleanDiscount = txtDiscount.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim();
            if (!decimal.TryParse(cleanDiscount, out _discount)) _discount = 0;

            _totalAmount = (_tableFee + _foodFee + _surcharge) - _discount;

            if (_totalAmount < 0) _totalAmount = 0;

            lblTotalAmount.Text = _totalAmount.ToString("N0") + " đ";
            CalculateChange();
        }

        private void CalculateChange()
        {
            string cleanMoney = txtCustomerMoney.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim();
            if (decimal.TryParse(cleanMoney, out decimal customerMoney))
            {
                decimal change = customerMoney - _totalAmount;
                txtChange.Text = (change > 0 ? change : 0).ToString("N0") + " đ";
            }
            else
            {
                txtChange.Text = "0 đ";
            }
        }

        private void txtCustomerMoney_TextChanged(object sender, EventArgs e) => CalculateChange();
        private void txtSurcharge_TextChanged(object sender, EventArgs e) => CalculateTotal();
        private void txtDiscount_TextChanged(object sender, EventArgs e) => CalculateTotal();

        private void btnPay_Click(object sender, EventArgs e)
        {
            string cleanMoney = txtCustomerMoney.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim();
            decimal customerMoney = 0;
            decimal.TryParse(cleanMoney, out customerMoney);

            if (customerMoney < _totalAmount && _totalAmount > 0)
            {
                MessageBox.Show("Khách chưa đưa đủ tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerMoney.Focus();
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn thanh toán hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int billId = BillBLL.Instance.Checkout(
                        _idTable, _tableFee, _foodFee, (int)_discount, _surcharge, _totalAmount
                    );

                    if (billId != -1)
                    {
                        FrmReportViewer reportForm = new FrmReportViewer(billId);
                        reportForm.ShowDialog();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi lưu hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                }
            }
        }

        private void LoadBillDetails()
        {
            try
            {
                var result = BillBLL.Instance.GetFoodDetailsAndTotal(_idTable);
                dgvBillDetails.DataSource = result.Item1;

                _foodFee = result.Item2;
                lblFoodFee.Text = _foodFee.ToString("N0") + " đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải món: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}