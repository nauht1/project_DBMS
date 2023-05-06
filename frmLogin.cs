using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoAnNhanhWP
{
    public partial class frmLogin : Form
    {
        public static string strConn = "";
        public static string username = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            username = txtUser.Text;
            string password = txtPass.Text;
            bool check = KiemTraTaiKhoan(username, password);
            if (check)
            {
                strConn = ClassConnection.GetConnectionString(username, password);
                frmMain frm_Main = new frmMain();
                this.Hide();
                frm_Main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!!");
            }
        }
        public bool KiemTraTaiKhoan(string username, string password)
        {
            try
            {
                string strConnection = "Data Source= .\\NAUHTSQLSERVER;Initial Catalog=QLCuaHangDoAnNhanh;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(strConnection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"Select Count(*) from TaiKhoanDangNhap Where TenDangNhap = '{username}' and MatKhau = '{password}'", conn);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                        return true;
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu bị sai!!");
                return false;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Select();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThi.Checked)
                txtPass.PasswordChar = '\0';
            else
                txtPass.PasswordChar = '*';
        }
    }
}