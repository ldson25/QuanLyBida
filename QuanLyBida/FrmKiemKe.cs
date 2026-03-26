using BIDABLL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyBida
{
    public partial class FrmKiemKe : Form
    {
        private BindingSource bindingSourceInventory = new BindingSource();

        public FrmKiemKe()
        {
            InitializeComponent();
            LoadDataFirstTime();
        }

        void LoadDataFirstTime()
        {
            LoadCategoryIntoCombobox();
            LoadInventoryData();
        }

        void LoadCategoryIntoCombobox()
        {
            List<string> categories = FoodBLL.Instance.GetAllCategories();

            categories.Insert(0, "Tất cả danh mục");

            cbCategory.DataSource = categories;
            cbCategory.SelectedIndex = 0;
        }

        void LoadInventoryData()
        {
            List<FoodDTO> data = FoodBLL.Instance.GetInventoryList();

            DataTable dt = ConvertToDataTable(data);

            bindingSourceInventory.DataSource = dt;
            dtgvInventory.DataSource = bindingSourceInventory;

            FormatGrid();
            CalculateSummary();
        }

        private DataTable ConvertToDataTable(List<FoodDTO> data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdFood", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CategoryName", typeof(string));
            table.Columns.Add("Unit", typeof(string));
            table.Columns.Add("Inventory", typeof(int));
            table.Columns.Add("Price", typeof(decimal));


            foreach (var item in data)
            {
                table.Rows.Add(item.IdFood, item.Name, item.CategoryName, item.Unit, item.Inventory, item.Price);
            }
            return table;
        }

        void FormatGrid()
        {
            if (dtgvInventory.Columns.Count == 0) return;

            dtgvInventory.Columns["IdFood"].HeaderText = "Mã SP";
            dtgvInventory.Columns["Name"].HeaderText = "Tên Sản Phẩm";
            dtgvInventory.Columns["CategoryName"].HeaderText = "Loại";
            dtgvInventory.Columns["Unit"].HeaderText = "ĐVT";
            dtgvInventory.Columns["Inventory"].HeaderText = "SL Tồn";
            dtgvInventory.Columns["Price"].HeaderText = "Giá Bán";
            dtgvInventory.Columns["Price"].DefaultCellStyle.Format = "#,##0 VND";
            dtgvInventory.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvInventory.Columns["Inventory"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvInventory.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void CalculateSummary()
        {
            int totalQty = 0;
            decimal totalVal = 0;

            foreach (DataGridViewRow row in dtgvInventory.Rows)
            {
                if (row.Visible)
                {
                    int qty = row.Cells["Inventory"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["Inventory"].Value) : 0;
                    decimal price = row.Cells["Price"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["Price"].Value) : 0;

                    totalQty += qty;
                    totalVal += (qty * price);
                }
            }

            lblTotalQty.Text = $"Tổng số lượng: {totalQty:N0}";
            lblTotalValue.Text = $"Tổng giá trị ước tính: {totalVal:N0} VND";
        }

        void FilterData()
        {
            string keyword = txtSearch.Text.Trim().Replace("'", "''"); // Tránh lỗi ký tự đặc biệt
            string selectedCategory = cbCategory.SelectedItem != null ? cbCategory.SelectedItem.ToString() : "Tất cả danh mục";

            string filterExpression = "";

            if (!string.IsNullOrEmpty(keyword))
            {
                filterExpression += string.Format("Name LIKE '%{0}%'", keyword);
            }

            if (selectedCategory != "Tất cả danh mục")
            {
                if (filterExpression.Length > 0) filterExpression += " AND ";
                filterExpression += string.Format("CategoryName = '{0}'", selectedCategory);
            }

            bindingSourceInventory.Filter = filterExpression;

            CalculateSummary();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
            txtSearch.Text = "";
            cbCategory.SelectedIndex = 0;
            MessageBox.Show("Dữ liệu kho đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvInventory.Columns[e.ColumnIndex].Name == "Inventory" && e.Value != null)
            {
                int qty = int.Parse(e.Value.ToString());
                if (qty <= 10)
                {
                    e.CellStyle.BackColor = Color.MistyRose;
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(dtgvInventory.Font, FontStyle.Bold);
                }
            }
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dtgvInventory.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            sfd.FileName = "BaoCaoTonKho_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dtgvInventory, sfd.FileName);
            }
        }

        private void ToExcel(DataGridView dgv, string fileName)
        {
            Excel.Application excelApp = new Excel.Application();
            try
            {
                excelApp.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = null;
                worksheet = excelApp.ActiveSheet;
                worksheet.Name = "Báo Cáo Tồn Kho";

                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    Excel.Range cell = worksheet.Cells[1, i];
                    cell.Font.Bold = true;
                    cell.Interior.Color = Color.LightGray;
                    cell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                worksheet.Columns.AutoFit();

                excelApp.ActiveWorkbook.SaveCopyAs(fileName);
                excelApp.ActiveWorkbook.Saved = true;

                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                excelApp.Quit();
            }
            finally
            {
                ReleaseObject(excelApp);
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Lỗi giải phóng bộ nhớ: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
