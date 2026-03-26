using BIDABLL;
using BIDADAL;
using BIDADTO;
using QuanLyBida;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyBida
{
    public partial class fLogin : Form
    {
        AccountBLL accountBLL = new AccountBLL();

        public fLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string passRaw = txtPassword.Text; 

            string passEncrypted = SecurityHelper.Encrypt(passRaw, SecurityHelper.PUBLIC_KEY);

            if (accountBLL.Login(user, passEncrypted))
            {
                Account acc = accountBLL.GetAccountByUserName(user);
                FrmMain main = new FrmMain(acc);
                this.Hide();
                main.ShowDialog();

                if (!this.IsDisposed)
                {
                    this.Show();
                    txtPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
