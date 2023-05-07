namespace QLCuaHangDoAnNhanhWP
{
    partial class frmQLDH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.MaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTaoDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrucTiep = new System.Windows.Forms.Button();
            this.btnTrucTuyen = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvDonHang);
            this.panel1.Location = new System.Drawing.Point(11, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 497);
            this.panel1.TabIndex = 0;
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonHang,
            this.MaKhachHang,
            this.NgayTaoDon,
            this.MaNhanVienBan,
            this.HinhThucThanhToan,
            this.TongTien});
            this.dgvDonHang.Location = new System.Drawing.Point(13, 20);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersWidth = 43;
            this.dgvDonHang.RowTemplate.Height = 27;
            this.dgvDonHang.Size = new System.Drawing.Size(858, 460);
            this.dgvDonHang.TabIndex = 0;
            // 
            // MaDonHang
            // 
            this.MaDonHang.DataPropertyName = "MaDonHang";
            this.MaDonHang.HeaderText = "Mã đơn";
            this.MaDonHang.Name = "MaDonHang";
            this.MaDonHang.ReadOnly = true;
            this.MaDonHang.Width = 105;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã KH";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            this.MaKhachHang.Width = 130;
            // 
            // NgayTaoDon
            // 
            this.NgayTaoDon.DataPropertyName = "NgayTaoDon";
            this.NgayTaoDon.HeaderText = "Ngày Tạo";
            this.NgayTaoDon.Name = "NgayTaoDon";
            this.NgayTaoDon.ReadOnly = true;
            this.NgayTaoDon.Width = 105;
            // 
            // MaNhanVienBan
            // 
            this.MaNhanVienBan.DataPropertyName = "MaNhanVienBan";
            this.MaNhanVienBan.HeaderText = "Nhân viên bán";
            this.MaNhanVienBan.Name = "MaNhanVienBan";
            this.MaNhanVienBan.ReadOnly = true;
            this.MaNhanVienBan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNhanVienBan.Width = 120;
            // 
            // HinhThucThanhToan
            // 
            this.HinhThucThanhToan.DataPropertyName = "HinhThucThanhToan";
            this.HinhThucThanhToan.HeaderText = "Hình Thức Thanh Toán";
            this.HinhThucThanhToan.Name = "HinhThucThanhToan";
            this.HinhThucThanhToan.ReadOnly = true;
            this.HinhThucThanhToan.Width = 105;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn hàng";
            // 
            // btnTrucTiep
            // 
            this.btnTrucTiep.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrucTiep.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTrucTiep.Location = new System.Drawing.Point(609, 6);
            this.btnTrucTiep.Name = "btnTrucTiep";
            this.btnTrucTiep.Size = new System.Drawing.Size(133, 34);
            this.btnTrucTiep.TabIndex = 1;
            this.btnTrucTiep.Text = "Đơn trực tiếp";
            this.btnTrucTiep.UseVisualStyleBackColor = true;
            this.btnTrucTiep.Click += new System.EventHandler(this.btnTrucTiep_Click);
            // 
            // btnTrucTuyen
            // 
            this.btnTrucTuyen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrucTuyen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTrucTuyen.Location = new System.Drawing.Point(750, 6);
            this.btnTrucTuyen.Name = "btnTrucTuyen";
            this.btnTrucTuyen.Size = new System.Drawing.Size(133, 34);
            this.btnTrucTuyen.TabIndex = 1;
            this.btnTrucTuyen.Text = "Đơn trực tuyến";
            this.btnTrucTuyen.UseVisualStyleBackColor = true;
            this.btnTrucTuyen.Click += new System.EventHandler(this.btnTrucTuyen_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReload.Location = new System.Drawing.Point(470, 6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(133, 34);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmQLDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 534);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnTrucTuyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrucTiep);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmQLDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn hàng";
            this.Load += new System.EventHandler(this.frmQLDH_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn MaDonHang;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn NgayTaoDon;
        private DataGridViewTextBoxColumn MaNhanVienBan;
        private DataGridViewTextBoxColumn HinhThucThanhToan;
        private DataGridViewTextBoxColumn TongTien;
        public DataGridView dgvDonHang;
        public Button btnTrucTiep;
        public Button btnTrucTuyen;
        public Button btnReload;
    }
}