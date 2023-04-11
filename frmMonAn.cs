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
    public partial class frmMonAn : Form
    {
        string sqlStringConnection = "Data Source = DESKTOP-ACER\\NAUHTSQLSERVER; " +
                "Initial Catalog = QLCuaHangDoAnNhanh; " +
                "User ID = sa; Password = 281003";
        List<MonAn> danhSachMonAn = new List<MonAn>();
        public frmMonAn()
        {
            InitializeComponent();
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sqlStringConnection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM view_DanhSachMonAnCon", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MonAn monAn = new MonAn();
                    monAn.MaMonAn = reader["MaMonAn"].ToString();
                    monAn.MaNguoiTao = reader["MaNguoiTao"].ToString();
                    monAn.TenMonAn = reader["TenMonAn"].ToString();
                    monAn.MoTa = reader["MoTa"].ToString();
                    monAn.DonGia = (float)reader["DonGia"];
                    monAn.SoLuongDuTru = (int)reader["SoLuongDuTru"];
                    danhSachMonAn.Add(monAn);
                }
                reader.Close();
            }
            int index = 0;
            foreach (MonAn monAn in danhSachMonAn)
            {
                PictureBox pb = new PictureBox();
                Label lb_tenMonAn = new Label();
                Label lb_moTaMonAn = new Label();
                Label lb_soLuongDuTruBan = new Label();
                Label lb_donGia = new Label();
                Panel pn = new Panel();
                pn.BorderStyle = BorderStyle.FixedSingle;
                pn.Width = 250;
                pn.Height = 320;

                pb.Image = Image.FromFile(monAn.HinhAnh);

                pb.Location = new Point(10, 10);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Width = 180;
                pb.Height = 100;

                lb_tenMonAn.Text = monAn.TenMonAn;
                lb_moTaMonAn.Text = monAn.MoTa;
                lb_soLuongDuTruBan.Text = "Còn lại: " + monAn.SoLuongDuTru.ToString();
                lb_donGia.Text = monAn.DonGia.ToString() + " VND";

                lb_tenMonAn.Location = new Point(10,120);
                lb_tenMonAn.AutoSize = true;

                lb_moTaMonAn.Font = new Font(lb_moTaMonAn.Font, FontStyle.Italic);
                lb_moTaMonAn.Location = new Point(10, 140);
                lb_tenMonAn.AutoSize = false;
                lb_moTaMonAn.Size = new Size(230, 100);

                lb_soLuongDuTruBan.Location = new Point(10, 240);
                lb_soLuongDuTruBan.AutoSize = true;

                lb_donGia.Location = new Point(10, 260);
                lb_donGia.AutoSize = true;
                lb_donGia.Font = new Font(lb_donGia.Font, FontStyle.Strikeout);
                pn.Controls.Add(lb_tenMonAn);
                pn.Controls.Add(lb_moTaMonAn);
                pn.Controls.Add(lb_soLuongDuTruBan);
                pn.Controls.Add(lb_donGia);

                flowLayoutPanel1.Controls.Add(pn);
                index++;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
