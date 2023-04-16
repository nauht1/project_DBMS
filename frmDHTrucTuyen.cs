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
    public partial class frmDHTrucTuyen : Form
    {
        string sqlStringConnection = "Data Source = DESKTOP-ACER\\NAUHTSQLSERVER; " +
                "Initial Catalog = QLCuaHangDoAnNhanh; " +
                "User ID = sa; Password = 281003";
        public frmDHTrucTuyen()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sqlStringConnection))
            {
                conn.Open();
                string maKhachhang = LayMaTuDong("KhachHang", "MaKhachHang");
                SqlCommand cmd1 = new SqlCommand("sp_ThemKhachHang", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("@maKhachHang", SqlDbType.VarChar, 10).Value = maKhachhang;
                cmd1.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50).Value = "Nguyễn Văn B";
                cmd1.Parameters.Add("@diaChi", SqlDbType.NVarChar, 200).Value = "10 Võ Văn Ngân";
                cmd1.Parameters.Add("@soDienThoai", SqlDbType.VarChar, 11).Value = "0837367212";
                cmd1.ExecuteNonQuery();

                string maDonHang = LayMaTuDong("DonHang", "MaDonHang");
                SqlCommand cmd2 = new SqlCommand("sp_ThemDonHang", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("@maDonHang", SqlDbType.VarChar,10).Value = maDonHang;
                cmd2.Parameters.Add("@maKhachHang", SqlDbType.VarChar, 30).Value = maKhachhang;
                cmd2.Parameters.Add("@ngayTaoDon", SqlDbType.Date).Value = "2022-03-17";
                cmd2.Parameters.Add("maNhanVienBan", SqlDbType.VarChar).Value = "NV003";
                cmd2.Parameters.Add("@hinhThucThanhToan", SqlDbType.NVarChar, 30).Value = "TM";
                cmd2.Parameters.Add("@tongTien", SqlDbType.Int).Value = 400000;
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("sp_ThemDonHangTrucTuyen", conn);
                cmd3.CommandType = CommandType.StoredProcedure;

                cmd3.Parameters.Add("@maDonHang", SqlDbType.VarChar, 10).Value = maDonHang;
                cmd3.Parameters.Add("@maNhanVienGiao", SqlDbType.VarChar, 10).Value = "NV005";
                cmd3.Parameters.Add("@trangThaiDonHang", SqlDbType.NVarChar, 30).Value = "Đang giao hàng";

                //SqlCommand cmd4 = new SqlCommand("sp_ThemChiTietDonHang", conn);
                //cmd4.CommandType = CommandType.StoredProcedure;

                //cmd4.Parameters.Add("@maDonHang", SqlDbType.VarChar, 10).Value = maDonHang;
                //cmd4.Parameters.Add("@maMonAn", SqlDbType.VarChar, 10).Value =



                cmd3.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                conn.Close();

                // Tiếp tục xử lý newID ở đây
            }
        }
        public string LayMaTuDong(string tableName, string idColumn)
        {
            string newID = "";
            using (SqlConnection conn = new SqlConnection(sqlStringConnection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TuDongTangMaSo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@tableName", SqlDbType.VarChar, 30).Value = tableName;
                cmd.Parameters.Add("@idColumn", SqlDbType.VarChar, 30).Value = idColumn;
                SqlParameter outputID = cmd.Parameters.Add("@newID", SqlDbType.VarChar, 10);
                outputID.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                newID = outputID.Value.ToString();
                conn.Close();
            }
            return newID;
        }

        private void frmQLDHTrucTuyen_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
