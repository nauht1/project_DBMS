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
    public partial class frmQLDHTrucTiep : Form
    {
        string sqlStringConnection = "Data Source = DESKTOP-ACER\\NAUHTSQLSERVER; " +
                "Initial Catalog = QLCuaHangDoAnNhanh; " +
                "User ID = sa; Password = 281003";
        SqlConnection conn = null;
        SqlDataAdapter daMonAn = null;
        DataTable dtMonAn = null;
        DataView dtvMonAn = null;
        public frmQLDHTrucTiep()
        {
            InitializeComponent();
        }

        private void dgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmQLDHTrucTiep_Load(object sender, EventArgs e)
        {
            LoadMonAn();
        }
        public void LoadMonAn()
        {
            try
            {
                conn = new SqlConnection(sqlStringConnection);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                daMonAn = new SqlDataAdapter("SELECT * FROM view_DanhSachMonAnCon", conn);
                dtMonAn = new DataTable();
                dtMonAn.Clear();
                daMonAn.Fill(dtMonAn);

                dgvMonAn.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvMonAn_CellFormatting);
                dtvMonAn = new DataView(dtMonAn);
                dgvMonAn.DataSource = dtvMonAn;
                dgvMonAn.Columns["MaNguoiTao"].Visible = false;
            }
            catch
            {
                MessageBox.Show("Error!");
               
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvMonAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMonAn.Columns["HinhAnh"].Index && e.Value != null)
            {
                string imgPath = e.Value.ToString();
                if (File.Exists(imgPath))
                {
                    Image img = Image.FromFile(imgPath);
                    e.Value = img;
                }
            } 
        }
    }
}
