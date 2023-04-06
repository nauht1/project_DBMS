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

namespace QLCuaHangDoAnNhanhWP
{

    public partial class frmQLMonAn : Form
    {
        string sqlStringConnection = "Data Source = DESKTOP-ACER\\NAUHTSQLSERVER; " +
                "Initial Catalog = QLCuaHangDoAnNhanh; " +
                "User ID = sa; Password = 281003";
        SqlConnection conn = null;
        public frmQLMonAn()
        {
            InitializeComponent();
        }

        private void frmQLMonAn_Load(object sender, EventArgs e)
        {

        }
        public void ThemMonAn(string maNguoiTao, string tenMonAn, string moTa, int donGia, int soLuongDuTru)
        {
            try
            {
                conn = new SqlConnection(sqlStringConnection);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                string sqlString = "sp_ThemMonAn";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlString;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaNguoiTao", SqlDbType.VarChar).Value = maNguoiTao;
                cmd.Parameters.Add("@TenMonAn", SqlDbType.NVarChar).Value = tenMonAn;
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = moTa;
                cmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = donGia;
                cmd.Parameters.Add("@SoLuongDuTru", SqlDbType.Int).Value = soLuongDuTru;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTaoMon_Click(object sender, EventArgs e)
        {
            try
            {
                string maNguoiTao = "NV001";
                string tenMonAn = txtTenMon.Text;
                string moTa = txtMoTa.Text;
                int donGia = Convert.ToInt32(txtDonGia.Text);
                int soLuongDuTru = Convert.ToInt32(txtSoLuongDuTru.Text);
                ThemMonAn(maNguoiTao, tenMonAn, moTa, donGia, soLuongDuTru);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
