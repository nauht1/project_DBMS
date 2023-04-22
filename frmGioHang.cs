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
        private int rowIndex;
        public frmGioHang()
        {
            InitializeComponent();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new frmDHTrucTuyen();
            frm.ShowDialog();
        }

        private void frmGioHang_Load(object sender, EventArgs e)
        {
            dgvGioHang.Columns["TenMonAn"].ReadOnly = true;
            dgvGioHang.Columns["DonGia"].ReadOnly = true;
            dgvGioHang.Columns["SoLuongMua"].ReadOnly = false;
            dgvGioHang.Columns["ThanhTien"].ReadOnly = true;
            dgvGioHang.CellEndEdit += new DataGridViewCellEventHandler(dgvGioHang_CellEndEdit);
            tinhTongTien(dgvGioHang);
        }
        public void tinhTongTien(DataGridView dgvGioHang)
        {
            float tongTien = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                float thanhTien = float.Parse(row.Cells["ThanhTien"].Value.ToString());
                tongTien += thanhTien;
            }
            txtTongTien.Text = tongTien.ToString();
            txtTongTien.Font = new Font(txtTongTien.Font, FontStyle.Bold);
        }

        private void dgvGioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGioHang.Columns[e.ColumnIndex].Name == "SoLuongMua")
            {
                int soLuong = Convert.ToInt32(dgvGioHang.Rows[e.RowIndex].Cells["SoLuongMua"].Value);
                float donGia = float.Parse(dgvGioHang.Rows[e.RowIndex].Cells["DonGia"].Value.ToString());
                float thanhTien = soLuong * donGia;
                dgvGioHang.Rows[e.RowIndex].Cells["ThanhTien"].Value = thanhTien;
            }
            tinhTongTien(dgvGioHang);
        }

        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Thứ tự dòng hiện hành 
            int r = dgvGioHang.CurrentCell.RowIndex;
            rowIndex = e.RowIndex;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvGioHang.Rows[rowIndex];
                dgvGioHang.Rows.Remove(row);
            }
        }
    }
}
