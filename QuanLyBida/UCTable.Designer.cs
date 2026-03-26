namespace QuanLyBida
{
    partial class UCTable
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTable));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTableType = new System.Windows.Forms.Label();
            this.lblTimePlay = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDatTruoc = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnHuyDat = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.flpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.lblTableName);
            this.pnlHeader.Controls.Add(this.picIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(465, 62);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.ForeColor = System.Drawing.Color.White;
            this.lblTableName.Location = new System.Drawing.Point(67, 0);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(398, 62);
            this.lblTableName.TabIndex = 1;
            this.lblTableName.Text = "BÀN 01";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIcon
            // 
            this.picIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(0, 0);
            this.picIcon.Margin = new System.Windows.Forms.Padding(4);
            this.picIcon.Name = "picIcon";
            this.picIcon.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.picIcon.Size = new System.Drawing.Size(67, 62);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBody.Controls.Add(this.lblStatus);
            this.pnlBody.Controls.Add(this.lblTableType);
            this.pnlBody.Controls.Add(this.lblTimePlay);
            this.pnlBody.Controls.Add(this.lblStartTime);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 62);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(465, 288);
            this.pnlBody.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(13, 105);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Trạng thái";
            // 
            // lblTableType
            // 
            this.lblTableType.AutoSize = true;
            this.lblTableType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTableType.Location = new System.Drawing.Point(13, 12);
            this.lblTableType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableType.Name = "lblTableType";
            this.lblTableType.Size = new System.Drawing.Size(78, 23);
            this.lblTableType.TabIndex = 2;
            this.lblTableType.Text = "Loại bàn";
            // 
            // lblTimePlay
            // 
            this.lblTimePlay.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePlay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTimePlay.Location = new System.Drawing.Point(0, 37);
            this.lblTimePlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimePlay.Name = "lblTimePlay";
            this.lblTimePlay.Size = new System.Drawing.Size(373, 49);
            this.lblTimePlay.TabIndex = 0;
            this.lblTimePlay.Text = "00:00:00";
            this.lblTimePlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.Gray;
            this.lblStartTime.Location = new System.Drawing.Point(240, 105);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(109, 20);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Bắt đầu: --:--:--";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flpActions
            // 
            this.flpActions.BackColor = System.Drawing.Color.White;
            this.flpActions.Controls.Add(this.btnStart);
            this.flpActions.Controls.Add(this.btnDatTruoc);
            this.flpActions.Controls.Add(this.btnOrder);
            this.flpActions.Controls.Add(this.btnChuyenBan);
            this.flpActions.Controls.Add(this.btnPay);
            this.flpActions.Controls.Add(this.btnHuyDat);
            this.flpActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpActions.Location = new System.Drawing.Point(0, 239);
            this.flpActions.Margin = new System.Windows.Forms.Padding(4);
            this.flpActions.Name = "flpActions";
            this.flpActions.Padding = new System.Windows.Forms.Padding(4);
            this.flpActions.Size = new System.Drawing.Size(465, 111);
            this.flpActions.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(7, 6);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 43);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "BẮT ĐẦU";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDatTruoc
            // 
            this.btnDatTruoc.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDatTruoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTruoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatTruoc.ForeColor = System.Drawing.Color.White;
            this.btnDatTruoc.Location = new System.Drawing.Point(126, 6);
            this.btnDatTruoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatTruoc.Name = "btnDatTruoc";
            this.btnDatTruoc.Size = new System.Drawing.Size(113, 43);
            this.btnDatTruoc.TabIndex = 5;
            this.btnDatTruoc.Text = "ĐẶT BÀN";
            this.btnDatTruoc.UseVisualStyleBackColor = false;
            this.btnDatTruoc.Click += new System.EventHandler(this.btnDatTruoc_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(245, 6);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 43);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "GỌI MÓN";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackColor = System.Drawing.Color.Gray;
            this.btnChuyenBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyenBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChuyenBan.ForeColor = System.Drawing.Color.White;
            this.btnChuyenBan.Location = new System.Drawing.Point(7, 53);
            this.btnChuyenBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(139, 43);
            this.btnChuyenBan.TabIndex = 2;
            this.btnChuyenBan.Text = "CHUYỂN BÀN";
            this.btnChuyenBan.UseVisualStyleBackColor = false;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Firebrick;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(152, 53);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(200, 43);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "THANH TOÁN";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnHuyDat
            // 
            this.btnHuyDat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHuyDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyDat.ForeColor = System.Drawing.Color.White;
            this.btnHuyDat.Location = new System.Drawing.Point(7, 107);
            this.btnHuyDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyDat.Name = "btnHuyDat";
            this.btnHuyDat.Size = new System.Drawing.Size(113, 43);
            this.btnHuyDat.TabIndex = 6;
            this.btnHuyDat.Text = "HỦY ĐẶT";
            this.btnHuyDat.UseVisualStyleBackColor = false;
            this.btnHuyDat.Click += new System.EventHandler(this.btnHuyDat_Click);
            // 
            // UCTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flpActions);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCTable";
            this.Size = new System.Drawing.Size(465, 350);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.flpActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblTimePlay;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTableType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDatTruoc; 
        private System.Windows.Forms.Button btnHuyDat;   
    }
}