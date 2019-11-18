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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        public TrangChu(string TenKhachHang):this()
        {
            lbName.Text = "Xin chào: " + TenKhachHang;
        }

        private void Close()
        {
            DialogResult kq = new DialogResult();
            kq = MessageBox.Show("Bạn có muốn đóng ứng dụng?", "XÁC NHẬN", MessageBoxButtons.OKCancel);
            if (kq == DialogResult.OK)
                Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TrangChuLoad(object sender, EventArgs e)
        {
            lvKq.Columns.Add("Số Bàn", 100);
            lvKq.Columns.Add("Tên thức uống", 180);
            lvKq.Columns.Add("Đơn giá (VNĐ)", 400);
            cbbMenu.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string choose = cbbMenu.SelectedItem.ToString();

            int so = int.Parse(cbbMenu.SelectedIndex.ToString());

            int soban = rd1.Checked ? 1 : rd2.Checked ? 2 : rd3.Checked ? 3 : rd4.Checked ? 4 : rd5.Checked ? 5 : rd6.Checked ? 6 : 0;
            
            bool check = FunctionCheckHome.kiemTraBan(soban);

            if ( check )
            {
                ListViewItem item = new ListViewItem(rd1.Checked ? "1" : rd2.Checked ? "2" : rd3.Checked ? "3" : rd4.Checked ? "4" : rd5.Checked ? "5" : "6");
                item.SubItems.Add(choose);
                item.SubItems.Add(so == 0 ? "25000" : so == 1 ? "35000" : so == 2 ? "20000" : so == 3 ? "10000" :"20000");
                lvKq.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Bạn Vui Lòng chọn bàn!", "CẢNH BÁO");
                return;
            }
                
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int c = lvKq.SelectedItems.Count;
            bool check = FunctionCheckHome.kiemTraDel(c);
            if (!check)
            {
                MessageBox.Show("Bạn Chưa chọn bàn cần xóa!","CẢNH BÁO");
                return;
            }
            else
            {
                foreach (ListViewItem item in lvKq.SelectedItems)
                    lvKq.Items.Remove(item);
                MessageBox.Show("Thành công!","THÔNG BÁO");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int data = lvKq.Items.Count;
            bool check = FunctionCheckHome.kiemTraListView(data);

            if (check)
            {
                ListView listCopy = new ListView();
                listCopy = lvKq;
                ThanhToan newFrm = new ThanhToan(listCopy);
                newFrm.Show();
            }
            else
            {
                MessageBox.Show("Danh Sách Trống!\nBạn Hãy vui lòng thêm thức uống vào danh sách!", "CẢNH BÁO");
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult kq = new DialogResult();
            kq = MessageBox.Show("Bạn có đồng ý xóa các thức uống đã chọn?\nN Chọn OK để thực hiện!","CẢNH BÁO",MessageBoxButtons.OKCancel);
            if (kq == DialogResult.OK)
                lvKq.Items.Clear();
        }

        private void lvKq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
