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
    public partial class frmQLDHTrucTiep : Form
    {
        SqlDataAdapter daMonAn = null;
        DataTable dtMonAn = null;
        DataView dtvMonAn = null;
        private string strConn = frmLogin.strConn;
        private string maNhanVien = frmLogin.username;
        public frmQLDHTrucTiep()
        {
            InitializeComponent();
        }

        private void dgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvMonAn.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Lấy thông tin của dòng đó
                DataGridViewRow row = dgvMonAn.Rows[e.RowIndex];
                int rowIndex = -1;
                foreach (DataGridViewRow r in dgvGioHangTrucTiep.Rows)
                {
                    if (r.Cells["TenMonAnGH"].Value != null && r.Cells["TenMonAnGH"].Value.ToString() == row.Cells["TenMonAn"].Value.ToString())
                    {
                        rowIndex = r.Index;
                        break;
                    }
                }

                if (dgvGioHangTrucTiep.DataSource == null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("STT");
                    dt.Columns.Add("MaMonAnGH");
                    dt.Columns.Add("TenMonAnGH");
                    dt.Columns.Add("DonGiaGH");
                    dt.Columns.Add("SoLuongGH");
                    dt.Columns.Add("ThanhTien");
                    dgvGioHangTrucTiep.DataSource = dt;
                }
                //Món ăn chưa tồn tại
                if (rowIndex == -1)
                {
                    DataRow newRow = ((DataTable)dgvGioHangTrucTiep.DataSource).NewRow();
                    newRow["MaMonAnGH"] = row.Cells["MaMonAn"].Value;
                    newRow["TenMonAnGH"] = row.Cells["TenMonAn"].Value;
                    newRow["DonGiaGH"] = row.Cells["DonGia"].Value;
                    newRow["SoLuongGH"] = 1; // Giá trị mặc định là 1
                    // Tính toán ThanhTien
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    decimal thanhTien = donGia * 1;
                    newRow["ThanhTien"] = thanhTien;
                    // Thêm dòng mới vào DataTable của DataGridView `dgvGioHangTrucTiep`
                    ((DataTable)dgvGioHangTrucTiep.DataSource).Rows.Add(newRow);
                }
                else //Món ăn đã tồn tại, chỉ cập nhật lại số lượng và tính thành tiền
                {
                    DataGridViewRow r = dgvGioHangTrucTiep.Rows[rowIndex];
                    int soLuong = Convert.ToInt32(r.Cells["SoLuongGH"].Value);
                    soLuong++;
                    r.Cells["SoLuongGH"].Value = soLuong;

                    // Tính toán ThanhTien
                    decimal donGia = Convert.ToDecimal(r.Cells["DonGiaGH"].Value);
                    decimal thanhTien = donGia * soLuong;
                    r.Cells["ThanhTien"].Value = thanhTien;
                }
                dgvGioHangTrucTiep.Columns["TenMonAnGH"].HeaderText = "Tên Món";
                dgvGioHangTrucTiep.Columns["DonGiaGH"].HeaderText = "Đơn giá";
                dgvGioHangTrucTiep.Columns["SoLuongGH"].HeaderText = "Số lượng";
                dgvGioHangTrucTiep.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvGioHangTrucTiep.AutoResizeColumns();

                //Set chỉnh sửa số lượng trên dgv
                dgvGioHangTrucTiep.ReadOnly = false;
                dgvGioHangTrucTiep.Columns["TenMonAnGH"].ReadOnly = true;
                dgvGioHangTrucTiep.Columns["DonGiaGH"].ReadOnly = true;
                dgvGioHangTrucTiep.Columns["SoLuongGH"].ReadOnly = false;
                dgvGioHangTrucTiep.Columns["ThanhTien"].ReadOnly = true;

                dgvGioHangTrucTiep.Columns["MaMonAnGH"].Visible = false;

                dgvGioHangTrucTiep.CellEndEdit += DgvGioHangTrucTiep_CellEndEdit;
                tinhTongTien(dgvGioHangTrucTiep);
                dgvGioHangTrucTiep.AllowUserToAddRows = false;
            }
        }

        private void DgvGioHangTrucTiep_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvGioHangTrucTiep.Columns[e.ColumnIndex].Name == "SoLuongGH")
            {
                DataGridViewRow row1 = dgvGioHangTrucTiep.Rows[e.RowIndex];
                int soLuongMoi = Convert.ToInt32(row1.Cells["SoLuongGH"].Value);
                string tenMonAn = dgvGioHangTrucTiep.Rows[e.RowIndex].Cells["TenMonAnGH"].Value.ToString();
                DataGridViewRow row2 = dgvMonAn.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["TenMonAn"].Value.ToString().Equals(tenMonAn))
                    .First();
                int soLuongHienTai = Convert.ToInt32(row2.Cells["ConLai"].Value);
                if (soLuongMoi > soLuongHienTai)
                {
                    MessageBox.Show("Số lượng vượt quá số lượng hiện có của món ăn!");
                    dgvGioHangTrucTiep.Rows[e.RowIndex].Cells["SoLuongGH"].Value = 1;
                }
                else
                {
                    decimal donGia = Convert.ToDecimal(row1.Cells["DonGiaGH"].Value);
                    decimal thanhTien = donGia * soLuongMoi;
                    row1.Cells["ThanhTien"].Value = thanhTien;
                }
                tinhTongTien(dgvGioHangTrucTiep);
            }
        }

        private void frmQLDHTrucTiep_Load(object sender, EventArgs e)
        {
            LoadMonAn();
            dgvGioHangTrucTiep.RowsAdded += DgvGioHangTrucTiep_RowsAdded;
        }

        private void DgvGioHangTrucTiep_RowsAdded(object? sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                DataGridViewRow row = dgvGioHangTrucTiep.Rows[i];
                row.Cells["STT"].Value = i + 1;
            }
        }

        public void LoadMonAn()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    daMonAn = new SqlDataAdapter("SELECT * FROM view_DanhSachMonAnCon", conn);
                    dtMonAn = new DataTable();
                    dtMonAn.Clear();
                    daMonAn.Fill(dtMonAn);

                    dgvMonAn.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvMonAn_CellFormatting);
                    dtvMonAn = new DataView(dtMonAn);
                    dgvMonAn.DataSource = dtvMonAn;
                    dgvMonAn.Columns["MaNguoiTao"].Visible = false;
                    dgvMonAn.AutoResizeColumn(7);
                    dgvMonAn.AllowUserToAddRows = false;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void dgvMonAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMonAn.Columns["HinhAnh"].Index && e.Value != null)
            {
                string imgPath = e.Value.ToString();
                if (File.Exists(imgPath))
                {
                    Image img = Image.FromFile(imgPath);
                    e.Value = img;
                }
            } 
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void tinhTongTien(DataGridView dgvGioHangTrucTiep)
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvGioHangTrucTiep.Rows)
            {
                decimal thanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                tongTien += thanhTien;
            }
            txtTongTien.Text = tongTien.ToString();
            txtTongTien.Font = new Font(txtTongTien.Font, FontStyle.Bold);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiemMonAnTheoTen();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool check;
            check = TaoDonHangTrucTiep();
            if (check)
            {
                MessageBox.Show("Đã tạo đơn hàng thành công!!");
            }
        }

        private void txtTenMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTim_Click(sender, e);
                e.Handled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHangTrucTiep.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvGioHangTrucTiep.SelectedCells[0].OwningRow.Index;
                dgvGioHangTrucTiep.Rows.RemoveAt(selectedRowIndex); // xóa dòng chứa cell được chọn
                tinhTongTien(dgvGioHangTrucTiep);
            }
        }
        public bool TaoDonHangTrucTiep()
        {
            string maDonHang = GeneralMethod.LayMaTuDong("DonHang", "MaDonHang");
            string maKhachHang = GeneralMethod.LayMaTuDong("KhachHang", "MaKhachhang");
            
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    SqlCommand cmd1 = new SqlCommand("sp_TaoDonHangTrucTiep", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Transaction = tran;
                    cmd1.Parameters.Add("@maKhachHang", SqlDbType.VarChar, 10).Value = maKhachHang;
                    cmd1.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50).Value = txtHoTen.Text;
                    cmd1.Parameters.Add("@diaChi", SqlDbType.NVarChar, 200).Value = txtDiaChi.Text;
                    cmd1.Parameters.Add("@soDienThoai", SqlDbType.VarChar, 11).Value = txtSoDienThoai.Text;
                    cmd1.Parameters.Add("@maDonHang", SqlDbType.VarChar, 10).Value = maDonHang;
                    cmd1.Parameters.Add("@ngayTaoDon", SqlDbType.Date).Value = DateTime.Now.Date.ToString("yyyy-MM-dd");
                    cmd1.Parameters.Add("maNhanVienBan", SqlDbType.VarChar).Value = maNhanVien.ToUpper();
                    cmd1.Parameters.Add("@hinhThucThanhToan", SqlDbType.NVarChar, 30).Value = cboThanhToan.SelectedItem.ToString();
                    cmd1.Parameters.Add("@tongTien", SqlDbType.Int).Value = Convert.ToInt32(txtTongTien.Text);
                    cmd1.Parameters.Add("@ghiChu", SqlDbType.NVarChar, 200).Value = txtGhiChu.Text;
                    cmd1.ExecuteNonQuery();

                    foreach (DataGridViewRow row in dgvGioHangTrucTiep.Rows)
                    {
                        string maMonAn = row.Cells["MaMonAnGH"].Value.ToString();
                        int soLuongMua = Convert.ToInt32(row.Cells["SoLuongGH"].Value);

                        SqlCommand cmd2 = new SqlCommand("sp_ThemChiTietDonHang", conn);
                        cmd2.Transaction = tran;
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@maDonHang", SqlDbType.VarChar, 10).Value = maDonHang;
                        cmd2.Parameters.Add("@maMonAn", SqlDbType.VarChar, 10).Value = maMonAn;
                        cmd2.Parameters.Add("@soLuongMua", SqlDbType.Int).Value = soLuongMua;
                        cmd2.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch (SqlException ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public void TimKiemMonAnTheoTen()
        {
            using (SqlConnection conn = new SqlConnection(frmLogin.strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKiemTheoTenMonAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenMonAn", SqlDbType.NVarChar).Value = txtTenMon.Text;
                SqlDataAdapter daMonAn = new SqlDataAdapter(cmd);
                DataTable dtMonAn = new DataTable();
                daMonAn.Fill(dtMonAn);
                dgvMonAn.DataSource = dtMonAn;
                dgvMonAn.Columns["MoTa"].DisplayIndex = 7;
                dgvMonAn.Columns["TrangThai"].Visible = false;
            }
        }
    }
}
