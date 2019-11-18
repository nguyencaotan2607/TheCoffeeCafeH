using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheCoffeeCafe
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        string username = "";
        string pass = "";

        private void log()
        {
            username = txtID.Text;
            pass = txtPW.Text;

            int check = FunctionCheckLogin.kiemTra(username, pass);

            if ( check == 1 )
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                return; 
            }
            else
            {
                this.Hide();
                Form f = new TrangChu(username);
                f.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            log();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    log();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
