using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.process
{
    public partial class LuaChon : Form
    {
        public LuaChon()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn chắc chắn muốn thoát không .", "Thông Báo", MessageBoxButtons.OKCancel);
            if (t == DialogResult.OK)
                Application.Exit();
        }
    }
}
