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
    public partial class frmQLDHTrucTuyen : Form
    {
        SqlDataAdapter daDonCXN = null;
        DataTable dtDonCXN = null;
        SqlDataAdapter daDonDG = null;
        DataTable dtDonDG = null;
        SqlDataAdapter daDonGX = null;
        DataTable dtDonGX = null;
        private string strConn = frmLogin.strConn;
        private string maNhanVien = frmLogin.username;
        public frmQLDHTrucTuyen()
        {
            InitializeComponent();
        }
        public frmQLDHTrucTuyen(string maNhanVien)
        {
            InitializeComponent();
            txtNhanVien.Text = maNhanVien;
        }
        //public DataTable dtMonAn { get; set; }
        //public void LoadData(DataTable dt)
        //{
        //    dtMonAn = dt;
        //    dgvDonCXN.DataSource = dt;
        //}

        private void frmDHTrucTuyen_Load(object sender, EventArgs e)
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
                    daDonCXN = new SqlDataAdapter("Select * from view_DanhSachDonChoXacNhan", conn);
                    dtDonCXN = new DataTable();
                    dtDonCXN.Clear();
                    daDonCXN.Fill(dtDonCXN);
                    dgvDonCXN.DataSource = dtDonCXN;
                    dgvDonCXN.AutoResizeColumns();

                    daDonDG = new SqlDataAdapter("Select * from view_DanhSachDonDangGiao", conn);
                    dtDonDG = new DataTable();
                    dtDonDG.Clear();
                    daDonDG.Fill(dtDonDG);
                    dgvDonDG.DataSource = dtDonDG;
                    dgvDonDG.AutoResizeColumns();

                    daDonGX = new SqlDataAdapter("Select * from view_DanhSachDonDaGiao", conn);
                    dtDonGX = new DataTable();
                    dtDonGX.Clear();
                    daDonGX.Fill(dtDonGX);
                    dgvDonGX.DataSource = dtDonGX;
                    dgvDonGX.AutoResizeColumns();
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu!!");
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtNhanVien.Text != "NV001")
            {
                bool check = CapNhatDonHang();
                if (check)
                {
                    MessageBox.Show("Xác nhận thành công!");
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên giao hàng!");
            }
        }
        public bool CapNhatDonHang()
        {
            if (dgvDonCXN.SelectedCells.Count > 0)
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                { 
                    //Cập nhật đơn đang chờ xác nhận thành đơn đang giao
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("sp_CapNhatTrangThaiDonTrucTuyen", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@maDonHang", SqlDbType.VarChar).Value = maDon;
                    cmd1.Parameters.Add("@maNhanVienGiao", SqlDbType.VarChar).Value = txtNhanVien.Text;
                    cmd1.Parameters.Add("@trangThaiDonHang", SqlDbType.NVarChar).Value = "Đang giao hàng";
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand($"Update DonHang " +
                                                    $"Set MaNhanVienBan = UPPER('{maNhanVien}') " +
                                                    $"Where MaDonHang = '{maDon}'", conn);
                    cmd2.ExecuteNonQuery();
                    return true;
                }
            }
            return false;
        }

        private void btnXemCTDH_Click(object sender, EventArgs e)
        {
            frmCTDH frm = new frmCTDH();
            frm.Show();
        }
        private string maDon;
        private void dgvDonCXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maDon = dgvDonCXN.Rows[e.RowIndex].Cells[0].Value.ToString();
                LoadKhachHangVaDonHang(maDon);
            }
            btnXacNhan.Enabled = true;
            btnChonNV.Enabled = true;
        }

        private void btnChonNV_Click(object sender, EventArgs e)
        {
            frmNhanVienGiao frm = new frmNhanVienGiao();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnXemDon_Click(object sender, EventArgs e)
        {
            frmQLDH frm = new frmQLDH();
            frm.ShowDialog();
        }

        private void dgvDonDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maDon = dgvDonDG.Rows[e.RowIndex].Cells[0].Value.ToString();
                LoadKhachHangVaDonHang(maDon);
            }
            btnXacNhan.Enabled = false;
            btnChonNV.Enabled = false;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDonGX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maDon = dgvDonGX.Rows[e.RowIndex].Cells[0].Value.ToString();
                LoadKhachHangVaDonHang(maDon);
            }
            btnXacNhan.Enabled = false;
            btnChonNV.Enabled = false;
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

        private void dgvDonDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
