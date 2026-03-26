namespace QuanLyBida
{
    partial class FrmFood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft (FORM NHẬP LIỆU)
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.groupBoxInfo);
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(400, 700);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.btnBrowseImage);
            this.groupBoxInfo.Controls.Add(this.picFood);
            this.groupBoxInfo.Controls.Add(this.txtImage);
            this.groupBoxInfo.Controls.Add(this.label4);
            this.groupBoxInfo.Controls.Add(this.txtPrice);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Controls.Add(this.cboCategory);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.txtName);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(375, 500);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông Tin Món Ăn";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseImage.Location = new System.Drawing.Point(325, 250);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(40, 30);
            this.btnBrowseImage.TabIndex = 9;
            this.btnBrowseImage.Text = "...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // picFood
            // 
            this.picFood.BackColor = System.Drawing.Color.Gainsboro;
            this.picFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFood.Location = new System.Drawing.Point(110, 290);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(180, 180);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFood.TabIndex = 8;
            this.picFood.TabStop = false;
            // 
            // txtImage
            // 
            this.txtImage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtImage.Location = new System.Drawing.Point(110, 250);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(210, 30);
            this.txtImage.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(20, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hình ảnh:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(110, 190);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(255, 30);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(20, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá:";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(110, 130);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(255, 31);
            this.cboCategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(20, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh mục:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(110, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 30);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Món:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnDong);
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnLamMoi);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 530);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(400, 170);
            this.panelButtons.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Gray;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(210, 110);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(155, 45);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(35, 110);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(155, 45);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(210, 60);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(155, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(35, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(155, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(210, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(155, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(35, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(155, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelRight (DANH SÁCH)
            // 
            this.panelRight.Controls.Add(this.dgvFood);
            this.panelRight.Controls.Add(this.panelTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(800, 700);
            this.panelRight.TabIndex = 1;
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.BackgroundColor = System.Drawing.Color.White;
            this.dgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFood.ColumnHeadersHeight = 40;
            this.dgvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFood.EnableHeadersVisualStyles = false;
            this.dgvFood.Location = new System.Drawing.Point(0, 70);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFood.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFood.RowTemplate.Height = 30;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(800, 630);
            this.dgvFood.TabIndex = 1;
            this.dgvFood.SelectionChanged += new System.EventHandler(this.dgvFood_SelectionChanged);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 70);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(800, 70);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ DANH MỤC MÓN ĂN";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "FrmFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Món Ăn";
            this.panelLeft.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
    }
}