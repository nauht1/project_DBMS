using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoAnNhanhWP
{
    public partial class frmQLNV : Form
    {
        SqlDataAdapter daNhanVien = null;
        DataTable dtNhanVien = null;
        bool them;
        public frmQLNV()
        {
            InitializeComponent();
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {   
            try
            {
                using (SqlConnection conn = ClassConnection.Connection)
                {
                    conn.Open();
                    daNhanVien = new SqlDataAdapter("Select * from view_DanhSachNhanVien", conn);
                    dtNhanVien = new DataTable();
                    dtNhanVien.Clear();
                    daNhanVien.Fill(dtNhanVien);

                    dgvNhanVien.DataSource = dtNhanVien;
                    dgvNhanVien.AllowUserToAddRows = false;
                    dgvNhanVien.AutoResizeColumn(1);
                    dgvNhanVien.AutoResizeColumn(3);
                    dgvNhanVien.AutoResizeColumn(4);
                    dgvNhanVien_CellClick(null, null);

                    this.btnLuu.Enabled = false;
                    this.btnHuy.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu!!");
            }
        }


        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvNhanVien.CurrentCell.RowIndex;
            this.txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtHoTen.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtNgaySinh.Text = Convert.ToDateTime(dgvNhanVien.Rows[r].Cells[2].Value).ToString("dd-MM-yyyy");
            string gioiTinh = dgvNhanVien.Rows[r].Cells["GioiTinh"].Value.ToString();
            int index = this.cboGioiTinh.FindStringExact(gioiTinh);

            //Xử lý từ textboxcolumn lên combobox
            if (index != -1)
            {
                this.cboGioiTinh.SelectedIndex = index;
            }
            this.cboChucVu.Text = dgvNhanVien.Rows[r].Cells["ChucVu"].Value.ToString();
            this.txtSoDienThoai.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;

            txtMaNV.Text = "";
            txtHoTen.ResetText();
            txtNgaySinh.ResetText();
            cboGioiTinh.ResetText();
            cboChucVu.ResetText();
            txtSoDienThoai.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel1.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnReload.Enabled = false;

            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            this.panel1.Enabled = true;
            dgvNhanVien_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            this.txtHoTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                ThemNhanVien();
                LoadData();
                MessageBox.Show("Đã thêm xong!");
            }
            else
            {
                CapNhatNhanVien();
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            this.btnThoat.Enabled = true;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            string maNV = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Có chắc xóa nhân viên này không?", "Trả lời",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traloi == DialogResult.Yes)
            {
                XoaNhanVien(maNV);
                MessageBox.Show("Đã xóa thành công!");
                LoadData();
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaNV.ResetText();
            this.txtHoTen.ResetText();
            this.txtNgaySinh.ResetText();
            this.cboGioiTinh.ResetText();
            this.cboChucVu.ResetText();
            this.txtSoDienThoai.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.panel1.Enabled = true;
            //
            dgvNhanVien_CellClick(null, null);
        }
        public void XoaNhanVien(string maNV)
        {
            try
            {
                using (SqlConnection conn = ClassConnection.Connection)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_XoaNhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNV;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void ThemNhanVien()
        {
            try
            {
                using (SqlConnection conn = ClassConnection.Connection)
                {
                    conn.Open();
                    DateTime date = DateTime.ParseExact(txtNgaySinh.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    string ngaySinh = date.ToString("yyyy-MM-dd");

                    string maNhanVien = GeneralMethod.LayMaTuDong("NhanVien", "MaNhanVien");
                    SqlCommand cmd = new SqlCommand("sp_ThemNhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
                    cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = txtHoTen.Text;
                    cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = ngaySinh;
                    cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = cboGioiTinh.SelectedItem.ToString();
                    cmd.Parameters.Add("@chucVu", SqlDbType.NVarChar).Value = cboChucVu.SelectedItem.ToString();
                    cmd.Parameters.Add("@soDienThoai", SqlDbType.VarChar).Value = txtSoDienThoai.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CapNhatNhanVien()
        {
            try
            {
                using (SqlConnection conn = ClassConnection.Connection)
                {
                    conn.Open();
                    DateTime date = DateTime.ParseExact(txtNgaySinh.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    string ngaySinh = date.ToString("yyyy-MM-dd");
                    SqlCommand cmd = new SqlCommand("sp_CapNhatNhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = txtMaNV.Text;
                    cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = txtHoTen.Text;
                    cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = ngaySinh;
                    cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = cboGioiTinh.SelectedItem.ToString();
                    cmd.Parameters.Add("@chucVu", SqlDbType.NVarChar).Value = cboChucVu.SelectedItem.ToString();
                    cmd.Parameters.Add("@soDienThoai", SqlDbType.VarChar).Value = txtSoDienThoai.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
