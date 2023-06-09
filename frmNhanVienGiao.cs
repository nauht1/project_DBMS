﻿using System;
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
    public partial class frmNhanVienGiao : Form
    {
        SqlDataAdapter daNhanVienGiao = null;
        DataTable dtNhanVienGiao = null;
        private string strConn = frmLogin.strConn;
        public frmNhanVienGiao()
        {
            InitializeComponent();
        }

        private void frmNhanVienGiao_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    daNhanVienGiao = new SqlDataAdapter("Select * from view_DanhSachTatCaNhanVienGiaoHang", conn);
                    dtNhanVienGiao = new DataTable();
                    dtNhanVienGiao.Clear();
                    daNhanVienGiao.Fill(dtNhanVienGiao);

                    dtNhanVienGiao.Columns.Add("TrangThai");
                    foreach (DataRow item in dtNhanVienGiao.Rows)
                    {
                        string maNhanVien = item[0].ToString();

                        SqlCommand cmd = new SqlCommand("Select dbo.func_KiemTraTrangThaiNhanVienGiao(@maNhanVien)", conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar, 10).Value = maNhanVien;

                        item["TrangThai"] = cmd.ExecuteScalar().ToString();
                    }

                    dgvNhanVienGiao.DataSource = dtNhanVienGiao;
                    dgvNhanVienGiao.AutoResizeColumns();
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu!");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvNhanVienGiao.SelectedCells.Count > 0) 
            {
                int rowIndex = dgvNhanVienGiao.SelectedCells[0].RowIndex; 
                DataGridViewRow selectedRow = dgvNhanVienGiao.Rows[rowIndex]; 

                string maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString(); 
                frmQLDHTrucTuyen frm = (frmQLDHTrucTuyen)this.Owner; 
                frm.txtNhanVien.Text = maNhanVien;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xác nhận đơn hàng", "Thông báo");
            }
        }
        private void dgvNhanVienGiao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
