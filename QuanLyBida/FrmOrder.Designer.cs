namespace QuanLyBida
{
    partial class FrmOrder
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowFoods = new System.Windows.Forms.FlowLayoutPanel(); 
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox(); 
            this.txtSearch = new System.Windows.Forms.TextBox(); 
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView(); 
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button(); 
            this.groupBoxNote = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.panelHeaderRight = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panelBottomRight.SuspendLayout();
            this.groupBoxNote.SuspendLayout();
            this.panelHeaderRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft 
            // 
            this.panelLeft.Controls.Add(this.flowFoods);
            this.panelLeft.Controls.Add(this.panelSearch);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(800, 700);
            this.panelLeft.TabIndex = 0;
            // 
            // flowFoods
            // 
            this.flowFoods.AutoScroll = true;
            this.flowFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.flowFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFoods.Location = new System.Drawing.Point(0, 70);
            this.flowFoods.Name = "flowFoods";
            this.flowFoods.Padding = new System.Windows.Forms.Padding(10);
            this.flowFoods.Size = new System.Drawing.Size(800, 630);
            this.flowFoods.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.cboCategory);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(800, 70);
            this.panelSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(350, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục:";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(450, 20);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 33);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 32);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(270, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelRight 
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.dgvBill);
            this.panelRight.Controls.Add(this.panelBottomRight);
            this.panelRight.Controls.Add(this.panelHeaderRight);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(800, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(400, 700);
            this.panelRight.TabIndex = 1;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.ColumnHeadersHeight = 40;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.EnableHeadersVisualStyles = false;
            this.dgvBill.Location = new System.Drawing.Point(0, 60);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.RowTemplate.Height = 40;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(398, 488);
            this.dgvBill.TabIndex = 2;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottomRight.Controls.Add(this.groupBoxNote);
            this.panelBottomRight.Controls.Add(this.btnClose);
            this.panelBottomRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomRight.Location = new System.Drawing.Point(0, 548);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(398, 150);
            this.panelBottomRight.TabIndex = 1;
            // 
            // groupBoxNote 
            // 
            this.groupBoxNote.Controls.Add(this.txtNote);
            this.groupBoxNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxNote.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxNote.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNote.Name = "groupBoxNote";
            this.groupBoxNote.Size = new System.Drawing.Size(398, 80);
            this.groupBoxNote.TabIndex = 1;
            this.groupBoxNote.TabStop = false;
            this.groupBoxNote.Text = "Ghi chú / Dặn dò";
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNote.Location = new System.Drawing.Point(3, 26);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(392, 51);
            this.txtNote.TabIndex = 0;
            // 
            // btnClose 
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 90);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(398, 60);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "XÁC NHẬN GỌI MÓN";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeaderRight
            // 
            this.panelHeaderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.panelHeaderRight.Controls.Add(this.label3);
            this.panelHeaderRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderRight.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderRight.Name = "panelHeaderRight";
            this.panelHeaderRight.Size = new System.Drawing.Size(398, 60);
            this.panelHeaderRight.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH CHỌN";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Name = "FrmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gọi Món";
            this.panelLeft.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panelBottomRight.ResumeLayout(false);
            this.groupBoxNote.ResumeLayout(false);
            this.groupBoxNote.PerformLayout();
            this.panelHeaderRight.ResumeLayout(false);
            this.panelHeaderRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.FlowLayoutPanel flowFoods; 
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboCategory; 
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch; 
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.Panel panelHeaderRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBill; 
        private System.Windows.Forms.Button btnClose; 
        private System.Windows.Forms.GroupBox groupBoxNote;
        private System.Windows.Forms.TextBox txtNote;
    }
}