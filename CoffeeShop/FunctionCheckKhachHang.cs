using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TheCoffeeCafe
{
    public class FunctionCheckKhachHang
    {
        public static bool kiemtra(string khachHang)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IRDHT22H;Initial Catalog=KhachHang;Integrated Security=True");
            conn.Open();
            string sql = "select * from MaKhachHang where MKH= '"+khachHang+"'";
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read() == true)
            {
                return true;
            }
            return false;
        }
    }
}
