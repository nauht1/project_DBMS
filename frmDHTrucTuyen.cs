using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoAnNhanhWP
{
    public partial class frmDHTrucTuyen : Form
    {
        DataTable dt = null;
        public frmDHTrucTuyen()
        {
            InitializeComponent();
        }
        private void frmQLDHTrucTuyen_Load(object sender, EventArgs e)
        {
            dgvMonAn.Columns["STT"].ReadOnly = true;
            dgvMonAn.Columns["TenMon"].ReadOnly = true;
            dgvMonAn.Columns["SoLuong"].ReadOnly = false;
            dgvMonAn.Columns["DonGia"].ReadOnly = true;

            dgvMonAn.Columns["MaMon"].Visible = false;
            dgvMonAn.CellEndEdit += new DataGridViewCellEventHandler(dgvMonAn_CellEndEdit);
            tinhTongTien(dgvMonAn);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMonAn_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMonAn.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                int soLuong = Convert.ToInt32(dgvMonAn.Rows[e.RowIndex].Cells["SoLuong"].Value);
                float donGia = float.Parse(dgvMonAn.Rows[e.RowIndex].Cells["DonGia"].Value.ToString());
                float thanhTien = soLuong * donGia;
                dgvMonAn.Rows[e.RowIndex].Cells["ThanhTien"].Value = thanhTien;
            }
            tinhTongTien(dgvMonAn);
        }
        public void tinhTongTien(DataGridView dgvMonAn)
        {
            float tongTien = 0;
            foreach (DataGridViewRow row in dgvMonAn.Rows)
            {
                float thanhTien = float.Parse(row.Cells["ThanhTien"].Value.ToString());
                tongTien += thanhTien;
            }
            txtTongTien.Text = tongTien.ToString();
            txtTongTien.Font = new Font(txtTongTien.Font, FontStyle.Bold);
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            bool check;
            check = DatHangTrucTuyen();
            if (check)
            {
                MessageBox.Show("Đã đặt hàng thành công!");
            }
        }
        public bool DatHangTrucTuyen()
        {
            string maKhachHang = GeneralMethod.LayMaTuDong("KhachHang", "MaKhachhang");
            string maDonHang = GeneralMethod.LayMaTuDong("DonHang", "MaDonHang");
            try
            {
                using (SqlConnection conn = ClassConnection.Connection)
                {
                    //mã nv để tạm, sẽ dùng hàm cập nhật để chọn nhân viên
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("sp_TaoDonHangTrucTuyen", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
                    cmd1.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = txtHoTen.Text;
                    cmd1.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                    cmd1.Parameters.Add("@soDienThoai", SqlDbType.VarChar).Value = txtDienThoai.Text;
                    cmd1.Parameters.Add("@maDonHang", SqlDbType.VarChar).Value = maDonHang;
                    cmd1.Parameters.Add("@ngayTaoDon", SqlDbType.Date).Value = DateTime.Now.Date.ToString();
                    cmd1.Parameters.Add("maNhanVienBan", SqlDbType.VarChar).Value = "NV008";
                    cmd1.Parameters.Add("@hinhThucThanhToan", SqlDbType.NVarChar).Value = cboThanhToan.SelectedItem.ToString();
                    cmd1.Parameters.Add("@tongTien", SqlDbType.Int).Value = Convert.ToInt32(txtTongTien.Text);
                    cmd1.Parameters.Add("maNhanVienGiao", SqlDbType.VarChar).Value = "NV001"; 
                    cmd1.ExecuteNonQuery();

                    foreach (DataGridViewRow row in dgvMonAn.Rows)
                    {
                        string maMonAn = row.Cells["MaMon"].Value.ToString();
                        int soLuongMua = Convert.ToInt32(row.Cells["SoLuong"].Value);

                        SqlCommand cmd2 = new SqlCommand("sp_ThemChiTietDonHang", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@maDonHang", SqlDbType.VarChar, 10).Value = maDonHang;
                        cmd2.Parameters.Add("@maMonAn", SqlDbType.VarChar, 10).Value = maMonAn;
                        cmd2.Parameters.Add("@soLuongMua", SqlDbType.Int).Value = soLuongMua;
                        cmd2.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
    }
}
