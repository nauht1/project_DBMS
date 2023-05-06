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
    public partial class frmXemPN : Form
    {
        SqlDataAdapter daPhieuNhap = null;
        DataTable dtPhieuNhap = null;
        public frmXemPN()
        {
            InitializeComponent();
        }

        private void frmXemPN_Load(object sender, EventArgs e)
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
                    daPhieuNhap = new SqlDataAdapter("Select * from view_DanhSachPhieuNhap", conn);
                    dtPhieuNhap = new DataTable();
                    dtPhieuNhap.Clear();
                    daPhieuNhap.Fill(dtPhieuNhap);

                    dgvPhieuNhap.DataSource = dtPhieuNhap;
                    dgvPhieuNhap.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
