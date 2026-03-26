namespace QuanLyBida
{
    partial class FrmKiemKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.btnExportExcel = new System.Windows.Forms.Button();

            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.dtgvInventory = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1084, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KHO HÀNG VÀ KIỂM KÊ TỒN";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelControl.Controls.Add(this.label1);

            this.panelControl.Controls.Add(this.btnExportExcel);

            this.panelControl.Controls.Add(this.btnRefresh);
            this.panelControl.Controls.Add(this.btnSearch);
            this.panelControl.Controls.Add(this.txtSearch);
            this.panelControl.Controls.Add(this.cbCategory);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 60);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1084, 60);
            this.panelControl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lọc / Tìm:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(820, 14); // Dời sang trái chút
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "↻ Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // btnExportExcel (NÚT MỚI)
            //
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.DarkOrange; // Màu khác cho nổi
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(951, 14); // Vị trí góc phải
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(121, 32);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "🖨 Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(535, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "🔍 Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // Lưu ý: txtSearch_TextChanged đã xử lý tìm kiếm nên nút này có thể dùng để trigger lại hoặc để trang trí
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(286, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(243, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(86, 15);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(194, 28);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSummary.Controls.Add(this.lblTotalValue);
            this.panelSummary.Controls.Add(this.lblTotalQty);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSummary.Location = new System.Drawing.Point(0, 561);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(1084, 50);
            this.panelSummary.TabIndex = 2;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalValue.Location = new System.Drawing.Point(750, 15);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(197, 21);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "Tổng giá trị kho: 0 VNĐ";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalQty.Location = new System.Drawing.Point(14, 15);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(148, 21);
            this.lblTotalQty.TabIndex = 0;
            this.lblTotalQty.Text = "Tổng số lượng: 0";
            // 
            // dtgvInventory
            // 
            this.dtgvInventory.AllowUserToAddRows = false;
            this.dtgvInventory.AllowUserToDeleteRows = false;
            this.dtgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dtgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvInventory.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInventory.GridColor = System.Drawing.Color.Gainsboro;
            this.dtgvInventory.Location = new System.Drawing.Point(0, 120);
            this.dtgvInventory.Name = "dtgvInventory";
            this.dtgvInventory.ReadOnly = true;
            this.dtgvInventory.RowHeadersVisible = false;
            this.dtgvInventory.RowTemplate.Height = 30;
            this.dtgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvInventory.Size = new System.Drawing.Size(1084, 441);
            this.dtgvInventory.TabIndex = 3;
            this.dtgvInventory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvInventory_CellFormatting);
            // 
            // FrmKiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dtgvInventory);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmKiemKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tồn kho";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExportExcel; 
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.DataGridView dtgvInventory;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label1;
    }
}