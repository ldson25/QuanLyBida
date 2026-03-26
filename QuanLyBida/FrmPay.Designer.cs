namespace QuanLyBida
{
    partial class FrmPay
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
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTableFee = new System.Windows.Forms.Label();
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboPromotion = new System.Windows.Forms.ComboBox(); 
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustomerMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSurcharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFoodFee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.AllowUserToAddRows = false;
            this.dgvBillDetails.AllowUserToDeleteRows = false;
            this.dgvBillDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillDetails.ColumnHeadersHeight = 30;
            this.dgvBillDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBillDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.ReadOnly = true;
            this.dgvBillDetails.RowHeadersVisible = false;
            this.dgvBillDetails.RowTemplate.Height = 30;
            this.dgvBillDetails.Size = new System.Drawing.Size(900, 300);
            this.dgvBillDetails.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTableFee);
            this.groupBox1.Controls.Add(this.lblPlayTime);
            this.groupBox1.Controls.Add(this.lblTableName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bàn";
            // 
            // lblTableFee
            // 
            this.lblTableFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTableFee.ForeColor = System.Drawing.Color.Blue;
            this.lblTableFee.Location = new System.Drawing.Point(150, 140);
            this.lblTableFee.Name = "lblTableFee";
            this.lblTableFee.Size = new System.Drawing.Size(200, 25);
            this.lblTableFee.TabIndex = 5;
            this.lblTableFee.Text = "0 đ";
            this.lblTableFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPlayTime.Location = new System.Drawing.Point(150, 90);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(200, 25);
            this.lblPlayTime.TabIndex = 4;
            this.lblPlayTime.Text = "00:00:00";
            this.lblPlayTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTableName
            // 
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTableName.Location = new System.Drawing.Point(150, 40);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(200, 25);
            this.lblTableName.TabIndex = 3;
            this.lblTableName.Text = "Bàn ?";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền giờ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian chơi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bàn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboPromotion);
            this.groupBox2.Controls.Add(this.txtChange);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCustomerMoney);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblTotalAmount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDiscount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSurcharge);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblFoodFee);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.Location = new System.Drawing.Point(410, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 400);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Toán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "CT Khuyến Mãi:";
            // 
            // cboPromotion
            // 
            this.cboPromotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPromotion.FormattingEnabled = true;
            this.cboPromotion.Location = new System.Drawing.Point(180, 137);
            this.cboPromotion.Name = "cboPromotion";
            this.cboPromotion.Size = new System.Drawing.Size(250, 25);
            this.cboPromotion.TabIndex = 12;
            this.cboPromotion.SelectedIndexChanged += new System.EventHandler(this.cboPromotion_SelectedIndexChanged);
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtChange.Location = new System.Drawing.Point(180, 340);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(250, 29);
            this.txtChange.TabIndex = 11;
            this.txtChange.Text = "0";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tiền thừa:";
            // 
            // txtCustomerMoney
            // 
            this.txtCustomerMoney.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCustomerMoney.Location = new System.Drawing.Point(180, 290);
            this.txtCustomerMoney.Name = "txtCustomerMoney";
            this.txtCustomerMoney.Size = new System.Drawing.Size(250, 29);
            this.txtCustomerMoney.TabIndex = 9;
            this.txtCustomerMoney.Text = "0";
            this.txtCustomerMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Khách đưa:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(180, 240);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(250, 35);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "0 đ";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "TỔNG TIỀN:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(180, 180);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(250, 25);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giảm trừ (số tiền):";
            // 
            // txtSurcharge
            // 
            this.txtSurcharge.Location = new System.Drawing.Point(180, 90);
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(250, 25);
            this.txtSurcharge.TabIndex = 3;
            this.txtSurcharge.Text = "0";
            this.txtSurcharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phụ thu:";
            // 
            // lblFoodFee
            // 
            this.lblFoodFee.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFoodFee.Location = new System.Drawing.Point(180, 40);
            this.lblFoodFee.Name = "lblFoodFee";
            this.lblFoodFee.Size = new System.Drawing.Size(250, 25);
            this.lblFoodFee.TabIndex = 1;
            this.lblFoodFee.Text = "0 đ";
            this.lblFoodFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiền dịch vụ:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LightGreen;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPay.Location = new System.Drawing.Point(260, 730);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(200, 50);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(480, 730);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBillDetails);
            this.Name = "FrmPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBillDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTableFee;
        private System.Windows.Forms.Label lblPlayTime;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustomerMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSurcharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFoodFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboPromotion; 
    }
}