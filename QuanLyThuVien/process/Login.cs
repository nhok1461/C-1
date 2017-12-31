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

namespace QuanLyThuVien.process
{
    public partial class Login : Form
    {
        LuaChon lc;
        string strConnection = "Data Source=DESKTOP-UE6SHMV;Initial Catalog=QLTV;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select Count(*) From QLTV.dbo.Login Where [User]=@acc And Password=@pass";
                conn = new SqlConnection(strConnection);
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@acc", txtTaiKhoan.Text));
                command.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
                int n = (int)command.ExecuteScalar();
                if (n == 1)
                {//login success
                    lbCorrect.Text = "Đăng nhập thành công.";
                    this.Hide();
                    lc = new LuaChon();
                    lc.Show();
                }
                else
                {//login fail
                    lbCorrect.Text = "Tài khoản hoặc mật khẩu không hợp lệ.";
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();//đưa nháy chuột về vị trí tài khoản nếu sai
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowpass.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
