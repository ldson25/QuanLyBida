namespace QuanLyBida
{
    partial class FrmSwitchTable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cbBanMoi = new System.Windows.Forms.ComboBox();
            this.lblFromTable = new System.Windows.Forms.Label();
            this.lblBanCu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.cbBanMoi);
            this.panel1.Controls.Add(this.lblFromTable);
            this.panel1.Controls.Add(this.lblBanCu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 153);
            this.panel1.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(200, 103);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 35);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(61, 103);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 35);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cbBanMoi
            // 
            this.cbBanMoi.FormattingEnabled = true;
            this.cbBanMoi.Location = new System.Drawing.Point(145, 56);
            this.cbBanMoi.Name = "cbBanMoi";
            this.cbBanMoi.Size = new System.Drawing.Size(121, 24);
            this.cbBanMoi.TabIndex = 2;
            // 
            // lblFromTable
            // 
            this.lblFromTable.AutoSize = true;
            this.lblFromTable.Location = new System.Drawing.Point(67, 64);
            this.lblFromTable.Name = "lblFromTable";
            this.lblFromTable.Size = new System.Drawing.Size(57, 16);
            this.lblFromTable.TabIndex = 1;
            this.lblFromTable.Text = "Đến bàn";
            // 
            // lblBanCu
            // 
            this.lblBanCu.AutoSize = true;
            this.lblBanCu.Location = new System.Drawing.Point(33, 20);
            this.lblBanCu.Name = "lblBanCu";
            this.lblBanCu.Size = new System.Drawing.Size(91, 16);
            this.lblBanCu.TabIndex = 0;
            this.lblBanCu.Text = "Chuyển từ bàn";
            // 
            // FrmSwitchTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSwitchTable";
            this.Text = "FrmSwitchTable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cbBanMoi;
        private System.Windows.Forms.Label lblFromTable;
        private System.Windows.Forms.Label lblBanCu;
        private System.Windows.Forms.Button btnHuy;
    }
}