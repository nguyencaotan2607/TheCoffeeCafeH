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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IRDHT22H;Initial Catalog=KhachHang;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable data = new DataTable();

        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from MaKhachHang";
            adapter.SelectCommand = cmd;
            data.Clear();
            adapter.Fill(data);

        }
        private void lbName_Click(object sender, EventArgs e)
        {

        }
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into MaKhachHang values('"+txtName.Text+"','"+txtPhone.Text+"')";
            cmd.ExecuteNonQuery();
            loaddata();
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
