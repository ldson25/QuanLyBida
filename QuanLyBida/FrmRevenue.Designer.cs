namespace QuanLyBida
{
    partial class FrmRevenue
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelKPI = new System.Windows.Forms.TableLayoutPanel();
            this.panelKPI1 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelKPI2 = new System.Windows.Forms.Panel();
            this.lblTotalBillCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelKPI3 = new System.Windows.Forms.Panel();
            this.lblAverageRevenue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.splitContainerBody = new System.Windows.Forms.SplitContainer();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.tableLayoutPanelKPI.SuspendLayout();
            this.panelKPI1.SuspendLayout();
            this.panelKPI2.SuspendLayout();
            this.panelKPI3.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).BeginInit();
            this.splitContainerBody.Panel1.SuspendLayout();
            this.splitContainerBody.Panel2.SuspendLayout();
            this.splitContainerBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(308, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO DOANH THU";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.btnExportExcel);
            this.panelFilter.Controls.Add(this.btnInBaoCao);
            this.panelFilter.Controls.Add(this.btnViewBill);
            this.panelFilter.Controls.Add(this.dtpkToDate);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.dtpkFromDate);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 60);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1100, 70);
            this.panelFilter.TabIndex = 1;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(740, 15);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(173, 40);
            this.btnExportExcel.TabIndex = 6;
            this.btnExportExcel.Text = "📥 Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnInBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnInBaoCao.Location = new System.Drawing.Point(919, 15);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(161, 40);
            this.btnInBaoCao.TabIndex = 5;
            this.btnInBaoCao.Text = "🖨 In Báo Cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnViewBill
            // 
            this.btnViewBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnViewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewBill.ForeColor = System.Drawing.Color.White;
            this.btnViewBill.Location = new System.Drawing.Point(480, 15);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(178, 40);
            this.btnViewBill.TabIndex = 4;
            this.btnViewBill.Text = "🔍 Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = false;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkToDate.Location = new System.Drawing.Point(310, 20);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(140, 30);
            this.dtpkToDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(240, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFromDate.Location = new System.Drawing.Point(80, 20);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(140, 30);
            this.dtpkFromDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ";
            // 
            // tableLayoutPanelKPI
            // 
            this.tableLayoutPanelKPI.ColumnCount = 3;
            this.tableLayoutPanelKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelKPI.Controls.Add(this.panelKPI1, 0, 0);
            this.tableLayoutPanelKPI.Controls.Add(this.panelKPI2, 1, 0);
            this.tableLayoutPanelKPI.Controls.Add(this.panelKPI3, 2, 0);
            this.tableLayoutPanelKPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelKPI.Location = new System.Drawing.Point(0, 130);
            this.tableLayoutPanelKPI.Name = "tableLayoutPanelKPI";
            this.tableLayoutPanelKPI.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelKPI.RowCount = 1;
            this.tableLayoutPanelKPI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelKPI.Size = new System.Drawing.Size(1100, 120);
            this.tableLayoutPanelKPI.TabIndex = 2;
            // 
            // panelKPI1
            // 
            this.panelKPI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panelKPI1.Controls.Add(this.lblTotalRevenue);
            this.panelKPI1.Controls.Add(this.label3);
            this.panelKPI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI1.Location = new System.Drawing.Point(20, 20);
            this.panelKPI1.Margin = new System.Windows.Forms.Padding(10);
            this.panelKPI1.Name = "panelKPI1";
            this.panelKPI1.Size = new System.Drawing.Size(340, 80);
            this.panelKPI1.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTotalRevenue.Location = new System.Drawing.Point(0, 35);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(340, 45);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "0 đ";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng Doanh Thu";
            // 
            // panelKPI2
            // 
            this.panelKPI2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panelKPI2.Controls.Add(this.lblTotalBillCount);
            this.panelKPI2.Controls.Add(this.label5);
            this.panelKPI2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI2.Location = new System.Drawing.Point(380, 20);
            this.panelKPI2.Margin = new System.Windows.Forms.Padding(10);
            this.panelKPI2.Name = "panelKPI2";
            this.panelKPI2.Size = new System.Drawing.Size(340, 80);
            this.panelKPI2.TabIndex = 1;
            // 
            // lblTotalBillCount
            // 
            this.lblTotalBillCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalBillCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalBillCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalBillCount.Location = new System.Drawing.Point(0, 35);
            this.lblTotalBillCount.Name = "lblTotalBillCount";
            this.lblTotalBillCount.Size = new System.Drawing.Size(340, 45);
            this.lblTotalBillCount.TabIndex = 1;
            this.lblTotalBillCount.Text = "0";
            this.lblTotalBillCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Hóa Đơn";
            // 
            // panelKPI3
            // 
            this.panelKPI3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelKPI3.Controls.Add(this.lblAverageRevenue);
            this.panelKPI3.Controls.Add(this.label7);
            this.panelKPI3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI3.Location = new System.Drawing.Point(740, 20);
            this.panelKPI3.Margin = new System.Windows.Forms.Padding(10);
            this.panelKPI3.Name = "panelKPI3";
            this.panelKPI3.Size = new System.Drawing.Size(340, 80);
            this.panelKPI3.TabIndex = 2;
            // 
            // lblAverageRevenue
            // 
            this.lblAverageRevenue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAverageRevenue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAverageRevenue.ForeColor = System.Drawing.Color.White;
            this.lblAverageRevenue.Location = new System.Drawing.Point(0, 35);
            this.lblAverageRevenue.Name = "lblAverageRevenue";
            this.lblAverageRevenue.Size = new System.Drawing.Size(340, 45);
            this.lblAverageRevenue.TabIndex = 1;
            this.lblAverageRevenue.Text = "0 đ";
            this.lblAverageRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trung bình";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.splitContainerBody);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 250);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(20);
            this.panelBody.Size = new System.Drawing.Size(1100, 450);
            this.panelBody.TabIndex = 3;
            // 
            // splitContainerBody
            // 
            this.splitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBody.Location = new System.Drawing.Point(20, 20);
            this.splitContainerBody.Name = "splitContainerBody";
            this.splitContainerBody.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBody.Panel1
            // 
            this.splitContainerBody.Panel1.Controls.Add(this.dtgvBill);
            // 
            // splitContainerBody.Panel2
            // 
            this.splitContainerBody.Panel2.Controls.Add(this.chartRevenue);
            this.splitContainerBody.Size = new System.Drawing.Size(1060, 410);
            this.splitContainerBody.SplitterDistance = 180;
            this.splitContainerBody.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AllowUserToDeleteRows = false;
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dtgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBill.ColumnHeadersHeight = 40;
            this.dtgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBill.EnableHeadersVisualStyles = false;
            this.dtgvBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersVisible = false;
            this.dtgvBill.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvBill.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBill.RowTemplate.Height = 35;
            this.dtgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBill.Size = new System.Drawing.Size(1060, 180);
            this.dtgvBill.TabIndex = 0;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(0, 0);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(1060, 226);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chart1";
            title1.Name = "Title1";
            this.chartRevenue.Titles.Add(title1);
            // 
            // FrmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.tableLayoutPanelKPI);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Doanh Thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.tableLayoutPanelKPI.ResumeLayout(false);
            this.panelKPI1.ResumeLayout(false);
            this.panelKPI1.PerformLayout();
            this.panelKPI2.ResumeLayout(false);
            this.panelKPI2.PerformLayout();
            this.panelKPI3.ResumeLayout(false);
            this.panelKPI3.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.splitContainerBody.Panel1.ResumeLayout(false);
            this.splitContainerBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).EndInit();
            this.splitContainerBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKPI;
        private System.Windows.Forms.Panel panelKPI1;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelKPI2;
        private System.Windows.Forms.Label lblTotalBillCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelKPI3;
        private System.Windows.Forms.Label lblAverageRevenue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.SplitContainer splitContainerBody;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Button btnExportExcel;
    }
}