namespace QuanLyBida
{
    partial class FrmSettings
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPriceConfig = new System.Windows.Forms.Button();
            this.btnTableManager = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pnlPriceConfig = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSavePrice = new System.Windows.Forms.Button();
            this.txtPriceLo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice3Bi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHeaderPrice = new System.Windows.Forms.Label();
            this.pnlTableManager = new System.Windows.Forms.Panel();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.panelTableActions = new System.Windows.Forms.Panel();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.cboTableType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelHeaderTable = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.pnlPriceConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlTableManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.panelTableActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu 
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelMenu.Controls.Add(this.btnPriceConfig);
            this.panelMenu.Controls.Add(this.btnTableManager);
            this.panelMenu.Controls.Add(this.panelHeader);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 600);
            this.panelMenu.TabIndex = 0;
            // 
            // btnPriceConfig
            // 
            this.btnPriceConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPriceConfig.FlatAppearance.BorderSize = 0;
            this.btnPriceConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceConfig.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPriceConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPriceConfig.Location = new System.Drawing.Point(0, 140);
            this.btnPriceConfig.Name = "btnPriceConfig";
            this.btnPriceConfig.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPriceConfig.Size = new System.Drawing.Size(250, 60);
            this.btnPriceConfig.TabIndex = 2;
            this.btnPriceConfig.Text = "💲 Cấu Hình Giá";
            this.btnPriceConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPriceConfig.UseVisualStyleBackColor = true;
            this.btnPriceConfig.Click += new System.EventHandler(this.btnPriceConfig_Click);
            // 
            // btnTableManager
            // 
            this.btnTableManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnTableManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTableManager.FlatAppearance.BorderSize = 0;
            this.btnTableManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableManager.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTableManager.ForeColor = System.Drawing.Color.White;
            this.btnTableManager.Location = new System.Drawing.Point(0, 80);
            this.btnTableManager.Name = "btnTableManager";
            this.btnTableManager.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTableManager.Size = new System.Drawing.Size(250, 60);
            this.btnTableManager.TabIndex = 1;
            this.btnTableManager.Text = "🎱 Quản Lý Bàn";
            this.btnTableManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableManager.UseVisualStyleBackColor = false;
            this.btnTableManager.Click += new System.EventHandler(this.btnTableManager_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(250, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CÀI ĐẶT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContent 
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelContent.Controls.Add(this.pnlPriceConfig);
            this.panelContent.Controls.Add(this.pnlTableManager);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(732, 600);
            this.panelContent.TabIndex = 1;
            // 
            // pnlPriceConfig 
            // 
            this.pnlPriceConfig.BackColor = System.Drawing.Color.White;
            this.pnlPriceConfig.Controls.Add(this.groupBox2);
            this.pnlPriceConfig.Controls.Add(this.labelHeaderPrice);
            this.pnlPriceConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPriceConfig.Location = new System.Drawing.Point(20, 20);
            this.pnlPriceConfig.Name = "pnlPriceConfig";
            this.pnlPriceConfig.Size = new System.Drawing.Size(692, 560);
            this.pnlPriceConfig.TabIndex = 1;
            this.pnlPriceConfig.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSavePrice);
            this.groupBox2.Controls.Add(this.txtPriceLo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPrice3Bi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.Location = new System.Drawing.Point(40, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Giá Giờ Chơi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(200, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "* Giá tiền sẽ áp dụng cho các lượt chơi mới.";
            // 
            // btnSavePrice
            // 
            this.btnSavePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSavePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSavePrice.ForeColor = System.Drawing.Color.White;
            this.btnSavePrice.Location = new System.Drawing.Point(200, 180);
            this.btnSavePrice.Name = "btnSavePrice";
            this.btnSavePrice.Size = new System.Drawing.Size(180, 50);
            this.btnSavePrice.TabIndex = 4;
            this.btnSavePrice.Text = "LƯU CẬP NHẬT";
            this.btnSavePrice.UseVisualStyleBackColor = false;
            this.btnSavePrice.Click += new System.EventHandler(this.btnSavePrice_Click);
            // 
            // txtPriceLo
            // 
            this.txtPriceLo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPriceLo.Location = new System.Drawing.Point(200, 110);
            this.txtPriceLo.Name = "txtPriceLo";
            this.txtPriceLo.Size = new System.Drawing.Size(300, 34);
            this.txtPriceLo.TabIndex = 3;
            this.txtPriceLo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Bàn Lỗ:";
            // 
            // txtPrice3Bi
            // 
            this.txtPrice3Bi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrice3Bi.Location = new System.Drawing.Point(200, 50);
            this.txtPrice3Bi.Name = "txtPrice3Bi";
            this.txtPrice3Bi.Size = new System.Drawing.Size(300, 34);
            this.txtPrice3Bi.TabIndex = 1;
            this.txtPrice3Bi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá Bàn 3 Bi:";
            // 
            // labelHeaderPrice
            // 
            this.labelHeaderPrice.AutoSize = true;
            this.labelHeaderPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelHeaderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelHeaderPrice.Location = new System.Drawing.Point(30, 20);
            this.labelHeaderPrice.Name = "labelHeaderPrice";
            this.labelHeaderPrice.Size = new System.Drawing.Size(225, 37);
            this.labelHeaderPrice.TabIndex = 0;
            this.labelHeaderPrice.Text = "CẤU HÌNH GIÁ ";
            // 
            // pnlTableManager 
            // 
            this.pnlTableManager.BackColor = System.Drawing.Color.White;
            this.pnlTableManager.Controls.Add(this.dgvTables);
            this.pnlTableManager.Controls.Add(this.panelTableActions);
            this.pnlTableManager.Controls.Add(this.labelHeaderTable);
            this.pnlTableManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableManager.Location = new System.Drawing.Point(20, 20);
            this.pnlTableManager.Name = "pnlTableManager";
            this.pnlTableManager.Size = new System.Drawing.Size(692, 560);
            this.pnlTableManager.TabIndex = 0;
            // 
            // dgvTables
            // 
            this.dgvTables.AllowUserToAddRows = false;
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTables.BackgroundColor = System.Drawing.Color.White;
            this.dgvTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTables.ColumnHeadersHeight = 35;
            this.dgvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTables.EnableHeadersVisualStyles = false;
            this.dgvTables.Location = new System.Drawing.Point(0, 160);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.RowHeadersVisible = false;
            this.dgvTables.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTables.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTables.RowTemplate.Height = 30;
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new System.Drawing.Size(692, 400);
            this.dgvTables.TabIndex = 2;
            // 
            // panelTableActions
            // 
            this.panelTableActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTableActions.Controls.Add(this.btnDeleteTable);
            this.panelTableActions.Controls.Add(this.btnAddTable);

            // --- THÊM COMBOBOX KHU VỰC VÀO PANEL ---
            this.panelTableActions.Controls.Add(this.cboKhuVuc);
            this.panelTableActions.Controls.Add(this.lblKhuVuc);
            // ---------------------------------------

            this.panelTableActions.Controls.Add(this.cboTableType);
            this.panelTableActions.Controls.Add(this.label6);
            this.panelTableActions.Controls.Add(this.txtTableName);
            this.panelTableActions.Controls.Add(this.label5);
            this.panelTableActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTableActions.Location = new System.Drawing.Point(0, 80);
            this.panelTableActions.Name = "panelTableActions";
            this.panelTableActions.Size = new System.Drawing.Size(692, 80);
            this.panelTableActions.TabIndex = 1;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTable.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTable.Location = new System.Drawing.Point(590, 20); // Dịch sang phải
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(90, 40);
            this.btnDeleteTable.TabIndex = 5;
            this.btnDeleteTable.Text = "XÓA";
            this.btnDeleteTable.UseVisualStyleBackColor = false;
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTable.Location = new System.Drawing.Point(490, 20); 
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(90, 40);
            this.btnAddTable.TabIndex = 4;
            this.btnAddTable.Text = "THÊM";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // cboTableType
            // 
            this.cboTableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTableType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTableType.FormattingEnabled = true;
            this.cboTableType.Location = new System.Drawing.Point(235, 25); 
            this.cboTableType.Name = "cboTableType";
            this.cboTableType.Size = new System.Drawing.Size(100, 31);
            this.cboTableType.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(190, 28); // Dịch
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Loại:";
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhuVuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2"});
            this.cboKhuVuc.Location = new System.Drawing.Point(380, 25);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(100, 31);
            this.cboKhuVuc.TabIndex = 7;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKhuVuc.Location = new System.Drawing.Point(340, 28);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(38, 23);
            this.lblKhuVuc.TabIndex = 6;
            this.lblKhuVuc.Text = "KV:";
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTableName.Location = new System.Drawing.Point(55, 25);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(130, 30);
            this.txtTableName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(10, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên:";
            // 
            // labelHeaderTable
            // 
            this.labelHeaderTable.AutoSize = true;
            this.labelHeaderTable.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelHeaderTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelHeaderTable.Location = new System.Drawing.Point(20, 20);
            this.labelHeaderTable.Name = "labelHeaderTable";
            this.labelHeaderTable.Size = new System.Drawing.Size(394, 37);
            this.labelHeaderTable.TabIndex = 0;
            this.labelHeaderTable.Text = "QUẢN LÝ DANH SÁCH BÀN";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết Lập Hệ Thống";
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.pnlPriceConfig.ResumeLayout(false);
            this.pnlPriceConfig.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlTableManager.ResumeLayout(false);
            this.pnlTableManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.panelTableActions.ResumeLayout(false);
            this.panelTableActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPriceConfig;
        private System.Windows.Forms.Button btnTableManager;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContent;

        // Panel Quản lý Bàn
        private System.Windows.Forms.Panel pnlTableManager;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Panel panelTableActions;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.ComboBox cboTableType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelHeaderTable;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Label lblKhuVuc;

        // Panel Cấu hình Giá
        private System.Windows.Forms.Panel pnlPriceConfig;
        private System.Windows.Forms.Label labelHeaderPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSavePrice;
        private System.Windows.Forms.TextBox txtPriceLo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice3Bi;
        private System.Windows.Forms.Label label2;
    }
}