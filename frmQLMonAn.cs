using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace QLCuaHangDoAnNhanhWP
{

    public partial class frmQLMonAn : Form
    {
        string hinhAnh = "";
        SqlDataAdapter daMonAn = null;
        DataTable dtMonAn = null;
        bool them;
        public frmQLMonAn()
        {
            InitializeComponent();
        }

        private void frmQLMonAn_Load(object sender, EventArgs e)
        {
            LoadMonAn();
        }

        private void btnTaoMon_Click(object sender, EventArgs e)
        {
            them = true;
            btnTaoMon.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            
            this.txtMaMon.Enabled = false;
            this.txtTenMon.Enabled = true;
            this.txtDonGia.Enabled = true;
            this.txtMoTa.Enabled = true;
            this.txtSoLuongDuTru.Enabled = true;
            this.pbMonAn.Enabled = true;
            this.btnUpload.Enabled = true;

            txtMaMon.ResetText();
            txtTenMon.ResetText();
            txtMoTa.ResetText();
            txtDonGia.ResetText();
            txtSoLuongDuTru.ResetText();
            pbMonAn.Image = null;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    hinhAnh = openFileDialog.FileName;
                    pbMonAn.Image = Image.FromFile(hinhAnh);
                }
            }
            catch
            {
                MessageBox.Show("Ảnh không hợp lệ!!");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnReload.Enabled = true;
            btnSua.Enabled = true;
            btnTaoMon.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;
            txtMoTa.Enabled = false;
            txtSoLuongDuTru.Enabled = false;
            txtDonGia.Enabled = false;
            btnUpload.Enabled = false;
            dgvMonAn_CellClick(null, null);
        }
        public void LoadMonAn()
        {
            this.txtMaMon.Enabled = false;
            this.txtTenMon.Enabled = false;
            this.txtDonGia.Enabled = false;
            this.txtMoTa.Enabled = false;
            this.txtSoLuongDuTru.Enabled = false;
            this.pbMonAn.Enabled = false;
            this.btnUpload.Enabled = false;
            using (SqlConnection conn = ClassConnection.Connection)
            {
                conn.Open();
                daMonAn = new SqlDataAdapter("SELECT * FROM view_DanhSachMonAnCon", conn);
                dtMonAn = new DataTable();
                dtMonAn.Clear();
                daMonAn.Fill(dtMonAn);
                dgvMonAn.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvMonAn_CellFormatting);
                dgvMonAn.DataSource = dtMonAn;
                dgvMonAn.AllowUserToAddRows = false;
                dgvMonAn.AutoResizeColumn(1);
                dgvMonAn_CellClick(null, null);
                dgvMonAn.AutoResizeColumn(6);
            }
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void dgvMonAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMonAn.Columns["HinhAnhMonAn"].Index && e.Value != null)
            {
                string imgPath = e.Value.ToString();
                if (File.Exists(imgPath))
                {
                    Image img = Image.FromFile(imgPath);
                    e.Value = img;
                }
            }
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvMonAn.CurrentCell.RowIndex;
            this.txtMaMon.Text = dgvMonAn.Rows[r].Cells[0].Value.ToString();
            this.txtTenMon.Text = dgvMonAn.Rows[r].Cells[1].Value.ToString();
            this.pbMonAn.Image = Image.FromFile(dgvMonAn.Rows[r].Cells[2].Value.ToString());
            this.txtSoLuongDuTru.Text = dgvMonAn.Rows[r].Cells[4].Value.ToString();
            this.txtDonGia.Text = dgvMonAn.Rows[r].Cells[5].Value.ToString();
            this.txtMoTa.Text = dgvMonAn.Rows[r].Cells[6].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadMonAn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa món ăn này ?", "Trả lời",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi== DialogResult.Yes)
            {
                XoaMonAn();
                LoadMonAn();
                MessageBox.Show("Xóa thành công!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;

            dgvMonAn_CellClick(null, null);
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnUpload.Enabled = true;

            btnTaoMon.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtTenMon.Enabled = true;
            txtMoTa.Enabled = true;
            txtDonGia.Enabled = true;
            txtSoLuongDuTru.Enabled = true;
            
            txtTenMon.Focus();

            int r = dgvMonAn.CurrentCell.RowIndex;
            hinhAnh = dgvMonAn.Rows[r].Cells[2].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool check;
            if (them)
            {
                check = ThemMonAn();
                if (check)
                {
                    MessageBox.Show("Đã thêm xong!");
                    LoadMonAn();
                }
            }
            else
            {
                check = CapNhatMonAn();
                if (check)
                {
                    MessageBox.Show("Đã cập nhật thành công!!");
                    LoadMonAn();
                }
            }
            this.btnTaoMon.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnReload.Enabled = true;
        }
        public bool ThemMonAn()
        {
            try
            {
                using (SqlConnection conn = ClassConnection.Connection)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ThemMonAn", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    string maMonAn = GeneralMethod.LayMaTuDong("MonAn", "MaMonAn");
                    cmd.Parameters.Add("@maMonAn", SqlDbType.VarChar).Value = maMonAn;
                    cmd.Parameters.Add("@maNguoiTao", SqlDbType.VarChar).Value = "NV001";
                    cmd.Parameters.Add("@tenMonAn", SqlDbType.NVarChar).Value = txtTenMon.Text;
                    cmd.Parameters.Add("@moTa", SqlDbType.NVarChar).Value = txtMoTa.Text;
                    cmd.Parameters.Add("@donGia", SqlDbType.Float).Value = float.Parse(txtDonGia.Text);
                    cmd.Parameters.Add("@soLuongDuTru", SqlDbType.Int).Value = Int32.Parse(txtSoLuongDuTru.Text);
                    cmd.Parameters.Add("@hinhAnh", SqlDbType.VarChar).Value = hinhAnh;
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void XoaMonAn()
        {
            using (SqlConnection conn = ClassConnection.Connection)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaMonAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maMonAn", SqlDbType.VarChar).Value = txtMaMon.Text;
                cmd.ExecuteNonQuery();
            }
        }
        public bool CapNhatMonAn()
        {
            try
            {
                using (SqlConnection conn = ClassConnection.Connection)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_CapNhatMonAn", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maMonAn", SqlDbType.VarChar).Value = txtMaMon.Text;
                    cmd.Parameters.Add("@maNguoiTao", SqlDbType.VarChar).Value = "NV001";
                    cmd.Parameters.Add("@tenMonAn", SqlDbType.NVarChar).Value = txtTenMon.Text;
                    cmd.Parameters.Add("@moTa", SqlDbType.NVarChar).Value = txtMoTa.Text;
                    cmd.Parameters.Add("@donGia", SqlDbType.Float).Value = float.Parse(txtDonGia.Text);
                    cmd.Parameters.Add("@hinhAnh", SqlDbType.VarChar).Value = hinhAnh;
                    cmd.Parameters.Add("@soLuongDuTru", SqlDbType.Int).Value = Int32.Parse(txtSoLuongDuTru.Text);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Form frmCTMA = new frmChiTietMonAn();
            frmCTMA.ShowDialog();
        }
    }
}
