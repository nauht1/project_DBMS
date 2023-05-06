namespace QLCuaHangDoAnNhanhWP
{
    partial class frmMain2
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
            this.btnIsNhanVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIsKhachHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIsNhanVien
            // 
            this.btnIsNhanVien.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnIsNhanVien.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnIsNhanVien.Location = new System.Drawing.Point(27, 105);
            this.btnIsNhanVien.Name = "btnIsNhanVien";
            this.btnIsNhanVien.Size = new System.Drawing.Size(136, 71);
            this.btnIsNhanVien.TabIndex = 0;
            this.btnIsNhanVien.Text = "Nhân viên";
            this.btnIsNhanVien.UseVisualStyleBackColor = false;
            this.btnIsNhanVien.Click += new System.EventHandler(this.btnIsNhanVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome! Have a good day!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(143, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bạn là?";
            // 
            // btnIsKhachHang
            // 
            this.btnIsKhachHang.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnIsKhachHang.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnIsKhachHang.Location = new System.Drawing.Point(183, 105);
            this.btnIsKhachHang.Name = "btnIsKhachHang";
            this.btnIsKhachHang.Size = new System.Drawing.Size(136, 71);
            this.btnIsKhachHang.TabIndex = 0;
            this.btnIsKhachHang.Text = "Khách hàng";
            this.btnIsKhachHang.UseVisualStyleBackColor = false;
            this.btnIsKhachHang.Click += new System.EventHandler(this.btnIsKhachHang_Click);
            // 
            // frmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIsKhachHang);
            this.Controls.Add(this.btnIsNhanVien);
            this.Name = "frmMain2";
            this.Text = "frmMain2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIsNhanVien;
        private Label label1;
        private Label label2;
        private Button btnIsKhachHang;
    }
}