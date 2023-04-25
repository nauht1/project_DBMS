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

        private void kháchHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKH frm = new frmQLKH();
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

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonAn frm = new frmMonAn();
            frm.ShowDialog();
        }
    }
}
