namespace QuanLyBida
{
    partial class FrmEmployee
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnChangeAvatar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSchedule = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpYearStarted = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCoefficientSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDaysOff = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlaceIssued = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.panelLeft.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.groupBoxInfo);
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(450, 761);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.picImage);
            this.groupBoxInfo.Controls.Add(this.btnChangeAvatar);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Controls.Add(this.txtID);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.txtFullName);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Controls.Add(this.txtPhone);
            this.groupBoxInfo.Controls.Add(this.label4);
            this.groupBoxInfo.Controls.Add(this.txtEmail);
            this.groupBoxInfo.Controls.Add(this.label5);
            this.groupBoxInfo.Controls.Add(this.radMale);
            this.groupBoxInfo.Controls.Add(this.radFemale);
            this.groupBoxInfo.Controls.Add(this.label6);
            this.groupBoxInfo.Controls.Add(this.cboPosition);
            this.groupBoxInfo.Controls.Add(this.label7);
            this.groupBoxInfo.Controls.Add(this.cboSchedule);
            this.groupBoxInfo.Controls.Add(this.label8);
            this.groupBoxInfo.Controls.Add(this.dtpYearStarted);
            this.groupBoxInfo.Controls.Add(this.label9);
            this.groupBoxInfo.Controls.Add(this.txtCoefficientSalary);
            this.groupBoxInfo.Controls.Add(this.label10);
            this.groupBoxInfo.Controls.Add(this.txtDaysOff);
            this.groupBoxInfo.Controls.Add(this.label11);
            this.groupBoxInfo.Controls.Add(this.txtCCCD);
            this.groupBoxInfo.Controls.Add(this.label12);
            this.groupBoxInfo.Controls.Add(this.txtPlaceIssued);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(420, 650);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông Tin Nhân Viên";
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.Gainsboro;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(140, 30);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(120, 120);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangeAvatar.Location = new System.Drawing.Point(270, 115);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(75, 35);
            this.btnChangeAvatar.TabIndex = 1;
            this.btnChangeAvatar.Text = "Đổi Ảnh";
            this.btnChangeAvatar.UseVisualStyleBackColor = true;
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(20, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.Location = new System.Drawing.Point(120, 165);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(280, 30);
            this.txtID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(20, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ Tên:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(120, 205);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(280, 30);
            this.txtFullName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(20, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "SĐT:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(120, 245);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(280, 30);
            this.txtPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(20, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(120, 285);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 30);
            this.txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(20, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giới tính:";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radMale.Location = new System.Drawing.Point(120, 330);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(62, 24);
            this.radMale.TabIndex = 11;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radFemale.Location = new System.Drawing.Point(200, 330);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(50, 24);
            this.radFemale.TabIndex = 12;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(20, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Chức vụ:";
            // 
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(120, 365);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(280, 31);
            this.cboPosition.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(20, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ca làm:";
            // 
            // cboSchedule
            // 
            this.cboSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSchedule.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSchedule.FormattingEnabled = true;
            this.cboSchedule.Location = new System.Drawing.Point(120, 405);
            this.cboSchedule.Name = "cboSchedule";
            this.cboSchedule.Size = new System.Drawing.Size(280, 31);
            this.cboSchedule.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(20, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày vào làm:";
            // 
            // dtpYearStarted
            // 
            this.dtpYearStarted.CustomFormat = "dd/MM/yyyy";
            this.dtpYearStarted.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpYearStarted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYearStarted.Location = new System.Drawing.Point(130, 445);
            this.dtpYearStarted.Name = "dtpYearStarted";
            this.dtpYearStarted.Size = new System.Drawing.Size(270, 30);
            this.dtpYearStarted.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(20, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hệ số lương:";
            // 
            // txtCoefficientSalary
            // 
            this.txtCoefficientSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCoefficientSalary.Location = new System.Drawing.Point(120, 485);
            this.txtCoefficientSalary.Name = "txtCoefficientSalary";
            this.txtCoefficientSalary.Size = new System.Drawing.Size(280, 30);
            this.txtCoefficientSalary.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(20, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ngày nghỉ:";
            // 
            // txtDaysOff
            // 
            this.txtDaysOff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDaysOff.Location = new System.Drawing.Point(120, 525);
            this.txtDaysOff.Name = "txtDaysOff";
            this.txtDaysOff.Size = new System.Drawing.Size(280, 30);
            this.txtDaysOff.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(20, 570);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "CCCD:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCCCD.Location = new System.Drawing.Point(120, 565);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(280, 30);
            this.txtCCCD.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.Location = new System.Drawing.Point(20, 610);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Nơi cấp:";
            // 
            // txtPlaceIssued
            // 
            this.txtPlaceIssued.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlaceIssued.Location = new System.Drawing.Point(120, 605);
            this.txtPlaceIssued.Name = "txtPlaceIssued";
            this.txtPlaceIssued.Size = new System.Drawing.Size(280, 30);
            this.txtPlaceIssued.TabIndex = 26;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 681);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(450, 80);
            this.panelButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(95, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(180, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(265, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(350, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dgvEmployees);
            this.panelRight.Controls.Add(this.labelTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(450, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(732, 761);
            this.panelRight.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelTitle.Location = new System.Drawing.Point(10, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(712, 50);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DANH SÁCH NHÂN VIÊN";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.ColumnHeadersHeight = 40;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.Location = new System.Drawing.Point(10, 60);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmployees.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.RowTemplate.Height = 30;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(712, 691);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 761);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.panelLeft.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnChangeAvatar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSchedule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpYearStarted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCoefficientSalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDaysOff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPlaceIssued;
        private System.Windows.Forms.Label label12;
    }
}