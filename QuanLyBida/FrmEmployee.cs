using BIDABLL;
using BIDADAL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBida
{
    public partial class FrmEmployee : Form
    {
        private string _imageFileName = "";   
        private bool _isAdd = false;
        private Image _defaultAvatar;
        public FrmEmployee()
        {
            InitializeComponent();
            LoadPosition();
            LoadSchedule();
            LoadEmployees();
            LockControl();
            _defaultAvatar = picImage.Image;
        }

        // LOAD COMBOBOX
        private void LoadPosition()
        {
            string query = "SELECT POSITIONID, POSITIONNAME FROM POSITIONS";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            cboPosition.DataSource = dt;
            cboPosition.DisplayMember = "POSITIONNAME";
            cboPosition.ValueMember = "POSITIONID";
        }

        private void LoadSchedule()
        {
            string query = "SELECT SCHEDULEID, WORKSHIFT FROM WORKSCHEDULES";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            cboSchedule.DataSource = dt;
            cboSchedule.DisplayMember = "WORKSHIFT";
            cboSchedule.ValueMember = "SCHEDULEID";
        }

        private void LoadEmployees()
        {
            dgvEmployees.DataSource = EmployeeBLL.Instance.GetAll();

            dgvEmployees.EnableHeadersVisualStyles = false;

            dgvEmployees.ColumnHeadersVisible = true;

            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEmployees.ColumnHeadersHeight = 45; 

            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmployees.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvEmployees.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dgvEmployees.Columns["EmployeeID"] != null) dgvEmployees.Columns["EmployeeID"].HeaderText = "Mã NV";
            if (dgvEmployees.Columns["FullName"] != null) dgvEmployees.Columns["FullName"].HeaderText = "Họ và Tên";
            if (dgvEmployees.Columns["Gender"] != null) dgvEmployees.Columns["Gender"].HeaderText = "Giới tính";
            if (dgvEmployees.Columns["Phone"] != null) dgvEmployees.Columns["Phone"].HeaderText = "Số ĐT";
            if (dgvEmployees.Columns["Email"] != null) dgvEmployees.Columns["Email"].HeaderText = "Email";
            if (dgvEmployees.Columns["CoefficientSalary"] != null) dgvEmployees.Columns["CoefficientSalary"].HeaderText = "Hệ số lương";
            if (dgvEmployees.Columns["YearStarted"] != null) dgvEmployees.Columns["YearStarted"].HeaderText = "Ngày vào làm";

            if (dgvEmployees.Columns["Images"] != null) dgvEmployees.Columns["Images"].Visible = false;
            if (dgvEmployees.Columns["PositionID"] != null) dgvEmployees.Columns["PositionID"].Visible = false;
            if (dgvEmployees.Columns["ScheduleID"] != null) dgvEmployees.Columns["ScheduleID"].Visible = false;
            if (dgvEmployees.Columns["Identification"] != null) dgvEmployees.Columns["Identification"].Visible = false;
            if (dgvEmployees.Columns["IssuingAuthority"] != null) dgvEmployees.Columns["IssuingAuthority"].Visible = false;
            if (dgvEmployees.Columns["DaysOff"] != null) dgvEmployees.Columns["DaysOff"].Visible = false;

            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // LOCK - UNLOCK
        private void LockControl()
        {
            txtID.Enabled = false;
            txtFullName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtCoefficientSalary.Enabled = false;
            txtDaysOff.Enabled = false;
            txtCCCD.Enabled = false;
            txtPlaceIssued.Enabled = false;
            dtpYearStarted.Enabled = false;
            cboPosition.Enabled = false;
            cboSchedule.Enabled = false;
            radMale.Enabled = false;
            radFemale.Enabled = false;
            btnChangeAvatar.Enabled = false;

            btnSave.Enabled = false;
        }

        private void UnlockControl()
        {
            txtID.Enabled = false;
            txtFullName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtCoefficientSalary.Enabled = true;
            txtDaysOff.Enabled = true;
            txtCCCD.Enabled = true;
            txtPlaceIssued.Enabled = true;
            dtpYearStarted.Enabled = true;
            cboPosition.Enabled = true;
            cboSchedule.Enabled = true;
            radMale.Enabled = true;
            radFemale.Enabled = true;
            btnChangeAvatar.Enabled = true;

            btnSave.Enabled = true;
        }

        // =====================
        // BUTTON: THÊM
        // =====================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _isAdd = true;
            UnlockControl();
            ClearText();

            txtFullName.Focus();
        }

        // Clear input
        private void ClearText()
        {
            txtID.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCoefficientSalary.Clear();
            txtDaysOff.Clear();
            txtCCCD.Clear();
            txtPlaceIssued.Clear();
            radMale.Checked = false;
            radFemale.Checked = false;
            string defaultAvatarPath = Application.StartupPath + @"\Resources\ImageNV\luongduyson.jpg";
            if (File.Exists(defaultAvatarPath))
                picImage.Image = Image.FromFile(defaultAvatarPath);
            else
                picImage.Image = null;

            _imageFileName = "";
        }
        // BUTTON: ĐỔI ẢNH
        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image (*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _imageFileName = Path.GetFileName(ofd.FileName);
                picImage.Image = Image.FromFile(ofd.FileName);

                string dest = Path.Combine(
                    Application.StartupPath,
                    @"..\..\Resources\ImagesNV", 
                    _imageFileName
                );

                string targetDir = Path.GetDirectoryName(dest);
                if (!Directory.Exists(targetDir))
                {
                    Directory.CreateDirectory(targetDir);
                }

                if (!File.Exists(dest))
                {
                    try
                    {
                        File.Copy(ofd.FileName, dest);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi copy ảnh: {ex.Message}");
                    }
                }
            }
        }

        // BUTTON: SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên");
                return;
            }

            int employeeID = 0;
            float coefficientSalary;
            int daysOff;

            if (!float.TryParse(txtCoefficientSalary.Text, out coefficientSalary))
            {
                MessageBox.Show("Hệ số lương không hợp lệ. Vui lòng nhập số.", "Lỗi Định dạng");
                return;
            }
            if (!int.TryParse(txtDaysOff.Text, out daysOff))
            {
                MessageBox.Show("Số ngày nghỉ không hợp lệ. Vui lòng nhập số nguyên.", "Lỗi Định dạng");
                return;
            }

            if (!_isAdd)
            {
                if (!int.TryParse(txtID.Text, out employeeID))
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ.", "Lỗi Định dạng");
                    return;
                }
            }
            EmployeeDTO emp = new EmployeeDTO()
            {
                EmployeeID = employeeID, 
                FullName = txtFullName.Text,
                Gender = radMale.Checked ? "Nam" : "Nữ",
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Images = _imageFileName,
                PositionID = (int)cboPosition.SelectedValue,
                ScheduleID = (int)cboSchedule.SelectedValue,
                CoefficientSalary = coefficientSalary, 
                DaysOff = daysOff,                     
                YearStarted = dtpYearStarted.Value,
                Identification = txtCCCD.Text,
                IssuingAuthority = txtPlaceIssued.Text
            };

            bool success = false;
            if (_isAdd)
            {
                success = EmployeeBLL.Instance.Insert(emp);
                if (success) MessageBox.Show("Thêm thành công!");
            }
            else
            {
                success = EmployeeBLL.Instance.Update(emp);
                if (success) MessageBox.Show("Cập nhật thành công!");
            }

            if (success)
            {
                LoadEmployees();
                LockControl();
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgvEmployees.Rows[e.RowIndex];

            txtID.Text = r.Cells["EmployeeID"].Value.ToString();
            txtFullName.Text = r.Cells["FullName"].Value.ToString();
            txtPhone.Text = r.Cells["Phone"].Value.ToString();
            txtEmail.Text = r.Cells["Email"].Value.ToString();
            txtCoefficientSalary.Text = r.Cells["CoefficientSalary"].Value.ToString();
            txtDaysOff.Text = r.Cells["DaysOff"].Value.ToString();
            txtCCCD.Text = r.Cells["Identification"].Value.ToString();
            txtPlaceIssued.Text = r.Cells["IssuingAuthority"].Value.ToString();

            dtpYearStarted.Value = Convert.ToDateTime(r.Cells["YearStarted"].Value);

            string gender = r.Cells["Gender"].Value.ToString();
            radMale.Checked = gender == "Nam";
            radFemale.Checked = gender == "Nữ";

            cboPosition.SelectedValue = r.Cells["PositionID"].Value;
            cboSchedule.SelectedValue = r.Cells["ScheduleID"].Value;

            // Hình ảnh
            string img = r.Cells["Images"].Value?.ToString();
            _imageFileName = img;

            string folder = Path.Combine(Application.StartupPath, "Resources", "ImageNV");
            string imgPath = Path.Combine(folder, img ?? "");

            if (!string.IsNullOrEmpty(img) && File.Exists(imgPath))
            {
                picImage.Image = Image.FromFile(imgPath);
            }
            else
            {
                picImage.Image = _defaultAvatar;   
            }
        }
        // BUTTON: EDIT
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            _isAdd = false;
            UnlockControl();
            txtID.Enabled = false;
        }
        // BUTTON: DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Chọn nhân viên để xóa!");
                return;
            }

            int id = int.Parse(txtID.Text);

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (EmployeeBLL.Instance.Delete(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadEmployees();
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
