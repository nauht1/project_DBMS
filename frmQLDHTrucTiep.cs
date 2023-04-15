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

            if (dgvMonAn.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Lấy thông tin của dòng đó
                DataGridViewRow row = dgvMonAn.Rows[e.RowIndex];
                int rowIndex = -1;
                foreach (DataGridViewRow r in dgvGioHangTrucTiep.Rows)
                {
                    if (r.Cells["TenMonAnGH"].Value != null && r.Cells["TenMonAnGH"].Value.ToString() == row.Cells["TenMonAn"].Value.ToString())
                    {
                        rowIndex = r.Index;
                        break;
                    }
                }

                if (dgvGioHangTrucTiep.DataSource == null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("STT");
                    dt.Columns.Add("TenMonAnGH");
                    dt.Columns.Add("DonGiaGH");
                    dt.Columns.Add("SoLuongGH");
                    dt.Columns.Add("ThanhTien");
                    dgvGioHangTrucTiep.DataSource = dt;
                }

                if (rowIndex == -1)
                {
                    DataRow newRow = ((DataTable)dgvGioHangTrucTiep.DataSource).NewRow();
                    newRow["TenMonAnGH"] = row.Cells["TenMonAn"].Value;
                    newRow["DonGiaGH"] = row.Cells["DonGia"].Value;
                    newRow["SoLuongGH"] = 1; // Giá trị mặc định là 1

                    // Tính toán ThanhTien
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    decimal thanhTien = donGia * 1;
                    newRow["ThanhTien"] = thanhTien;
                    // Thêm dòng mới vào DataTable của DataGridView `dgvGioHangTrucTiep`
                    ((DataTable)dgvGioHangTrucTiep.DataSource).Rows.Add(newRow);
                }
                else
                {
                    DataGridViewRow r = dgvGioHangTrucTiep.Rows[rowIndex];
                    int soLuong = Convert.ToInt32(r.Cells["SoLuongGH"].Value);
                    soLuong++;
                    r.Cells["SoLuongGH"].Value = soLuong;

                    // Tính toán ThanhTien
                    decimal donGia = Convert.ToDecimal(r.Cells["DonGiaGH"].Value);
                    decimal thanhTien = donGia * soLuong;
                    r.Cells["ThanhTien"].Value = thanhTien;
                }
                dgvGioHangTrucTiep.Columns["TenMonAnGH"].HeaderText = "Tên Món";
                dgvGioHangTrucTiep.Columns["DonGiaGH"].HeaderText = "Đơn giá";
                dgvGioHangTrucTiep.Columns["SoLuongGH"].HeaderText = "Số lượng";
                dgvGioHangTrucTiep.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvGioHangTrucTiep.AutoResizeColumns();

                //Set chỉnh sửa số lượng trên dgv
                dgvGioHangTrucTiep.ReadOnly = false;
                dgvGioHangTrucTiep.Columns["TenMonAnGH"].ReadOnly = true;
                dgvGioHangTrucTiep.Columns["DonGiaGH"].ReadOnly = true;
                dgvGioHangTrucTiep.Columns["SoLuongGH"].ReadOnly = false;
                dgvGioHangTrucTiep.Columns["ThanhTien"].ReadOnly = true;
                dgvGioHangTrucTiep.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                dgvGioHangTrucTiep.CellEndEdit += DgvGioHangTrucTiep_CellEndEdit;
            }
        }

        private void DgvGioHangTrucTiep_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvGioHangTrucTiep.Columns[e.ColumnIndex].Name == "SoLuongGH")
            {
                DataGridViewRow row = dgvGioHangTrucTiep.Rows[e.RowIndex];
                int soLuong = Convert.ToInt32(row.Cells["SoLuongGH"].Value);
                decimal donGia = Convert.ToDecimal(row.Cells["DonGiaGH"].Value);
                decimal thanhTien = donGia * soLuong;
                row.Cells["ThanhTien"].Value = thanhTien;
            }
        }

        private void frmQLDHTrucTiep_Load(object sender, EventArgs e)
        {
            LoadMonAn();
            dgvGioHangTrucTiep.RowsAdded += DgvGioHangTrucTiep_RowsAdded;
        }

        private void DgvGioHangTrucTiep_RowsAdded(object? sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                DataGridViewRow row = dgvGioHangTrucTiep.Rows[i];
                row.Cells["STT"].Value = i + 1;
            }
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
                dgvMonAn.AutoResizeColumn(7);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
