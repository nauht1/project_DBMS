namespace QLCuaHangDoAnNhanhWP
{
    partial class frmNhanVienGiao
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
            this.dgvNhanVienGiao = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienGiao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanVienGiao
            // 
            this.dgvNhanVienGiao.AllowUserToAddRows = false;
            this.dgvNhanVienGiao.AllowUserToDeleteRows = false;
            this.dgvNhanVienGiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVienGiao.Location = new System.Drawing.Point(12, 12);
            this.dgvNhanVienGiao.Name = "dgvNhanVienGiao";
            this.dgvNhanVienGiao.ReadOnly = true;
            this.dgvNhanVienGiao.RowHeadersWidth = 43;
            this.dgvNhanVienGiao.RowTemplate.Height = 27;
            this.dgvNhanVienGiao.Size = new System.Drawing.Size(633, 318);
            this.dgvNhanVienGiao.TabIndex = 0;
            this.dgvNhanVienGiao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVienGiao_CellClick);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOK.Location = new System.Drawing.Point(574, 336);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmNhanVienGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 376);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvNhanVienGiao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmNhanVienGiao";
            this.Text = "frmNhanVienGiao";
            this.Load += new System.EventHandler(this.frmNhanVienGiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienGiao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvNhanVienGiao;
        private Button btnOK;
    }
}