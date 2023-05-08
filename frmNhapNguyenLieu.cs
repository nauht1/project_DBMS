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
    public partial class frmNhapNguyenLieu : Form
    {
        private int rowIndex;
        SqlDataAdapter daKhoNL = null;
        DataTable dtKhoNL = null;
        private bool sua;
        private string strConn = frmLogin.strConn;
        private string maNhanVien = frmLogin.username;
        public frmNhapNguyenLieu()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
        }
        public class NguyenLieu
        {
            public string TenNguyenLieu { get; set; }
            public int SoLuong { get; set; }
            public float DonGia { get; set; }
            public float ThanhTien { get; set; }
        }

        private void btnThemGio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNL.Text) || string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNL.Focus();
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.TenNguyenLieu = txtTenNL.Text;
            nguyenLieu.SoLuong = Int32.Parse(txtSoLuong.Text);
            nguyenLieu.DonGia = float.Parse(txtDonGia.Text);
            nguyenLieu.ThanhTien = nguyenLieu.SoLuong * nguyenLieu.DonGia;
            dgvGioNguyenLieu.Rows.Add(nguyenLieu.TenNguyenLieu, nguyenLieu.SoLuong, nguyenLieu.DonGia, nguyenLieu.ThanhTien);
            dgvGioNguyenLieu.AutoResizeColumns();
            dgvGioNguyenLieu.AllowUserToAddRows = false;
            TinhTongTien();
            //Xử lí trùng nguyên liệu
            txtTenNL.ResetText();
            txtSoLuong.ResetText();
            txtDonGia.ResetText();
        }
        public void TinhTongTien()
        {
            float tongTien = 0;
            foreach (DataGridViewRow row in dgvGioNguyenLieu.Rows)
            {
                float thanhTien = (float)row.Cells["ThanhTien"].Value;
                tongTien += thanhTien;
            }
            txtTongTien.Text = tongTien.ToString();
            txtTongTien.Font = new Font(txtTongTien.Font, FontStyle.Bold);
        }
        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    daKhoNL = new SqlDataAdapter("Select * from view_DanhSachNguyenLieu", conn);
                    dtKhoNL = new DataTable();
                    dtKhoNL.Clear();
                    daKhoNL.Fill(dtKhoNL);

                    dgvKhoNguyenLieu.DataSource = dtKhoNL;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmNhapNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Tạo phiếu nhập chứa các nguyên liệu trong giỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
  
            if (traloi == DialogResult.Yes)
            {
                bool check;
                check = TaoPhieuNhap();
                if (check)
                {
                    MessageBox.Show("Đã tạo phiếu nhập thành công!!");
                    LoadData();
                    dgvGioNguyenLieu.Rows.Clear();
                    txtTenNL.Clear();
                    txtSoLuong.Clear();
                    txtDonGia.Clear();
                    txtTongTien.Clear();
                }
            }
        }
        public bool TaoPhieuNhap()
        {
            string maPhieuNhap = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    maPhieuNhap = GeneralMethod.LayMaTuDong("PhieuNhapHang", "MaPhieuNhap");
                    SqlCommand cmd1 = new SqlCommand("sp_ThemPhieuNhapHang", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@maPhieuNhap", SqlDbType.VarChar).Value = maPhieuNhap;
                    cmd1.Parameters.Add("@ngayNhap", SqlDbType.Date).Value = DateTime.Now.Date;
                    cmd1.Parameters.Add("@maNguoiQuanLy", SqlDbType.VarChar).Value = maNhanVien;
                    cmd1.Parameters.Add("@tongTienNhapHang", SqlDbType.Real).Value = txtTongTien.Text;
                    cmd1.ExecuteNonQuery();

                    foreach (DataGridViewRow row in dgvGioNguyenLieu.Rows)
                    {
                        string maNguyenLieu = GeneralMethod.LayMaTuDong("KhoNguyenLieu", "MaNguyenLieu");
                        string tenNguyenLieu = row.Cells["TenNguyenLieu"].Value.ToString();
                        int soLuong = Int32.Parse(row.Cells["SoLuong"].Value.ToString());
                        float donGia = float.Parse(row.Cells["DonGia"].Value.ToString());


                        SqlCommand cmd2 = new SqlCommand("sp_TaoCacThongTinCuaPhieuNhap", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@maNguyenLieu", SqlDbType.VarChar).Value = maNguyenLieu;
                        cmd2.Parameters.Add("@maNguoiQuanLy", SqlDbType.VarChar).Value = maNhanVien;
                        cmd2.Parameters.Add("@tenNguyenLieu", SqlDbType.NVarChar).Value = tenNguyenLieu;
                        cmd2.Parameters.Add("@soLuong", SqlDbType.Int).Value = soLuong;
                        cmd2.Parameters.Add("@maPhieuNhap", SqlDbType.VarChar).Value = maPhieuNhap;
                        cmd2.Parameters.Add("@ngayNhap", SqlDbType.Date).Value = DateTime.Now.Date;
                        cmd2.Parameters.Add("@tongTienNhapHang", SqlDbType.Real).Value = txtTongTien.Text;
                        cmd2.Parameters.Add("@donGia", SqlDbType.Real).Value = donGia;
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

        private void btnXemCTPN_Click(object sender, EventArgs e)
        {
            frmXemCTPN frm = new frmXemCTPN();
            frm.ShowDialog();
        }

        private void btnXemPhieu_Click(object sender, EventArgs e)
        {
            frmXemPN frm = new frmXemPN();
            frm.ShowDialog();
        }

        private void dgvGioNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvGioNguyenLieu.CurrentCell.RowIndex;
            this.txtTenNL.Text = dgvGioNguyenLieu.Rows[r].Cells[0].Value.ToString();
            this.txtSoLuong.Text = dgvGioNguyenLieu.Rows[r].Cells[1].Value.ToString();
            this.txtDonGia.Text = dgvGioNguyenLieu.Rows[r].Cells[2].Value.ToString();
            rowIndex = e.RowIndex;
            btnCapNhat.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Có chắc muốn xóa khỏi giỏ?", "Trả lòi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi ==  DialogResult.Yes)
            {
                if (dgvGioNguyenLieu.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvGioNguyenLieu.SelectedCells[0].OwningRow.Index;
                    dgvGioNguyenLieu.Rows.RemoveAt(selectedRowIndex); // xóa dòng chứa cell được chọn
                }
                TinhTongTien();
                txtTenNL.ResetText();
                txtSoLuong.ResetText();
                txtDonGia.ResetText();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvGioNguyenLieu.Rows[rowIndex];

            row.Cells[0].Value = txtTenNL.Text;
            row.Cells[1].Value = txtSoLuong.Text;
            row.Cells[2].Value = txtDonGia.Text;
            row.Cells[3].Value = float.Parse(txtSoLuong.Text) * float.Parse(txtDonGia.Text);
            TinhTongTien();

            txtTenNL.ResetText();
            txtSoLuong.ResetText();
            txtDonGia.ResetText();
            btnCapNhat.Enabled = false;
        }
    }
}
