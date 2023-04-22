namespace QLCuaHangDoAnNhanhWP
{
    partial class frmNhapNguyenLieu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dgvGioNguyenLieu = new System.Windows.Forms.DataGridView();
            this.TenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemGio = new System.Windows.Forms.Button();
            this.dgvKhoNguyenLieu = new System.Windows.Forms.DataGridView();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemPhieu = new System.Windows.Forms.Button();
            this.btnXemCTPN = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(273, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(270, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đơn giá";
            // 
            // txtTenNL
            // 
            this.txtTenNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNL.Location = new System.Drawing.Point(92, 33);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(163, 25);
            this.txtTenNL.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(351, 33);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 25);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(92, 70);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(163, 25);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(351, 70);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(121, 25);
            this.txtTongTien.TabIndex = 2;
            // 
            // dgvGioNguyenLieu
            // 
            this.dgvGioNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNguyenLieu,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvGioNguyenLieu.Location = new System.Drawing.Point(22, 101);
            this.dgvGioNguyenLieu.Name = "dgvGioNguyenLieu";
            this.dgvGioNguyenLieu.ReadOnly = true;
            this.dgvGioNguyenLieu.RowHeadersWidth = 43;
            this.dgvGioNguyenLieu.RowTemplate.Height = 27;
            this.dgvGioNguyenLieu.Size = new System.Drawing.Size(569, 206);
            this.dgvGioNguyenLieu.TabIndex = 3;
            this.dgvGioNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioNguyenLieu_CellClick);
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.HeaderText = "Tên NL";
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            this.TenNguyenLieu.ReadOnly = true;
            this.TenNguyenLieu.Width = 105;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 105;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 105;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 105;
            // 
            // btnThemGio
            // 
            this.btnThemGio.BackColor = System.Drawing.Color.Chocolate;
            this.btnThemGio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemGio.Location = new System.Drawing.Point(494, 54);
            this.btnThemGio.Name = "btnThemGio";
            this.btnThemGio.Size = new System.Drawing.Size(97, 38);
            this.btnThemGio.TabIndex = 4;
            this.btnThemGio.Text = "Thêm giỏ";
            this.btnThemGio.UseVisualStyleBackColor = false;
            this.btnThemGio.Click += new System.EventHandler(this.btnThemGio_Click);
            // 
            // dgvKhoNguyenLieu
            // 
            this.dgvKhoNguyenLieu.AllowUserToAddRows = false;
            this.dgvKhoNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNguyenLieu,
            this.MaNQL,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvKhoNguyenLieu.Location = new System.Drawing.Point(23, 357);
            this.dgvKhoNguyenLieu.Name = "dgvKhoNguyenLieu";
            this.dgvKhoNguyenLieu.ReadOnly = true;
            this.dgvKhoNguyenLieu.RowHeadersWidth = 43;
            this.dgvKhoNguyenLieu.RowTemplate.Height = 27;
            this.dgvKhoNguyenLieu.Size = new System.Drawing.Size(569, 194);
            this.dgvKhoNguyenLieu.TabIndex = 5;
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.DataPropertyName = "MaNguyenLieu";
            this.MaNguyenLieu.HeaderText = "Mã NL";
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            this.MaNguyenLieu.ReadOnly = true;
            this.MaNguyenLieu.Width = 105;
            // 
            // MaNQL
            // 
            this.MaNQL.DataPropertyName = "MaNguoiQuanLy";
            this.MaNQL.HeaderText = "Mã NQL";
            this.MaNQL.Name = "MaNQL";
            this.MaNQL.ReadOnly = true;
            this.MaNQL.Width = 105;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenNguyenLieu";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên NL";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn2.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập thông tin của phiếu";
            // 
            // btnXemPhieu
            // 
            this.btnXemPhieu.BackColor = System.Drawing.Color.PeachPuff;
            this.btnXemPhieu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemPhieu.Location = new System.Drawing.Point(24, 557);
            this.btnXemPhieu.Name = "btnXemPhieu";
            this.btnXemPhieu.Size = new System.Drawing.Size(97, 38);
            this.btnXemPhieu.TabIndex = 7;
            this.btnXemPhieu.Text = "Xem phiếu";
            this.btnXemPhieu.UseVisualStyleBackColor = false;
            this.btnXemPhieu.Click += new System.EventHandler(this.btnXemPhieu_Click);
            // 
            // btnXemCTPN
            // 
            this.btnXemCTPN.BackColor = System.Drawing.Color.Tan;
            this.btnXemCTPN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemCTPN.Location = new System.Drawing.Point(147, 557);
            this.btnXemCTPN.Name = "btnXemCTPN";
            this.btnXemCTPN.Size = new System.Drawing.Size(97, 38);
            this.btnXemCTPN.TabIndex = 7;
            this.btnXemCTPN.Text = "Xem CTPN";
            this.btnXemCTPN.UseVisualStyleBackColor = false;
            this.btnXemCTPN.Click += new System.EventHandler(this.btnXemCTPN_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(375, 313);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTaoPhieu.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnTaoPhieu.Location = new System.Drawing.Point(494, 313);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(97, 38);
            this.btnTaoPhieu.TabIndex = 7;
            this.btnTaoPhieu.Text = "Tạo phiếu";
            this.btnTaoPhieu.UseVisualStyleBackColor = false;
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kho nguyên liệu";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.MistyRose;
            this.btnCapNhat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapNhat.Location = new System.Drawing.Point(494, 12);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(97, 36);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmNhapNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 602);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTaoPhieu);
            this.Controls.Add(this.btnXemCTPN);
            this.Controls.Add(this.btnXemPhieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKhoNguyenLieu);
            this.Controls.Add(this.btnThemGio);
            this.Controls.Add(this.dgvGioNguyenLieu);
            this.Controls.Add(this.txtTenNL);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmNhapNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập nguyên liệu";
            this.Load += new System.EventHandler(this.frmNhapNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoNguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTenNL;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private TextBox txtTongTien;
        private DataGridView dgvGioNguyenLieu;
        private Button btnThemGio;
        private DataGridView dgvKhoNguyenLieu;
        private Label label1;
        private Button btnXemPhieu;
        private Button btnXemCTPN;
        private DataGridViewTextBoxColumn MaNguyenLieu;
        private DataGridViewTextBoxColumn MaNQL;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button btnXoa;
        private Button btnTaoPhieu;
        private DataGridViewTextBoxColumn TenNguyenLieu;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private Label label6;
        private Button btnCapNhat;
    }
}