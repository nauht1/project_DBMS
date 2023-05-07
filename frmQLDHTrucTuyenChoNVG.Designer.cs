namespace QLCuaHangDoAnNhanhWP
{
    partial class frmQLDHTrucTuyenChoNVG
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXemDon = new System.Windows.Forms.Button();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.dgvDonGX = new System.Windows.Forms.DataGridView();
            this.MaDonHangGX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVienGiaoGX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiDonHangGX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonDG = new System.Windows.Forms.DataGridView();
            this.MaDonHangDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVienGiaoDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiDonHangDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemCTDH = new System.Windows.Forms.Button();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonGX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 23);
            this.label8.TabIndex = 70;
            this.label8.Text = "Quản lý đơn trực tuyến";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnXemDon);
            this.panel3.Controls.Add(this.txtThanhToan);
            this.panel3.Controls.Add(this.dgvDonGX);
            this.panel3.Controls.Add(this.dgvDonDG);
            this.panel3.Controls.Add(this.btnXemCTDH);
            this.panel3.Controls.Add(this.txtNhanVien);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnXacNhan);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(34, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 587);
            this.panel3.TabIndex = 69;
            // 
            // btnXemDon
            // 
            this.btnXemDon.BackColor = System.Drawing.Color.MistyRose;
            this.btnXemDon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemDon.Location = new System.Drawing.Point(566, 483);
            this.btnXemDon.Name = "btnXemDon";
            this.btnXemDon.Size = new System.Drawing.Size(113, 43);
            this.btnXemDon.TabIndex = 144;
            this.btnXemDon.Text = "Xem đơn";
            this.btnXemDon.UseVisualStyleBackColor = false;
            this.btnXemDon.Click += new System.EventHandler(this.btnXemDon_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhToan.Enabled = false;
            this.txtThanhToan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtThanhToan.Location = new System.Drawing.Point(669, 256);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(191, 28);
            this.txtThanhToan.TabIndex = 143;
            // 
            // dgvDonGX
            // 
            this.dgvDonGX.AllowUserToAddRows = false;
            this.dgvDonGX.AllowUserToDeleteRows = false;
            this.dgvDonGX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonGX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonHangGX,
            this.MaNhanVienGiaoGX,
            this.TrangThaiDonHangGX});
            this.dgvDonGX.Location = new System.Drawing.Point(17, 290);
            this.dgvDonGX.Name = "dgvDonGX";
            this.dgvDonGX.ReadOnly = true;
            this.dgvDonGX.RowHeadersWidth = 43;
            this.dgvDonGX.RowTemplate.Height = 27;
            this.dgvDonGX.Size = new System.Drawing.Size(494, 283);
            this.dgvDonGX.TabIndex = 142;
            this.dgvDonGX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonGX_CellClick);
            // 
            // MaDonHangGX
            // 
            this.MaDonHangGX.DataPropertyName = "MaDonHang";
            this.MaDonHangGX.HeaderText = "Mã đơn";
            this.MaDonHangGX.Name = "MaDonHangGX";
            this.MaDonHangGX.ReadOnly = true;
            this.MaDonHangGX.Width = 120;
            // 
            // MaNhanVienGiaoGX
            // 
            this.MaNhanVienGiaoGX.DataPropertyName = "MaNhanVienGiao";
            this.MaNhanVienGiaoGX.HeaderText = "Nhân viên giao";
            this.MaNhanVienGiaoGX.Name = "MaNhanVienGiaoGX";
            this.MaNhanVienGiaoGX.ReadOnly = true;
            this.MaNhanVienGiaoGX.Width = 105;
            // 
            // TrangThaiDonHangGX
            // 
            this.TrangThaiDonHangGX.DataPropertyName = "TrangThaiDonHang";
            this.TrangThaiDonHangGX.HeaderText = "Trạng thái";
            this.TrangThaiDonHangGX.Name = "TrangThaiDonHangGX";
            this.TrangThaiDonHangGX.ReadOnly = true;
            this.TrangThaiDonHangGX.Width = 50;
            // 
            // dgvDonDG
            // 
            this.dgvDonDG.AllowUserToAddRows = false;
            this.dgvDonDG.AllowUserToDeleteRows = false;
            this.dgvDonDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonHangDG,
            this.MaNhanVienGiaoDG,
            this.TrangThaiDonHangDG});
            this.dgvDonDG.Location = new System.Drawing.Point(17, 11);
            this.dgvDonDG.Name = "dgvDonDG";
            this.dgvDonDG.ReadOnly = true;
            this.dgvDonDG.RowHeadersWidth = 43;
            this.dgvDonDG.RowTemplate.Height = 27;
            this.dgvDonDG.Size = new System.Drawing.Size(494, 270);
            this.dgvDonDG.TabIndex = 141;
            this.dgvDonDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonDG_CellClick);
            // 
            // MaDonHangDG
            // 
            this.MaDonHangDG.DataPropertyName = "MaDonHang";
            this.MaDonHangDG.HeaderText = "Mã đơn";
            this.MaDonHangDG.Name = "MaDonHangDG";
            this.MaDonHangDG.ReadOnly = true;
            this.MaDonHangDG.Width = 120;
            // 
            // MaNhanVienGiaoDG
            // 
            this.MaNhanVienGiaoDG.DataPropertyName = "MaNhanVienGiao";
            this.MaNhanVienGiaoDG.HeaderText = "Nhân viên giao";
            this.MaNhanVienGiaoDG.Name = "MaNhanVienGiaoDG";
            this.MaNhanVienGiaoDG.ReadOnly = true;
            this.MaNhanVienGiaoDG.Width = 105;
            // 
            // TrangThaiDonHangDG
            // 
            this.TrangThaiDonHangDG.DataPropertyName = "TrangThaiDonHang";
            this.TrangThaiDonHangDG.HeaderText = "Trạng thái";
            this.TrangThaiDonHangDG.Name = "TrangThaiDonHangDG";
            this.TrangThaiDonHangDG.ReadOnly = true;
            this.TrangThaiDonHangDG.Width = 50;
            // 
            // btnXemCTDH
            // 
            this.btnXemCTDH.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXemCTDH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemCTDH.Location = new System.Drawing.Point(566, 532);
            this.btnXemCTDH.Name = "btnXemCTDH";
            this.btnXemCTDH.Size = new System.Drawing.Size(113, 41);
            this.btnXemCTDH.TabIndex = 140;
            this.btnXemCTDH.Text = "Xem CTDH";
            this.btnXemCTDH.UseVisualStyleBackColor = false;
            this.btnXemCTDH.Click += new System.EventHandler(this.btnXemCTDH_Click);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNhanVien.Location = new System.Drawing.Point(669, 324);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(191, 28);
            this.txtNhanVien.TabIndex = 135;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(550, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 133;
            this.label7.Text = "Nhân viên giao";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTongTien.Location = new System.Drawing.Point(669, 290);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(191, 28);
            this.txtTongTien.TabIndex = 131;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(550, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 124;
            this.label5.Text = "Tổng tiền";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Location = new System.Drawing.Point(822, 532);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 43);
            this.btnThoat.TabIndex = 130;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.YellowGreen;
            this.btnXacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.Location = new System.Drawing.Point(694, 532);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(115, 43);
            this.btnXacNhan.TabIndex = 129;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(550, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 124;
            this.label6.Text = "Thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(572, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDienThoai);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Location = new System.Drawing.Point(550, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 200);
            this.panel1.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 124;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 124;
            this.label3.Text = "Địa Chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 124;
            this.label1.Text = "Họ Tên";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDienThoai.Enabled = false;
            this.txtDienThoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDienThoai.Location = new System.Drawing.Point(118, 59);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(228, 28);
            this.txtDienThoai.TabIndex = 84;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDiaChi.Location = new System.Drawing.Point(118, 97);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(228, 80);
            this.txtDiaChi.TabIndex = 84;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHoTen.Location = new System.Drawing.Point(118, 20);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(228, 28);
            this.txtHoTen.TabIndex = 84;
            // 
            // frmQLDHTrucTuyenChoNVG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 622);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmQLDHTrucTuyenChoNVG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLDHTrucTuyenChoNVG";
            this.Load += new System.EventHandler(this.frmQLDHTrucTuyenChoNVG_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonGX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Panel panel3;
        private Button btnXemDon;
        private TextBox txtThanhToan;
        public DataGridView dgvDonGX;
        private DataGridViewTextBoxColumn MaDonHangGX;
        private DataGridViewTextBoxColumn MaNhanVienGiaoGX;
        private DataGridViewTextBoxColumn TrangThaiDonHangGX;
        public DataGridView dgvDonDG;
        private DataGridViewTextBoxColumn MaDonHangDG;
        private DataGridViewTextBoxColumn MaNhanVienGiaoDG;
        private DataGridViewTextBoxColumn TrangThaiDonHangDG;
        private Button btnXemCTDH;
        public TextBox txtNhanVien;
        private Label label7;
        private TextBox txtTongTien;
        private Label label5;
        private Button btnThoat;
        private Button btnXacNhan;
        private Label label6;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
    }
}