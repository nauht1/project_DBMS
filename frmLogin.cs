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
            int chucVu = KiemTraChucVu(username);
            bool check = KiemTraTaiKhoan(username, password);
            if (check)
            {
                strConn = ClassConnection.GetConnectionString(username, password);
                if (chucVu == 1) //Nếu là quản lý thì disable mục nhân viên giao
                {
                    frmMain frm_Main = new frmMain();
                    frm_Main.nhânViênGiaoHàngToolStripMenuItem.Enabled = false;
                    this.Hide();
                    frm_Main.ShowDialog();
                    this.Close();
                }
                else if (chucVu == 2) //Nếu là nhân viên thường (bán) thì disbale mục Nhân viên giao, quản lý
                {
                    frmMain frm_Main = new frmMain();
                    frm_Main.nhânViênGiaoHàngToolStripMenuItem.Enabled = false;
                    this.Hide();
                    frm_Main.ShowDialog();
                    this.Close();
                }
                else if (chucVu == 3)  //Nếu là nhân viên giao hàng thì disable mục nhân viên thường, quản lý
                {
                    frmMain frm_Main = new frmMain();
                    frm_Main.nhânViênToolStripMenuItem1.Enabled = false;
                    this.Hide();
                    frm_Main.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!!");
            }
        }
        public void showForm()
        {
            frmMain frm_Main = new frmMain();
            this.Hide();
            frm_Main.ShowDialog();
            this.Close();
        }
        public bool KiemTraTaiKhoan(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ClassConnection.GetDefault_ConnectionString()))
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
        public int KiemTraChucVu(string maNhanVien)
        {
            try
            {
                string stringConnection = ClassConnection.GetDefault_ConnectionString();
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select dbo.func_KiemTraChucVuNhanVien(@maNhanVien)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
                    int kq = (int)cmd.ExecuteScalar();
                    return kq;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
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