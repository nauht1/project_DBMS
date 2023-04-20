namespace QLCuaHangDoAnNhanhWP
{
    partial class frmQLMonAn
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnhMonAn = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaNguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDuTru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTaoMon = new System.Windows.Forms.Button();
            this.txtSoLuongDuTru = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pbMonAn = new System.Windows.Forms.PictureBox();
            this.lb_Ethnic = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.lb_PoB = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lb_Fullname = new System.Windows.Forms.Label();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtMaMon);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.dgvMonAn);
            this.panel3.Controls.Add(this.txtDonGia);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnTaoMon);
            this.panel3.Controls.Add(this.txtSoLuongDuTru);
            this.panel3.Controls.Add(this.txtMoTa);
            this.panel3.Controls.Add(this.btnUpload);
            this.panel3.Controls.Add(this.pbMonAn);
            this.panel3.Controls.Add(this.lb_Ethnic);
            this.panel3.Controls.Add(this.lb_Gender);
            this.panel3.Controls.Add(this.lb_PoB);
            this.panel3.Controls.Add(this.txtTenMon);
            this.panel3.Controls.Add(this.lb_Fullname);
            this.panel3.Location = new System.Drawing.Point(11, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 558);
            this.panel3.TabIndex = 65;
            // 
            // txtMaMon
            // 
            this.txtMaMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaMon.Location = new System.Drawing.Point(96, 10);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(118, 25);
            this.txtMaMon.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 126;
            this.label1.Text = "Mã món";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnReload.Location = new System.Drawing.Point(14, 503);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(79, 39);
            this.btnReload.TabIndex = 125;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightYellow;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(127, 504);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 42);
            this.btnXoa.TabIndex = 125;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLuu.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLuu.Location = new System.Drawing.Point(521, 504);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 42);
            this.btnLuu.TabIndex = 125;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightYellow;
            this.btnSua.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(252, 504);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 42);
            this.btnSua.TabIndex = 125;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.HinhAnhMonAn,
            this.MaNguoiTao,
            this.SoLuongDuTru,
            this.DonGia,
            this.MoTa});
            this.dgvMonAn.Location = new System.Drawing.Point(14, 221);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersWidth = 43;
            this.dgvMonAn.RowTemplate.Height = 50;
            this.dgvMonAn.Size = new System.Drawing.Size(728, 266);
            this.dgvMonAn.TabIndex = 124;
            this.dgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            this.dgvMonAn.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMonAn_CellFormatting);
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMonAn";
            this.MaMon.HeaderText = "Mã món";
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            this.MaMon.Width = 65;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMonAn";
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            this.TenMon.Width = 105;
            // 
            // HinhAnhMonAn
            // 
            this.HinhAnhMonAn.DataPropertyName = "HinhAnh";
            this.HinhAnhMonAn.HeaderText = "Hình ảnh";
            this.HinhAnhMonAn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.HinhAnhMonAn.Name = "HinhAnhMonAn";
            this.HinhAnhMonAn.ReadOnly = true;
            this.HinhAnhMonAn.Width = 105;
            // 
            // MaNguoiTao
            // 
            this.MaNguoiTao.DataPropertyName = "MaNguoiTao";
            this.MaNguoiTao.HeaderText = "Mã người tạo";
            this.MaNguoiTao.Name = "MaNguoiTao";
            this.MaNguoiTao.ReadOnly = true;
            this.MaNguoiTao.Width = 65;
            // 
            // SoLuongDuTru
            // 
            this.SoLuongDuTru.DataPropertyName = "SoLuongDuTru";
            this.SoLuongDuTru.HeaderText = "Còn lại";
            this.SoLuongDuTru.Name = "SoLuongDuTru";
            this.SoLuongDuTru.ReadOnly = true;
            this.SoLuongDuTru.Width = 105;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 105;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 105;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(398, 55);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(135, 25);
            this.txtDonGia.TabIndex = 123;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Location = new System.Drawing.Point(649, 503);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 43);
            this.btnHuy.TabIndex = 65;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTaoMon
            // 
            this.btnTaoMon.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnTaoMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTaoMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoMon.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnTaoMon.Location = new System.Drawing.Point(388, 504);
            this.btnTaoMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoMon.Name = "btnTaoMon";
            this.btnTaoMon.Size = new System.Drawing.Size(92, 42);
            this.btnTaoMon.TabIndex = 66;
            this.btnTaoMon.Text = "Thêm";
            this.btnTaoMon.UseVisualStyleBackColor = false;
            this.btnTaoMon.Click += new System.EventHandler(this.btnTaoMon_Click);
            // 
            // txtSoLuongDuTru
            // 
            this.txtSoLuongDuTru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongDuTru.Location = new System.Drawing.Point(398, 147);
            this.txtSoLuongDuTru.Name = "txtSoLuongDuTru";
            this.txtSoLuongDuTru.Size = new System.Drawing.Size(64, 25);
            this.txtSoLuongDuTru.TabIndex = 123;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTa.Location = new System.Drawing.Point(97, 101);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(276, 87);
            this.txtMoTa.TabIndex = 123;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.Location = new System.Drawing.Point(571, 149);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(171, 39);
            this.btnUpload.TabIndex = 53;
            this.btnUpload.Text = "TẢI ẢNH LÊN";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pbMonAn
            // 
            this.pbMonAn.BackColor = System.Drawing.Color.Snow;
            this.pbMonAn.Location = new System.Drawing.Point(571, 14);
            this.pbMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.pbMonAn.Name = "pbMonAn";
            this.pbMonAn.Size = new System.Drawing.Size(171, 125);
            this.pbMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMonAn.TabIndex = 52;
            this.pbMonAn.TabStop = false;
            // 
            // lb_Ethnic
            // 
            this.lb_Ethnic.AutoSize = true;
            this.lb_Ethnic.BackColor = System.Drawing.Color.Transparent;
            this.lb_Ethnic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Ethnic.Location = new System.Drawing.Point(396, 118);
            this.lb_Ethnic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Ethnic.Name = "lb_Ethnic";
            this.lb_Ethnic.Size = new System.Drawing.Size(120, 21);
            this.lb_Ethnic.TabIndex = 88;
            this.lb_Ethnic.Text = "Số lượng dự trù";
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.BackColor = System.Drawing.Color.Transparent;
            this.lb_Gender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Gender.Location = new System.Drawing.Point(398, 31);
            this.lb_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(64, 21);
            this.lb_Gender.TabIndex = 87;
            this.lb_Gender.Text = "Đơn giá";
            // 
            // lb_PoB
            // 
            this.lb_PoB.AutoSize = true;
            this.lb_PoB.BackColor = System.Drawing.Color.Transparent;
            this.lb_PoB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_PoB.Location = new System.Drawing.Point(14, 101);
            this.lb_PoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PoB.Name = "lb_PoB";
            this.lb_PoB.Size = new System.Drawing.Size(52, 21);
            this.lb_PoB.TabIndex = 86;
            this.lb_PoB.Text = "Mô tả";
            // 
            // txtTenMon
            // 
            this.txtTenMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenMon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenMon.Location = new System.Drawing.Point(97, 52);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(275, 28);
            this.txtTenMon.TabIndex = 84;
            // 
            // lb_Fullname
            // 
            this.lb_Fullname.AutoSize = true;
            this.lb_Fullname.BackColor = System.Drawing.Color.Transparent;
            this.lb_Fullname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Fullname.Location = new System.Drawing.Point(14, 54);
            this.lb_Fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Fullname.Name = "lb_Fullname";
            this.lb_Fullname.Size = new System.Drawing.Size(70, 21);
            this.lb_Fullname.TabIndex = 83;
            this.lb_Fullname.Text = "Tên Món";
            // 
            // MaMonAn
            // 
            this.MaMonAn.DataPropertyName = "MaMonAn";
            this.MaMonAn.HeaderText = "Mã món";
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.Width = 65;
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên món";
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Width = 105;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaMonAn";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã món";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenMonAn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên món";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 105;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã món";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên món";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 105;
            // 
            // frmQLMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 578);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmQLMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý món ăn";
            this.Load += new System.EventHandler(this.frmQLMonAn_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private TextBox txtDonGia;
        private Button btnHuy;
        private Button btnTaoMon;
        private TextBox txtSoLuongDuTru;
        private TextBox txtMoTa;
        private Button btnUpload;
        private PictureBox pbMonAn;
        private Label lb_Ethnic;
        private Label lb_Gender;
        private Label lb_PoB;
        private TextBox txtTenMon;
        private Label lb_Fullname;
        private DataGridView dgvMonAn;
        private Button btnReload;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private DataGridViewTextBoxColumn MaMonAn;
        private DataGridViewTextBoxColumn TenMonAn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewImageColumn HinhAnhMonAn;
        private DataGridViewTextBoxColumn MaNguoiTao;
        private DataGridViewTextBoxColumn SoLuongDuTru;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn MoTa;
        private TextBox txtMaMon;
        private Label label1;
    }
}