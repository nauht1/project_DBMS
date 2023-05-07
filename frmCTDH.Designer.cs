namespace QLCuaHangDoAnNhanhWP
{
    partial class frmCTDH
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
            this.btnTim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.dgvCTDH = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnTrucTuyen = new System.Windows.Forms.Button();
            this.btnTrucTiep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Chartreuse;
            this.btnTim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.Location = new System.Drawing.Point(264, 13);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(67, 31);
            this.btnTim.TabIndex = 142;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(22, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 21);
            this.label9.TabIndex = 141;
            this.label9.Text = "Nhập mã đơn";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDonHang.Location = new System.Drawing.Point(133, 18);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(125, 25);
            this.txtMaDonHang.TabIndex = 140;
            // 
            // dgvCTDH
            // 
            this.dgvCTDH.AllowUserToAddRows = false;
            this.dgvCTDH.AllowUserToDeleteRows = false;
            this.dgvCTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDH.Location = new System.Drawing.Point(22, 50);
            this.dgvCTDH.Name = "dgvCTDH";
            this.dgvCTDH.ReadOnly = true;
            this.dgvCTDH.RowHeadersWidth = 43;
            this.dgvCTDH.RowTemplate.Height = 27;
            this.dgvCTDH.Size = new System.Drawing.Size(920, 528);
            this.dgvCTDH.TabIndex = 143;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReload.Location = new System.Drawing.Point(337, 15);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(74, 28);
            this.btnReload.TabIndex = 144;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnTrucTuyen
            // 
            this.btnTrucTuyen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrucTuyen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTrucTuyen.Location = new System.Drawing.Point(810, 12);
            this.btnTrucTuyen.Name = "btnTrucTuyen";
            this.btnTrucTuyen.Size = new System.Drawing.Size(132, 31);
            this.btnTrucTuyen.TabIndex = 145;
            this.btnTrucTuyen.Text = "Trực tuyến";
            this.btnTrucTuyen.UseVisualStyleBackColor = true;
            this.btnTrucTuyen.Click += new System.EventHandler(this.btnTrucTuyen_Click);
            // 
            // btnTrucTiep
            // 
            this.btnTrucTiep.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrucTiep.ForeColor = System.Drawing.Color.Navy;
            this.btnTrucTiep.Location = new System.Drawing.Point(672, 12);
            this.btnTrucTiep.Name = "btnTrucTiep";
            this.btnTrucTiep.Size = new System.Drawing.Size(132, 31);
            this.btnTrucTiep.TabIndex = 145;
            this.btnTrucTiep.Text = "Trực tiếp";
            this.btnTrucTiep.UseVisualStyleBackColor = true;
            this.btnTrucTiep.Click += new System.EventHandler(this.btnTrucTiep_Click);
            // 
            // frmCTDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 590);
            this.Controls.Add(this.btnTrucTiep);
            this.Controls.Add(this.btnTrucTuyen);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvCTDH);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaDonHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCTDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCTDH";
            this.Load += new System.EventHandler(this.frmCTDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTim;
        private Label label9;
        private TextBox txtMaDonHang;
        private DataGridView dgvCTDH;
        private Button btnReload;
        public Button btnTrucTuyen;
        public Button btnTrucTiep;
    }
}