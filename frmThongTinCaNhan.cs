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
    public partial class frmThongTinCaNhan : Form
    {
        private string username = frmLogin.username;
        private string strConn = frmLogin.strConn;
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                using (SqlConnection conn =  new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"Select * from NhanVien Where MaNhanVien = '{username}' ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string maNhanVien = reader.GetString(0);
                        string hoTen = reader.GetString(1);
                        DateTime ngaySinh = reader.GetDateTime(2);
                        string gioiTinh = reader.GetString(3);
                        string chucVu = reader.GetString(4);
                        string soDienThoai = reader.GetString(5);
                        // Gán giá trị lấy được vào các control trên form
                        txtMaNV.Text = maNhanVien;
                        txtHoTen.Text = hoTen;
                        txtNgaySinh.Text = ngaySinh.ToString("dd/MM/yyyy");
                        txtGioiTinh.Text = gioiTinh;
                        txtChucVu.Text = chucVu;
                        txtSoDienThoai.Text = soDienThoai;
                    }
                    reader.Close();
                }
                txtMatKhauCu.PasswordChar = '*';
                txtMatKhauMoi.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            bool check = DoiMatKhau();
            if (check)
            {
                MessageBox.Show("Đổi mật khẩu thành công!!");
                Application.Restart();
            }
            txtMatKhauMoi.ResetText();
            txtMatKhauCu.ResetText();
        }
        public bool DoiMatKhau()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DoiMatKhau", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@matKhauCu", SqlDbType.VarChar).Value = txtMatKhauCu.Text;
                    cmd.Parameters.Add("@matKhauMoi", SqlDbType.VarChar).Value = txtMatKhauMoi.Text;
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

        private void cbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThi.Checked)
            {
                txtMatKhauCu.PasswordChar = '\0';
                txtMatKhauMoi.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauCu.PasswordChar = '*';
                txtMatKhauMoi.PasswordChar = '*';
            }
        }
    }
}
