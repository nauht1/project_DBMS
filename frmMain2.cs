using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoAnNhanhWP
{
    public partial class frmMain2 : Form
    {
        public frmMain2()
        {
            InitializeComponent();
        }

        private void btnIsNhanVien_Click(object sender, EventArgs e)
        {
            frmLogin frm_Login = new frmLogin();
            frm_Login.ShowDialog();
        }

        private void btnIsKhachHang_Click(object sender, EventArgs e)
        {
            frmMonAn frm_MonAn = new frmMonAn();
            frm_MonAn.ShowDialog();
        }
    }
}
