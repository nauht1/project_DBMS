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
    public partial class frmQLDH : Form
    {
        SqlDataAdapter daDonHang = null;
        DataTable dtDonHang = null;
        public frmQLDH()
        {
            InitializeComponent();
        }

        private void frmQLDH_Load(object sender, EventArgs e)
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
                    daDonHang = new SqlDataAdapter("Select * from view_DanhSachDonHang", conn);
                    dtDonHang = new DataTable();
                    dtDonHang.Clear();
                    daDonHang.Fill(dtDonHang);

                    dgvDonHang.DataSource = dtDonHang;
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu!!");
            }
        }
    }
}
