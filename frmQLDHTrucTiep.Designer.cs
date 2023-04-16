namespace QLCuaHangDoAnNhanhWP
{
    partial class frmQLDHTrucTiep
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvGioHangTrucTiep = new System.Windows.Forms.DataGridView();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboThanhToan = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.Chon = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.ConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pnKH = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHangTrucTiep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.pnKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 70;
            this.label8.Text = "Đơn trực tiếp";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtGhiChu);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dgvGioHangTrucTiep);
            this.panel3.Controls.Add(this.txtTenMon);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cboThanhToan);
            this.panel3.Controls.Add(this.btnTim);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnXacNhan);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dgvMonAn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pnKH);
            this.panel3.Location = new System.Drawing.Point(24, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1096, 594);
            this.panel3.TabIndex = 71;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Location = new System.Drawing.Point(822, 286);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(228, 73);
            this.txtGhiChu.TabIndex = 139;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(716, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 138;
            this.label9.Text = "Ghi chú";
            // 
            // dgvGioHangTrucTiep
            // 
            this.dgvGioHangTrucTiep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHangTrucTiep.Location = new System.Drawing.Point(17, 52);
            this.dgvGioHangTrucTiep.Name = "dgvGioHangTrucTiep";
            this.dgvGioHangTrucTiep.ReadOnly = true;
            this.dgvGioHangTrucTiep.RowHeadersWidth = 43;
            this.dgvGioHangTrucTiep.RowTemplate.Height = 27;
            this.dgvGioHangTrucTiep.Size = new System.Drawing.Size(645, 259);
            this.dgvGioHangTrucTiep.TabIndex = 137;
            // 
            // txtTenMon
            // 
            this.txtTenMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenMon.Location = new System.Drawing.Point(131, 14);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(234, 25);
            this.txtTenMon.TabIndex = 136;
            this.txtTenMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 135;
            this.label1.Text = "Nhập tên món";
            // 
            // cboThanhToan
            // 
            this.cboThanhToan.FormattingEnabled = true;
            this.cboThanhToan.Items.AddRange(new object[] {
            "TM",
            "CK"});
            this.cboThanhToan.Location = new System.Drawing.Point(894, 385);
            this.cboThanhToan.Name = "cboThanhToan";
            this.cboThanhToan.Size = new System.Drawing.Size(156, 25);
            this.cboThanhToan.TabIndex = 134;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.YellowGreen;
            this.btnTim.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.Location = new System.Drawing.Point(371, 8);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(74, 34);
            this.btnTim.TabIndex = 133;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(894, 422);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(156, 25);
            this.txtTongTien.TabIndex = 131;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(716, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 124;
            this.label5.Text = "Tổng tiền";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Location = new System.Drawing.Point(821, 535);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(126, 43);
            this.btnHuy.TabIndex = 130;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.YellowGreen;
            this.btnXacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.Location = new System.Drawing.Point(958, 535);
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
            this.label6.Location = new System.Drawing.Point(716, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 21);
            this.label6.TabIndex = 124;
            this.label6.Text = "Hình thức thanh toán";
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.MaMonAn,
            this.TenMonAn,
            this.HinhAnh,
            this.ConLai,
            this.DonGia,
            this.MoTa});
            this.dgvMonAn.Location = new System.Drawing.Point(17, 319);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersWidth = 43;
            this.dgvMonAn.RowTemplate.Height = 50;
            this.dgvMonAn.Size = new System.Drawing.Size(645, 259);
            this.dgvMonAn.TabIndex = 128;
            this.dgvMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellContentClick);
            this.dgvMonAn.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMonAn_CellFormatting);
            // 
            // Chon
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.Chon.DefaultCellStyle = dataGridViewCellStyle1;
            this.Chon.Frozen = true;
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            this.Chon.ReadOnly = true;
            this.Chon.Text = "Chọn";
            this.Chon.Width = 40;
            // 
            // MaMonAn
            // 
            this.MaMonAn.DataPropertyName = "MaMonAn";
            this.MaMonAn.HeaderText = "Mã món";
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.ReadOnly = true;
            this.MaMonAn.Width = 80;
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên Món";
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.ReadOnly = true;
            this.TenMonAn.Width = 120;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.FillWeight = 300F;
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            this.HinhAnh.Width = 120;
            // 
            // ConLai
            // 
            this.ConLai.DataPropertyName = "SoLuongDuTru";
            this.ConLai.HeaderText = "Còn lại";
            this.ConLai.Name = "ConLai";
            this.ConLai.ReadOnly = true;
            this.ConLai.Width = 80;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 105;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(725, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // pnKH
            // 
            this.pnKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnKH.Controls.Add(this.label4);
            this.pnKH.Controls.Add(this.label3);
            this.pnKH.Controls.Add(this.label7);
            this.pnKH.Controls.Add(this.txtSoDienThoai);
            this.pnKH.Controls.Add(this.txtDiaChi);
            this.pnKH.Controls.Add(this.txtHoTen);
            this.pnKH.Location = new System.Drawing.Point(703, 64);
            this.pnKH.Name = "pnKH";
            this.pnKH.Size = new System.Drawing.Size(371, 200);
            this.pnKH.TabIndex = 125;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 124;
            this.label7.Text = "Họ Tên";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoDienThoai.Location = new System.Drawing.Point(118, 59);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(228, 28);
            this.txtSoDienThoai.TabIndex = 84;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiaChi.Location = new System.Drawing.Point(117, 97);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(228, 80);
            this.txtDiaChi.TabIndex = 84;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoTen.Location = new System.Drawing.Point(118, 20);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(228, 28);
            this.txtHoTen.TabIndex = 84;
            // 
            // frmQLDHTrucTiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 628);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmQLDHTrucTiep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng trực tiếp";
            this.Load += new System.EventHandler(this.frmQLDHTrucTiep_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHangTrucTiep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.pnKH.ResumeLayout(false);
            this.pnKH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Panel panel3;
        private TextBox txtTongTien;
        private Label label5;
        private Button btnHuy;
        private Button btnXacNhan;
        private Label label6;
        private DataGridView dgvMonAn;
        private Label label2;
        private Panel pnKH;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private Button btnTim;
        private ComboBox cboThanhToan;
        private TextBox txtTenMon;
        private Label label1;
        private DataGridView dgvGioHangTrucTiep;
        private DataGridViewButtonColumn Chon;
        private DataGridViewTextBoxColumn MaMonAn;
        private DataGridViewTextBoxColumn TenMonAn;
        private DataGridViewImageColumn HinhAnh;
        private DataGridViewTextBoxColumn ConLai;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn MoTa;
        private TextBox txtGhiChu;
        private Label label9;
    }
}