using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace qlpk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1FK03R5\SQLEXPRESS;Initial Catalog=bv2;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = textBox2.Text;
                string mk = textBox3.Text;
                string sql = "Select * from NguoiDung where TaiKhoan='" + tk + "'and MatKhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // về trang chính
                    Doctorqt formMain = new Doctorqt();
                    formMain.Show();
                    this.Hide();
                 
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối vui lòng thử lại");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận hủy bỏ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }
    }
}
