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
    public partial class frmChiTietMonAn : Form
    {
        SqlDataAdapter daMonAn = null;
        DataTable dtMonAn = null;
        public frmChiTietMonAn()
        {
            InitializeComponent();
        }

        private void frmChiTietMonAn_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            using (SqlConnection conn = ClassConnection.Connection)
            {
                conn.Open();
                daMonAn = new SqlDataAdapter("SELECT * FROM view_DanhSachTatCaCacMonAn", conn);
                dtMonAn = new DataTable();
                dtMonAn.Clear();
                daMonAn.Fill(dtMonAn);
                dgvMonAn.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvMonAn_CellFormatting);
                dgvMonAn.DataSource = dtMonAn;
                dgvMonAn.AllowUserToAddRows = false;
                dgvMonAn.AutoResizeColumns();
                dgvMonAn.Columns["CT_HinhAnh"].Width = 120;
                dgvMonAn.Columns["CT_TrangThai"].DisplayIndex = 4;
            }
        }

        private void dgvMonAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMonAn.Columns["CT_HinhAnh"].Index && e.Value != null)
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
