namespace Cau4
{
    partial class FormDanhBa
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
            this.lblTen = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstLienHe = new System.Windows.Forms.ListBox();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(130, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ DANH BẠ";

            // lblTen
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(30, 65);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(61, 15);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Họ và tên:";

            // txtTen
            this.txtTen.Location = new System.Drawing.Point(120, 62);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(340, 23);
            this.txtTen.TabIndex = 2;

            // lblSDT
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(30, 105);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(79, 15);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "Số điện thoại:";

            // txtSDT
            this.txtSDT.Location = new System.Drawing.Point(120, 102);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(340, 23);
            this.txtSDT.TabIndex = 4;

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(30, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(142, 145);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(254, 145);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnThoat
            this.btnThoat.Location = new System.Drawing.Point(365, 145);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 30);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // lblDanhSach
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.Location = new System.Drawing.Point(30, 190);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(117, 15);
            this.lblDanhSach.TabIndex = 9;
            this.lblDanhSach.Text = "Danh sách liên hệ:";

            // lstLienHe
            this.lstLienHe.FormattingEnabled = true;
            this.lstLienHe.ItemHeight = 15;
            this.lstLienHe.Location = new System.Drawing.Point(30, 210);
            this.lstLienHe.Name = "lstLienHe";
            this.lstLienHe.Size = new System.Drawing.Size(430, 184);
            this.lstLienHe.TabIndex = 10;

            // FormDanhBa
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 415);
            this.Controls.Add(this.lstLienHe);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDanhBa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Danh Bạ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDanhBa_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox lstLienHe;
    }
}
