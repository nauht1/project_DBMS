using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoAnNhanhWP
{
    public partial class frmCTDH : Form
    {
        SqlDataAdapter daCTDH = null;
        DataTable dtCTDH = null;
        public frmCTDH()
        {
            InitializeComponent();
        }

        private void frmCTDH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(frmLogin.strConn))
                {
                    conn.Open();
                    daCTDH = new SqlDataAdapter("Select * from view_DanhSachChiTietDonHang", conn);
                    dtCTDH = new DataTable();
                    dtCTDH.Clear();
                    daCTDH.Fill(dtCTDH);
                    dgvCTDH.DataSource = dtCTDH;
                    dgvCTDH.AutoResizeColumns();
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu!!");
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiemDonHangTheoMa();
        }
        public void TimKiemDonHangTheoMa()
        {
            using (SqlConnection conn = new SqlConnection(frmLogin.strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKiemCTDHTheoMa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDonHang", SqlDbType.VarChar).Value = txtMaDonHang.Text;
                SqlDataAdapter daCTDH = new SqlDataAdapter(cmd);
                DataTable dtCTDH = new DataTable();
                daCTDH.Fill(dtCTDH);
                dgvCTDH.DataSource = dtCTDH;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
