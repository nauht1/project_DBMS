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
    public partial class frmXemCTPN : Form
    {
        SqlDataAdapter daCTPN = null;
        DataTable dtCTPN = null;
        public frmXemCTPN()
        {
            InitializeComponent();
        }

        private void frmXemCTPN_Load(object sender, EventArgs e)
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
                    daCTPN = new SqlDataAdapter("Select * from view_DanhSachChiTietPhieuNhap", conn);
                    dtCTPN = new DataTable();
                    dtCTPN.Clear();
                    daCTPN.Fill(dtCTPN);

                    dgvChiTietPN.DataSource = dtCTPN;
                    dgvChiTietPN.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
