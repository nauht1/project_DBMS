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
    public partial class frmTaiKhoan : Form
    {
        private string maNV;
        SqlDataAdapter daTaiKhoan = null;
        DataTable dtTaiKhoan = null;
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(frmLogin.strConn))
                {
                    daTaiKhoan = new SqlDataAdapter("Select * from TaiKhoanDangNhap", conn);
                    dtTaiKhoan = new DataTable();
                    dtTaiKhoan.Clear();
                    daTaiKhoan.Fill(dtTaiKhoan);

                    dgvTaiKhoan.DataSource = dtTaiKhoan;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TimKiemTaiKhoan();
        }
        public void TimKiemTaiKhoan()
        {
            using (SqlConnection conn = new SqlConnection(frmLogin.strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKiemTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenDangNhap", SqlDbType.VarChar).Value = txtMaNV.Text;
                daTaiKhoan = new SqlDataAdapter(cmd);
                dtTaiKhoan = new DataTable();
                daTaiKhoan.Fill(dtTaiKhoan);
                dgvTaiKhoan.DataSource = dtTaiKhoan;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            bool check = ResetMatKhau();
            if (check)
            {
                MessageBox.Show("Đã reset mật khẩu thành công!");
                LoadData();
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTaiKhoan.CurrentCell.RowIndex;
            maNV = dgvTaiKhoan.Rows[r].Cells[0].Value.ToString();
        }
        public bool ResetMatKhau()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(frmLogin.strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"Update TaiKhoanDangNhap " +
                                                    $"Set MatKhau = '123456' " +
                                                    $"Where TenDangNhap = '{maNV}'", conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
