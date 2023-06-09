﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoAnNhanhWP
{
    public partial class frmMonAn : Form
    {
        public static List<MonAn> gioHang = new List<MonAn>();
        List<MonAn> danhSachMonAn = new List<MonAn>();
        public List<MonAn> DanhSachMonAn
        {
            get { return danhSachMonAn; }   
        }
        PictureBox pbMonAn = null;
        Label lb_tenMonAn = null;
        Label lb_moTaMonAn = null;
        Label lb_soLuongDuTruBan = null;
        Label lb_donGia = null;
        Label lb_donGiaMoi = null;
        Panel pn = null;
        Button btnThemGioHang = null;
        Button btnDatHang = null;
        MonAn monAn = null;
        public frmMonAn()
        {
            InitializeComponent();
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            LoadMonAn();
            int index = 0;
            foreach (MonAn monAn in danhSachMonAn)
            {
                PictureBox pbMonAn = new PictureBox();
                Label lb_tenMonAn = new Label();
                Label lb_moTaMonAn = new Label();
                Label lb_soLuongDuTruBan = new Label();
                Label lb_donGia = new Label();
                Label lb_donGiaMoi = new Label();
                Panel pn = new Panel();
                Button btnThemGioHang = new Button();
                Button btnDatHang = new Button();
                pn.BorderStyle = BorderStyle.FixedSingle;
                pn.Width = 250;
                pn.Height = 340;

                pbMonAn.Image = Image.FromFile(monAn.HinhAnh);
                pbMonAn.Location = new Point(10, 10);
                pbMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
                pbMonAn.Width = 230;
                pbMonAn.Height = 120;

                lb_tenMonAn.Text = monAn.TenMonAn;
                lb_moTaMonAn.Text = monAn.MoTa;
                lb_soLuongDuTruBan.Text = "Còn lại: " + monAn.SoLuongDuTru.ToString();
                lb_donGia.Text = monAn.DonGia.ToString() + " VND";
                //lb_donGiaMoi.Text = "Giá mới (để tạm)";

                lb_tenMonAn.Location = new Point(10, 140);
                lb_tenMonAn.AutoSize = true;
                lb_tenMonAn.Font = new Font(lb_tenMonAn.Font, FontStyle.Bold);

                lb_moTaMonAn.Location = new Point(10, 160);
                lb_moTaMonAn.AutoSize = true;
                lb_moTaMonAn.Font = new Font(lb_moTaMonAn.Font, FontStyle.Italic);
                lb_moTaMonAn.MaximumSize = new Size(240, 100);

                lb_soLuongDuTruBan.Location = new Point(10, 260);
                lb_soLuongDuTruBan.AutoSize = true;

                lb_donGia.Location = new Point(10, 280);
                lb_donGia.AutoSize = true;
                lb_donGia.Font = new Font(lb_donGia.Font, FontStyle.Bold);

                lb_donGiaMoi.Location = new Point(10, 300);
                lb_donGiaMoi.AutoSize = true;
                lb_donGiaMoi.Font = new Font(lb_donGiaMoi.Font, FontStyle.Bold);

                btnThemGioHang.Text = "Thêm vào giỏ";
                btnThemGioHang.Size = new Size(100, 30);
                btnThemGioHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                btnThemGioHang.Location = new Point(pn.Width - btnThemGioHang.Width - 5, pn.Height - btnThemGioHang.Height * 2 - 5);
                btnThemGioHang.BackColor = Color.OrangeRed;
                btnThemGioHang.TabIndex = index;
                btnThemGioHang.Click += BtnThemGioHang_Click;

                btnDatHang.Text = "Đặt hàng";
                btnDatHang.Size = new Size(100, 30);
                btnDatHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                btnDatHang.Location = new Point(pn.Width - btnDatHang.Width - 5, pn.Height - btnDatHang.Height - 5);
                btnDatHang.Click += BtnDatHang_Click;
                btnDatHang.TabIndex = index;

                pn.Controls.Add(lb_tenMonAn);
                pn.Controls.Add(lb_moTaMonAn);
                pn.Controls.Add(lb_soLuongDuTruBan);
                pn.Controls.Add(lb_donGia);
                pn.Controls.Add(lb_donGiaMoi);
                pn.Controls.Add(pbMonAn);
                pn.Controls.Add(btnThemGioHang);
                pn.Controls.Add(btnDatHang);
                flpMonAn.Controls.Add(pn);

                index++;
            }
        }
        public void LoadMonAn()
        {
            string strConn = ClassConnection.GetKH_ConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM view_DanhSachMonAnCon", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MonAn monAn = new MonAn();
                    monAn.MaMonAn = reader["MaMonAn"].ToString();
                    monAn.MaNguoiTao = reader["MaNguoiTao"].ToString();
                    monAn.TenMonAn = reader["TenMonAn"].ToString();
                    monAn.MoTa = reader["MoTa"].ToString();
                    monAn.DonGia = (float)reader["DonGia"];
                    monAn.SoLuongDuTru = (int)reader["SoLuongDuTru"];
                    monAn.HinhAnh = reader["HinhAnh"].ToString();
                    danhSachMonAn.Add(monAn);
                }
                reader.Close();
            }
        }
        private void BtnDatHang_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            var index = Convert.ToInt32(btn.TabIndex);
            MonAn monAn = new MonAn();
            monAn = danhSachMonAn[index];
            monAn.SoLuongDuTru = 1;
            gioHang.Add(monAn);
            frmDHTrucTuyen frm = new frmDHTrucTuyen();
            frm.ShowDialog();
        }
        private void BtnThemGioHang_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            var index = Convert.ToInt32(btn.TabIndex);

            MonAn monAn = new MonAn();
            monAn = danhSachMonAn[index];
            if (gioHang.Find(ma => ma.MaMonAn == monAn.MaMonAn) != null)
            {
                gioHang.Find(ma => ma.MaMonAn == monAn.MaMonAn).SoLuongDuTru += 1;
            }
            else
            {
                monAn.SoLuongDuTru = 1;
                gioHang.Add(monAn);
            }
            MessageBox.Show("Thêm vào giỏ hàng thành công!");
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            frmGioHang frmGioHang = new frmGioHang();
            DataGridView dgv_gioHang = frmGioHang.dgvGioHang;
            foreach (var item in gioHang)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TenMonAn });
                row.Cells.Add(new DataGridViewImageCell { Value = Image.FromFile(item.HinhAnh) });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.SoLuongDuTru });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.DonGia });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.DonGia * item.SoLuongDuTru });

                dgv_gioHang.Rows.Add(row);
            }
            (dgv_gioHang.Columns["HinhAnh"] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgv_gioHang.AllowUserToAddRows = false;
            dgv_gioHang.RowTemplate.Height = 50;

            frmGioHang.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
