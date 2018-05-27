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

namespace quanlibanhangaoquan
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        string ketnoi = "Data Source = ADMINISTRATOR\\SQLEXPRESS; Initial Catalog = Quanlibanhangaoquan; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(ketnoi);
            string SQL = "Select * from TAIKHOAN where TenTaiKhoan = N'" + txtTaiKhoandn.Text.Trim() + "'and MatKhau =N'" + txtMatKhaudn.Text.Trim() + "'";
            cmd = new SqlCommand(SQL, cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 fp = new Form2();
                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
