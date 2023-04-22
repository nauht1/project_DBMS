namespace QLCuaHangDoAnNhanhWP
{
    partial class frmChiTietMonAn
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
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.CT_MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_MaNguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.CT_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_SoLuongDuTru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CT_MaMon,
            this.CT_MaNguoiTao,
            this.CT_TenMon,
            this.CT_HinhAnh,
            this.CT_DonGia,
            this.CT_SoLuongDuTru,
            this.CT_TrangThai,
            this.CT_MoTa});
            this.dgvMonAn.Location = new System.Drawing.Point(12, 33);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersWidth = 43;
            this.dgvMonAn.RowTemplate.Height = 50;
            this.dgvMonAn.Size = new System.Drawing.Size(786, 405);
            this.dgvMonAn.TabIndex = 0;
            this.dgvMonAn.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMonAn_CellFormatting);
            // 
            // CT_MaMon
            // 
            this.CT_MaMon.DataPropertyName = "MaMonAn";
            this.CT_MaMon.HeaderText = "Mã Món";
            this.CT_MaMon.Name = "CT_MaMon";
            this.CT_MaMon.ReadOnly = true;
            this.CT_MaMon.Width = 105;
            // 
            // CT_MaNguoiTao
            // 
            this.CT_MaNguoiTao.DataPropertyName = "MaNguoiTao";
            this.CT_MaNguoiTao.HeaderText = "Mã người tạo";
            this.CT_MaNguoiTao.Name = "CT_MaNguoiTao";
            this.CT_MaNguoiTao.ReadOnly = true;
            this.CT_MaNguoiTao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CT_MaNguoiTao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CT_MaNguoiTao.Width = 105;
            // 
            // CT_TenMon
            // 
            this.CT_TenMon.DataPropertyName = "TenMonAn";
            this.CT_TenMon.HeaderText = "Tên món";
            this.CT_TenMon.Name = "CT_TenMon";
            this.CT_TenMon.ReadOnly = true;
            this.CT_TenMon.Width = 105;
            // 
            // CT_HinhAnh
            // 
            this.CT_HinhAnh.DataPropertyName = "HinhAnh";
            this.CT_HinhAnh.HeaderText = "Hình ảnh";
            this.CT_HinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.CT_HinhAnh.Name = "CT_HinhAnh";
            this.CT_HinhAnh.ReadOnly = true;
            this.CT_HinhAnh.Width = 105;
            // 
            // CT_DonGia
            // 
            this.CT_DonGia.DataPropertyName = "DonGia";
            this.CT_DonGia.HeaderText = "Đơn giá";
            this.CT_DonGia.Name = "CT_DonGia";
            this.CT_DonGia.ReadOnly = true;
            this.CT_DonGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CT_DonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CT_DonGia.Width = 105;
            // 
            // CT_SoLuongDuTru
            // 
            this.CT_SoLuongDuTru.DataPropertyName = "SoLuongDuTru";
            this.CT_SoLuongDuTru.HeaderText = "Còn lại";
            this.CT_SoLuongDuTru.Name = "CT_SoLuongDuTru";
            this.CT_SoLuongDuTru.ReadOnly = true;
            this.CT_SoLuongDuTru.Width = 105;
            // 
            // CT_TrangThai
            // 
            this.CT_TrangThai.DataPropertyName = "TrangThai";
            this.CT_TrangThai.HeaderText = "Trạng thái";
            this.CT_TrangThai.Name = "CT_TrangThai";
            this.CT_TrangThai.ReadOnly = true;
            this.CT_TrangThai.Width = 105;
            // 
            // CT_MoTa
            // 
            this.CT_MoTa.DataPropertyName = "MoTa";
            this.CT_MoTa.HeaderText = "Mô tả";
            this.CT_MoTa.Name = "CT_MoTa";
            this.CT_MoTa.ReadOnly = true;
            this.CT_MoTa.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tất cả món ăn ";
            // 
            // frmChiTietMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiTietMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Các món ăn có trong hệ thống";
            this.Load += new System.EventHandler(this.frmChiTietMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMonAn;
        private Label label1;
        private DataGridViewTextBoxColumn CT_MaMon;
        private DataGridViewTextBoxColumn CT_MaNguoiTao;
        private DataGridViewTextBoxColumn CT_TenMon;
        private DataGridViewImageColumn CT_HinhAnh;
        private DataGridViewTextBoxColumn CT_DonGia;
        private DataGridViewTextBoxColumn CT_SoLuongDuTru;
        private DataGridViewTextBoxColumn CT_TrangThai;
        private DataGridViewTextBoxColumn CT_MoTa;
    }
}