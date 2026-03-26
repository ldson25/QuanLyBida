namespace QuanLyBida
{
    partial class FrmImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleRow = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox(); 
            this.labelUnit = new System.Windows.Forms.Label(); 
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.groupBoxInput);
            this.panelLeft.Controls.Add(this.labelTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(400, 650);
            this.panelLeft.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(400, 70);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "NHẬP KHO";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.BackColor = System.Drawing.Color.White;
            this.groupBoxInput.Controls.Add(this.btnAdd);
            this.groupBoxInput.Controls.Add(this.txtNote);
            this.groupBoxInput.Controls.Add(this.label5);
            this.groupBoxInput.Controls.Add(this.txtPrice);
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.numSL);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.cboUnit);
            this.groupBoxInput.Controls.Add(this.labelUnit);
            this.groupBoxInput.Controls.Add(this.cboFood);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBoxInput.Location = new System.Drawing.Point(15, 85);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(370, 480);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Thông tin nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn sản phẩm:";
            // 
            // cboFood
            // 
            this.cboFood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFood.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Location = new System.Drawing.Point(20, 65);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(330, 28);
            this.cboFood.TabIndex = 1;
            this.cboFood.SelectedIndexChanged += new System.EventHandler(this.cboFood_SelectedIndexChanged);
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelUnit.ForeColor = System.Drawing.Color.DimGray;
            this.labelUnit.Location = new System.Drawing.Point(20, 110);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(91, 19);
            this.labelUnit.TabIndex = 9;
            this.labelUnit.Text = "Đơn vị tính:";
            // 
            // cboUnit
            // 
            this.cboUnit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "Lon",
            "Chai",
            "Ly",
            "Gói",
            "Thùng",
            "Cái",
            "Dĩa",
            "Tô"});
            this.cboUnit.Location = new System.Drawing.Point(20, 135);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(150, 28);
            this.cboUnit.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(190, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // numSL
            // 
            this.numSL.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numSL.Location = new System.Drawing.Point(190, 135);
            this.numSL.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(160, 27);
            this.numSL.TabIndex = 3;
            this.numSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(20, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá bán (VNĐ):";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPrice.Location = new System.Drawing.Point(20, 205);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(330, 27);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(20, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNote.Location = new System.Drawing.Point(20, 275);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(330, 27);
            this.txtNote.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(330, 50);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "⬇ THÊM VÀO DANH SÁCH";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dgvList);
            this.panelRight.Controls.Add(this.panelBottom);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(682, 650);
            this.panelRight.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyleHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyleHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyleHeader.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleHeader.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyleHeader.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyleHeader.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleHeader;
            this.dgvList.ColumnHeadersHeight = 40;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(10, 10);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            dataGridViewCellStyleRow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyleRow;
            this.dgvList.RowTemplate.Height = 35;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(662, 540);
            this.dgvList.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnSave);
            this.panelBottom.Controls.Add(this.lblTotal);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(10, 550);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(662, 90);
            this.panelBottom.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(440, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 50);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "LƯU & CẬP NHẬT KHO";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblTotal.Location = new System.Drawing.Point(20, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(189, 30);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "TỔNG TIỀN: 0 đ";
            // 
            // FrmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 650);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "FrmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Kho Nguyên Liệu";
            this.panelLeft.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ComboBox cboUnit; 
        private System.Windows.Forms.Label labelUnit;
    }
}