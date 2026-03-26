namespace QuanLyBida
{
    partial class FrmPromotion
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvPromo = new System.Windows.Forms.DataGridView();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.lblReqQty = new System.Windows.Forms.Label();
            this.numReqQty = new System.Windows.Forms.NumericUpDown();
            this.lblApplyFood = new System.Windows.Forms.Label();
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReqQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.labelTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(434, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ CHƯƠNG TRÌNH KHUYẾN MÃI";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.dgvPromo);
            this.pnlContent.Controls.Add(this.groupBoxInput);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContent.Size = new System.Drawing.Size(1184, 501);
            this.pnlContent.TabIndex = 1;
            // 
            // dgvPromo
            // 
            this.dgvPromo.AllowUserToAddRows = false;
            this.dgvPromo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromo.BackgroundColor = System.Drawing.Color.White;
            this.dgvPromo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPromo.ColumnHeadersHeight = 40;
            this.dgvPromo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPromo.EnableHeadersVisualStyles = false;
            this.dgvPromo.Location = new System.Drawing.Point(10, 10);
            this.dgvPromo.MultiSelect = false;
            this.dgvPromo.Name = "dgvPromo";
            this.dgvPromo.ReadOnly = true;
            this.dgvPromo.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPromo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPromo.RowTemplate.Height = 35;
            this.dgvPromo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromo.Size = new System.Drawing.Size(774, 481);
            this.dgvPromo.TabIndex = 0;
            this.dgvPromo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromo_CellClick);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.BackColor = System.Drawing.Color.White;
            this.groupBoxInput.Controls.Add(this.lblReqQty);
            this.groupBoxInput.Controls.Add(this.numReqQty);
            this.groupBoxInput.Controls.Add(this.lblApplyFood);
            this.groupBoxInput.Controls.Add(this.cboFood);
            this.groupBoxInput.Controls.Add(this.lblValue);
            this.groupBoxInput.Controls.Add(this.numValue);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.cboType);
            this.groupBoxInput.Controls.Add(this.txtName);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.btnLamMoi);
            this.groupBoxInput.Controls.Add(this.btnXoa);
            this.groupBoxInput.Controls.Add(this.btnSua);
            this.groupBoxInput.Controls.Add(this.btnThem);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBoxInput.Location = new System.Drawing.Point(784, 10);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(390, 481);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Thông tin chi tiết";
            // 
            // lblReqQty
            // 
            this.lblReqQty.AutoSize = true;
            this.lblReqQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblReqQty.Location = new System.Drawing.Point(20, 280);
            this.lblReqQty.Name = "lblReqQty";
            this.lblReqQty.Size = new System.Drawing.Size(193, 19);
            this.lblReqQty.TabIndex = 13;
            this.lblReqQty.Text = "Mua bao nhiêu thì được tặng:";
            // 
            // numReqQty
            // 
            this.numReqQty.Location = new System.Drawing.Point(20, 305);
            this.numReqQty.Name = "numReqQty";
            this.numReqQty.Size = new System.Drawing.Size(340, 25);
            this.numReqQty.TabIndex = 12;
            // 
            // lblApplyFood
            // 
            this.lblApplyFood.AutoSize = true;
            this.lblApplyFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblApplyFood.Location = new System.Drawing.Point(20, 220);
            this.lblApplyFood.Name = "lblApplyFood";
            this.lblApplyFood.Size = new System.Drawing.Size(151, 19);
            this.lblApplyFood.TabIndex = 11;
            this.lblApplyFood.Text = "Áp dụng cho món nào:";
            // 
            // cboFood
            // 
            this.cboFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Location = new System.Drawing.Point(20, 245);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(340, 25);
            this.cboFood.TabIndex = 10;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(20, 160);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(107, 19);
            this.lblValue.TabIndex = 9;
            this.lblValue.Text = "Giá trị giảm (%):";
            // 
            // numValue
            // 
            this.numValue.Location = new System.Drawing.Point(20, 185);
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(340, 25);
            this.numValue.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại khuyến mãi:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(20, 125);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(340, 25);
            this.cboType.TabIndex = 6;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 25);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên chương trình";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(200, 420);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(160, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(20, 420);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(200, 360);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(160, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "CẬP NHẬT";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 360);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmPromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Khuyến Mãi";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReqQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView dgvPromo;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Label lblApplyFood;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.Label lblReqQty;
        private System.Windows.Forms.NumericUpDown numReqQty;
    }
}