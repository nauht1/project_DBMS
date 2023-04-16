using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoAnNhanhWP
{
    public partial class frmGioHang : Form
    {
        string sqlStringConnection = "Data Source = DESKTOP-ACER\\NAUHTSQLSERVER; " +
                "Initial Catalog = QLCuaHangDoAnNhanh; " +
                "User ID = sa; Password = 281003";
        public frmGioHang()
        {
            InitializeComponent();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new frmQLDHTrucTuyen();
            frm.ShowDialog();
        }

        private void frmGioHang_Load(object sender, EventArgs e)
        {
            dgvGioHang.Columns["TenMonAn"].ReadOnly = true;
            dgvGioHang.Columns["DonGia"].ReadOnly = true;
            dgvGioHang.Columns["SoLuongMua"].ReadOnly = false;
            dgvGioHang.Columns["ThanhTien"].ReadOnly = true;
            dgvGioHang.CellEndEdit += DgvGioHang_CellEndEdit;
            tinhTongTien(dgvGioHang);
        }

        private void DgvGioHang_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
        }

        public void tinhTongTien(DataGridView dgvGioHang)
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                decimal thanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                tongTien += thanhTien;
            }
            txtTongTien.Text = tongTien.ToString();
            txtTongTien.Font = new Font(txtTongTien.Font, FontStyle.Bold);
        }

    }
}
