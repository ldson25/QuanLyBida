namespace QuanLyBida
{
    partial class UC_LoiVao
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
            this.lblArrow = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.panelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArrow
            // 
            this.lblArrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArrow.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblArrow.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblArrow.Location = new System.Drawing.Point(0, 25);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(71, 56);
            this.lblArrow.TabIndex = 1;
            this.lblArrow.Text = "➡";
            this.lblArrow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LỐI VÀO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBorder
            // 
            this.panelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorder.Controls.Add(this.lblArrow);
            this.panelBorder.Controls.Add(this.lblTitle);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(73, 83);
            this.panelBorder.TabIndex = 0;
            // 
            // UC_LoiVao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelBorder);
            this.Margin = new System.Windows.Forms.Padding(5, 50, 5, 5);
            this.Name = "UC_LoiVao";
            this.Size = new System.Drawing.Size(73, 83);
            this.panelBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBorder;
    }
}