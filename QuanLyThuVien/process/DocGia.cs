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
    public partial class DocGia : Form
    {
        LuaChon lc;
        public DocGia()
        {
            InitializeComponent();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.ĐọcGiả' table. You can move, or remove it, as needed.
            this.đọcGiảTableAdapter.Fill(this.qLTVDataSet.ĐọcGiả);

        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            lc = new LuaChon();
            lc.Show();
            this.Close();
        }
    }
}
