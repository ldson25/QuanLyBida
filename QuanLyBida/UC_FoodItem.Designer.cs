namespace QuanLyBida
{
    partial class UC_FoodItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picFood = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(24, 12);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(68, 43);
            this.picFood.TabIndex = 0;
            this.picFood.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên Món:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(21, 102);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(60, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá Món:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aqua;
            this.btnAdd.Location = new System.Drawing.Point(24, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 41);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm Món";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UC_FoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picFood);
            this.Name = "UC_FoodItem";
            this.Size = new System.Drawing.Size(192, 185);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
    }
}
