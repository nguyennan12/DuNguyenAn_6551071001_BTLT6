namespace Cau3
{
    partial class FormNhapDiem
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblToan = new System.Windows.Forms.Label();
            this.lblVan = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.txtVan = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(130, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TabIndex = 100;
            this.lblTitle.TabStop = false;
            this.lblTitle.Text = "NHẬP ĐIỂM HỌC SINH";

            // lblMaHS
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(30, 65);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(75, 15);
            this.lblMaHS.TabIndex = 101;
            this.lblMaHS.TabStop = false;
            this.lblMaHS.Text = "Mã học sinh:";

            // txtMaHS
            this.txtMaHS.Location = new System.Drawing.Point(120, 62);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(120, 23);
            this.txtMaHS.TabIndex = 0;

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 100);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 15);
            this.lblHoTen.TabIndex = 102;
            this.lblHoTen.TabStop = false;
            this.lblHoTen.Text = "Họ và tên:";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(120, 97);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(350, 23);
            this.txtHoTen.TabIndex = 1;

            // lblToan
            this.lblToan.AutoSize = true;
            this.lblToan.Location = new System.Drawing.Point(30, 135);
            this.lblToan.Name = "lblToan";
            this.lblToan.Size = new System.Drawing.Size(63, 15);
            this.lblToan.TabIndex = 103;
            this.lblToan.TabStop = false;
            this.lblToan.Text = "Điểm Toán:";

            // txtToan
            this.txtToan.Location = new System.Drawing.Point(120, 132);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(80, 23);
            this.txtToan.TabIndex = 2;
            this.txtToan.Enter += new System.EventHandler(this.ScoreTextBox_Enter);

            // lblVan
            this.lblVan.AutoSize = true;
            this.lblVan.Location = new System.Drawing.Point(215, 135);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(58, 15);
            this.lblVan.TabIndex = 104;
            this.lblVan.TabStop = false;
            this.lblVan.Text = "Điểm Văn:";

            // txtVan
            this.txtVan.Location = new System.Drawing.Point(275, 132);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size = new System.Drawing.Size(80, 23);
            this.txtVan.TabIndex = 3;
            this.txtVan.Enter += new System.EventHandler(this.ScoreTextBox_Enter);

            // lblAnh
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(365, 135);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(58, 15);
            this.lblAnh.TabIndex = 105;
            this.lblAnh.TabStop = false;
            this.lblAnh.Text = "Điểm Anh:";

            // txtAnh
            this.txtAnh.Location = new System.Drawing.Point(425, 132);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(80, 23);
            this.txtAnh.TabIndex = 4;
            this.txtAnh.Enter += new System.EventHandler(this.ScoreTextBox_Enter);

            // btnLuu
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(120, 175);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu (Enter)";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // btnXoaTrang
            this.btnXoaTrang.Location = new System.Drawing.Point(235, 175);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(100, 30);
            this.btnXoaTrang.TabIndex = 6;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);

            // lblDanhSach
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.Location = new System.Drawing.Point(30, 220);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(147, 15);
            this.lblDanhSach.TabIndex = 106;
            this.lblDanhSach.TabStop = false;
            this.lblDanhSach.Text = "Danh sách điểm đã nhập:";

            // lstDanhSach
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 15;
            this.lstDanhSach.Location = new System.Drawing.Point(30, 240);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(475, 154);
            this.lstDanhSach.TabIndex = 7;
            this.lstDanhSach.TabStop = false;

            // errorProvider1
            this.errorProvider1.ContainerControl = this;

            // FormNhapDiem
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 415);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.txtVan);
            this.Controls.Add(this.lblVan);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.lblToan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Nhập Điểm Học Sinh";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
