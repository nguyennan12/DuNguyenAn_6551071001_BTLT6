namespace Cau5
{
    partial class FormBanVe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.lblPhim = new System.Windows.Forms.Label();
            this.lblSuatChieu = new System.Windows.Forms.Label();
            this.lblGheDaChon = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.cboSuatChieu = new System.Windows.Forms.ComboBox();
            this.txtGheDaChon = new System.Windows.Forms.TextBox();
            this.btnChonGhe = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(90, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁN VÉ XEM PHIM";

            // lblTenKhach
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(35, 75);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(64, 15);
            this.lblTenKhach.TabIndex = 1;
            this.lblTenKhach.Text = "Tên khách:";

            // txtTenKhach
            this.txtTenKhach.Location = new System.Drawing.Point(140, 72);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(240, 23);
            this.txtTenKhach.TabIndex = 2;

            // lblPhim
            this.lblPhim.AutoSize = true;
            this.lblPhim.Location = new System.Drawing.Point(35, 115);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(38, 15);
            this.lblPhim.TabIndex = 3;
            this.lblPhim.Text = "Phim:";

            // cboPhim
            this.cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(140, 112);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(240, 23);
            this.cboPhim.TabIndex = 4;

            // lblSuatChieu
            this.lblSuatChieu.AutoSize = true;
            this.lblSuatChieu.Location = new System.Drawing.Point(35, 155);
            this.lblSuatChieu.Name = "lblSuatChieu";
            this.lblSuatChieu.Size = new System.Drawing.Size(65, 15);
            this.lblSuatChieu.TabIndex = 5;
            this.lblSuatChieu.Text = "Suất chiếu:";

            // cboSuatChieu
            this.cboSuatChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuatChieu.FormattingEnabled = true;
            this.cboSuatChieu.Location = new System.Drawing.Point(140, 152);
            this.cboSuatChieu.Name = "cboSuatChieu";
            this.cboSuatChieu.Size = new System.Drawing.Size(240, 23);
            this.cboSuatChieu.TabIndex = 6;

            // lblGheDaChon
            this.lblGheDaChon.AutoSize = true;
            this.lblGheDaChon.Location = new System.Drawing.Point(35, 195);
            this.lblGheDaChon.Name = "lblGheDaChon";
            this.lblGheDaChon.Size = new System.Drawing.Size(78, 15);
            this.lblGheDaChon.TabIndex = 7;
            this.lblGheDaChon.Text = "Ghế đã chọn:";

            // txtGheDaChon
            this.txtGheDaChon.Location = new System.Drawing.Point(140, 192);
            this.txtGheDaChon.Name = "txtGheDaChon";
            this.txtGheDaChon.ReadOnly = true;
            this.txtGheDaChon.Size = new System.Drawing.Size(140, 23);
            this.txtGheDaChon.TabIndex = 8;

            // btnChonGhe
            this.btnChonGhe.Location = new System.Drawing.Point(290, 190);
            this.btnChonGhe.Name = "btnChonGhe";
            this.btnChonGhe.Size = new System.Drawing.Size(90, 26);
            this.btnChonGhe.TabIndex = 9;
            this.btnChonGhe.Text = "Chọn ghế...";
            this.btnChonGhe.UseVisualStyleBackColor = true;
            this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);

            // btnDatVe
            this.btnDatVe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDatVe.Location = new System.Drawing.Point(140, 240);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(110, 35);
            this.btnDatVe.TabIndex = 10;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);

            // btnHuy
            this.btnHuy.Location = new System.Drawing.Point(270, 240);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 35);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // FormBanVe
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.btnChonGhe);
            this.Controls.Add(this.txtGheDaChon);
            this.Controls.Add(this.lblGheDaChon);
            this.Controls.Add(this.cboSuatChieu);
            this.Controls.Add(this.lblSuatChieu);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.lblPhim);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.lblTenKhach);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng Dụng Bán Vé Xem Phim";
            this.Load += new System.EventHandler(this.FormBanVe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.Label lblGheDaChon;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.TextBox txtGheDaChon;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnHuy;
    }
}
