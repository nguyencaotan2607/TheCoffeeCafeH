using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheCoffeeCafe
{
    public partial class ThanhToan : Form
    {
        private ListView lvFrmMain;

        
        public ThanhToan()
        {
            InitializeComponent();
        }

        public ThanhToan(ListView lvkQ):this()
        {
            this.lvFrmMain = lvkQ;
        }

        private void AppClose()
        {
            DialogResult kq = new DialogResult();
            kq = MessageBox.Show("Bạn có muốn đóng cửa sổ Thanh Toán?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (kq == DialogResult.OK)
                this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppClose();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int soban = int.Parse(rd1.Checked ? "1" : rd2.Checked ? "2" : rd3.Checked ? "3" : rd4.Checked ? "4" : rd5.Checked ? "5" : rd6.Checked ? "6" : "0");
            int tien = 0;

            if (soban == 0)
            {
                lbShow.Text = "CHƯA CHỌN BÀN";
                return;
            }
            else
            {
                for (int i = 0; i < int.Parse(lvFrmMain.Items.Count.ToString()); i++)
                    if (soban == int.Parse(lvFrmMain.Items[i].SubItems[0].Text))
                        tien += int.Parse(lvFrmMain.Items[i].SubItems[2].Text);
            }

            if (tien != 0)
            {
                if (txtKhtt.Text != "")
                {
                    string kt = txtKhtt.Text;
                    bool check = FunctionCheckKhachHang.kiemtra(kt);
                    if (check == false)
                    {
                        MessageBox.Show("Mã KHTT không hợp lệ", "CẢNH BÁO");
                        return;
                    }
                    else
                    {
                        double tong = (tien * 95 / 100);
                        lbShow.Text = tong.ToString() + "đ";
                        MessageBox.Show("Tích điểm thành công.\nMã KHTT: " + txtKhtt.Text + "\nĐã giảm giá 5% trên tổng hóa đơn.", "Thông báo");
                    }
                 
                }
                else
                    lbShow.Text = tien.ToString() + "đ";
            }
            else
                lbShow.Text = "BÀN TRỐNG";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKhtt.Clear();
            lbShow.Text = "0đ";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    AppClose();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new AddCustomer();
            f.Show();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            as 
        }




    }
}
