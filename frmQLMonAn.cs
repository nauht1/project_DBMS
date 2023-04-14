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
        string sqlStringConnection = "Data Source = DESKTOP-ACER\\NAUHTSQLSERVER; " +
                "Initial Catalog = QLCuaHangDoAnNhanh; " +
                "User ID = sa; Password = 281003";
        SqlConnection conn = null;
        string hinhAnh = "";
        public frmQLMonAn()
        {
            InitializeComponent();
        }

        private void frmQLMonAn_Load(object sender, EventArgs e)
        {

        }
        public void ThemMonAn(string maNguoiTao, string tenMonAn, string moTa, int donGia, int soLuongDuTru, string hinhAnh)
        {
            try
            {
                conn = new SqlConnection(sqlStringConnection);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemMonAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maNguoiTao", SqlDbType.VarChar).Value = maNguoiTao;
                cmd.Parameters.Add("@tenMonAn", SqlDbType.NVarChar).Value = tenMonAn;
                cmd.Parameters.Add("@moTa", SqlDbType.NVarChar).Value = moTa;
                cmd.Parameters.Add("@donGia", SqlDbType.Int).Value = donGia;
                cmd.Parameters.Add("@soLuongDuTru", SqlDbType.Int).Value = soLuongDuTru;
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarChar).Value = hinhAnh;
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
                
                ThemMonAn(maNguoiTao, tenMonAn, moTa, donGia, soLuongDuTru, hinhAnh);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            catch (Exception ex)
            {
                MessageBox.Show("Thêm ảnh thành công");
            }
            
        }
    }
}
