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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNV frm = new frmQLNV();
            frm.ShowDialog();
        }

        private void khoNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapNguyenLieu frm = new frmNhapNguyenLieu();
            frm.ShowDialog();
        }

        private void mónĂnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLMonAn frm = new frmQLMonAn();
            frm.ShowDialog();
        }

        private void quảnLýĐơnTrựcTiếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDHTrucTiep frm = new frmQLDHTrucTiep();
            frm.ShowDialog();
        }

        private void quảnLýĐơnTrựcTuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDHTrucTuyen frm = new frmQLDHTrucTuyen();
            frm.ShowDialog();
        }

        private void xemKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKH frm = new frmQLKH();
            frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan frm = new frmThongTinCaNhan();
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void xemĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDH frm = new frmQLDH();
            frm.ShowDialog();
        }

        private void xemChiTiếtĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCTDH frm = new frmCTDH();
            frm.ShowDialog();
        }
    }
}
