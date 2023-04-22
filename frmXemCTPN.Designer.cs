namespace QLCuaHangDoAnNhanhWP
{
    partial class frmXemCTPN
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
            this.dgvChiTietPN = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietPN
            // 
            this.dgvChiTietPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.MaNL,
            this.SL,
            this.DG});
            this.dgvChiTietPN.Location = new System.Drawing.Point(15, 12);
            this.dgvChiTietPN.Name = "dgvChiTietPN";
            this.dgvChiTietPN.ReadOnly = true;
            this.dgvChiTietPN.RowHeadersWidth = 43;
            this.dgvChiTietPN.RowTemplate.Height = 27;
            this.dgvChiTietPN.Size = new System.Drawing.Size(549, 349);
            this.dgvChiTietPN.TabIndex = 0;
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "MaPhieuNhap";
            this.MaPN.HeaderText = "Mã Phiếu";
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            this.MaPN.Width = 105;
            // 
            // MaNL
            // 
            this.MaNL.DataPropertyName = "MaNguyenLieu";
            this.MaNL.HeaderText = "Mã NL";
            this.MaNL.Name = "MaNL";
            this.MaNL.ReadOnly = true;
            this.MaNL.Width = 105;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SoLuongNhap";
            this.SL.HeaderText = "Số Lượng";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 105;
            // 
            // DG
            // 
            this.DG.DataPropertyName = "DonGia";
            this.DG.HeaderText = "DonGia";
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.Width = 105;
            // 
            // frmXemCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 374);
            this.Controls.Add(this.dgvChiTietPN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXemCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemCTPN";
            this.Load += new System.EventHandler(this.frmXemCTPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvChiTietPN;
        private DataGridViewTextBoxColumn MaPN;
        private DataGridViewTextBoxColumn MaNL;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn DG;
    }
}