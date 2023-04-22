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
    public partial class frmQLKH : Form
    {
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;
        bool them;
        public frmQLKH()
        {
            InitializeComponent();
        }

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = ClassConnection.Connection)
                {
                    conn.Open();
                    daKhachHang = new SqlDataAdapter("Select * from view_DanhSachKhachHang", conn);
                    dtKhachHang = new DataTable();
                    dtKhachHang.Clear();
                    daKhachHang.Fill(dtKhachHang);

                    dgvKhachHang.DataSource = dtKhachHang;
                    dgvKhachHang.AllowUserToAddRows = false;
                    dgvKhachHang.AutoResizeColumns();
                    dgvKhachHang_CellClick(null, null);

                    this.btnLuu.Enabled = false;
                    this.btnHuy.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtHoTen.Enabled = false;
                    txtSoDienThoai.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu!!");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            this.txtMaKH.Text =
            dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            this.txtHoTen.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            this.txtSoDienThoai.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            dgvKhachHang_CellClick(null, null);

            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDienThoai.Enabled = true;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThoat.Enabled = false;
            btnReload.Enabled = false;


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool check;
            if (!them)
            {
                check = CapNhatKhachHang();
                if (check)
                {
                    MessageBox.Show("Đã cập nhật thành công!!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Có lỗi!!!");
                }
            }

            this.btnThoat.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnReload.Enabled = true;
        }
        public bool CapNhatKhachHang()
        {
            try
            {
                using (SqlConnection conn = ClassConnection.Connection)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_CapNhatKhachHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = txtMaKH.Text;
                    cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = txtHoTen.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                    cmd.Parameters.Add("@soDienThoai", SqlDbType.VarChar).Value = txtSoDienThoai.Text;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnThoat.Enabled = true;
            btnReload.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //
            dgvKhachHang_CellClick(null, null);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
