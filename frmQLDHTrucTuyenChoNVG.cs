using System;
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
    public partial class frmQLDHTrucTuyenChoNVG : Form
    {
        DataTable dtDonDG = null;
        DataTable dtDonGX = null;
        private string maDon;
        string strConn = frmLogin.strConn;
        public frmQLDHTrucTuyenChoNVG()
        {
            InitializeComponent();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXemCTDH_Click(object sender, EventArgs e)
        {
            frmCTDH frm = new frmCTDH();
            frm.btnTrucTiep.Hide();
            frm.Show();
        }

        private void frmQLDHTrucTuyenChoNVG_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * from func_DonHangCuaNhanVienGiao(@maNhanVien,@trangThaiDonHang)", conn);
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = frmLogin.username;
                    cmd1.Parameters.Add("@trangThaiDonHang", SqlDbType.NVarChar).Value = "Đang giao hàng";
                    SqlDataReader reader1 = cmd1.ExecuteReader();

                    dtDonDG = new DataTable();
                    dtDonDG.Clear();
                    dtDonDG.Load(reader1);
                    dgvDonDG.DataSource = dtDonDG;
                    dgvDonDG.AutoResizeColumns();

                    SqlCommand cmd2 = new SqlCommand("Select * from func_DonHangCuaNhanVienGiao(@maNhanVien,@trangThaiDonHang)", conn);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = frmLogin.username;
                    cmd2.Parameters.Add("@trangThaiDonHang", SqlDbType.NVarChar).Value = "Đã giao hàng";
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    dtDonGX = new DataTable();
                    dtDonGX.Clear();
                    dtDonGX.Load(reader2);
                    dgvDonGX.DataSource = dtDonGX;
                    dgvDonGX.AutoResizeColumns();
                }
                btnXacNhan.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu!!");
            }
        }

        private void btnXemDon_Click(object sender, EventArgs e)
        {
            frmQLDH frm = new frmQLDH();
            frm.btnTrucTiep.Hide();
            frm.btnReload.Location = new Point(609, 6);
            frm.ShowDialog();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatDonHang();
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDonDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maDon = dgvDonDG.Rows[e.RowIndex].Cells[0].Value.ToString();
                LoadKhachHangVaDonHang(maDon);
            }
            btnXacNhan.Enabled = true;
        }

        private void dgvDonGX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maDon = dgvDonGX.Rows[e.RowIndex].Cells[0].Value.ToString();
                LoadKhachHangVaDonHang(maDon);
            }
            btnXacNhan.Enabled = false;
        }
        public void LoadKhachHangVaDonHang(string maDon)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string queryKhachHang = "SELECT * FROM KhachHang WHERE MaKhachHang IN (SELECT MaKhachHang FROM DonHang WHERE MaDonHang = @maDonHang)";
                SqlCommand cmdKhachHang = new SqlCommand(queryKhachHang, conn);
                cmdKhachHang.Parameters.AddWithValue("@maDonHang", maDon);
                SqlDataReader readerKhachHang = cmdKhachHang.ExecuteReader();
                while (readerKhachHang.Read())
                {
                    txtHoTen.Text = readerKhachHang["HoTen"].ToString();
                    txtDiaChi.Text = readerKhachHang["DiaChi"].ToString();
                    txtDienThoai.Text = readerKhachHang["SoDienThoai"].ToString();
                }
                readerKhachHang.Close();

                string queryDonHang = "SELECT * FROM DonHangTrucTuyen JOIN DonHang " +
                                        "ON DonHangTrucTuyen.MaDonHang = DonHang.MaDonHang " +
                                        "WHERE DonHang.MaDonHang = @maDonHang";
                SqlCommand cmdDonHang = new SqlCommand(queryDonHang, conn);
                cmdDonHang.Parameters.AddWithValue("@maDonHang", maDon);
                SqlDataReader readerDonHang = cmdDonHang.ExecuteReader();
                while (readerDonHang.Read())
                {
                    txtThanhToan.Text = readerDonHang["HinhThucThanhToan"].ToString();
                    txtTongTien.Text = readerDonHang["TongTien"].ToString();
                    txtNhanVien.Text = readerDonHang["MaNhanVienGiao"].ToString();
                }
                readerDonHang.Close();
            }
            
        }
        public void CapNhatDonHang()
        {
            if (dgvDonDG.SelectedCells.Count > 0)
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    //Cập nhật đơn đang giao thành đơn đã giao
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_CapNhatTrangThaiDonTrucTuyen", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maDonHang", SqlDbType.VarChar).Value = maDon;
                    cmd.Parameters.Add("@maNhanVienGiao", SqlDbType.VarChar).Value = txtNhanVien.Text;
                    cmd.Parameters.Add("@trangThaiDonHang", SqlDbType.NVarChar).Value = "Đã giao hàng";
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
