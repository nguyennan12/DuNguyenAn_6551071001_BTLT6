namespace Cau2
{
    partial class FormDatPhong
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblNgayNhan = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblSoNguoiLon = new System.Windows.Forms.Label();
            this.lblSoTreEm = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtNgayNhan = new System.Windows.Forms.TextBox();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.txtSoNguoiLon = new System.Windows.Forms.TextBox();
            this.txtSoTreEm = new System.Windows.Forms.TextBox();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐẶT PHÒNG KHÁCH SẠN";

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(35, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(83, 15);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên khách:";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(180, 72);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 23);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoTen_Validating);
            this.txtHoTen.Validated += new System.EventHandler(this.TextBox_Validated);

            // lblCCCD
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(35, 115);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(57, 15);
            this.lblCCCD.TabIndex = 3;
            this.lblCCCD.Text = "Số CCCD:";

            // txtCCCD
            this.txtCCCD.Location = new System.Drawing.Point(180, 112);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(200, 23);
            this.txtCCCD.TabIndex = 4;
            this.txtCCCD.Validating += new System.ComponentModel.CancelEventHandler(this.txtCCCD_Validating);
            this.txtCCCD.Validated += new System.EventHandler(this.TextBox_Validated);

            // lblNgayNhan
            this.lblNgayNhan.AutoSize = true;
            this.lblNgayNhan.Location = new System.Drawing.Point(35, 155);
            this.lblNgayNhan.Name = "lblNgayNhan";
            this.lblNgayNhan.Size = new System.Drawing.Size(133, 15);
            this.lblNgayNhan.TabIndex = 5;
            this.lblNgayNhan.Text = "Ngày nhận (dd/MM/yyyy):";

            // txtNgayNhan
            this.txtNgayNhan.Location = new System.Drawing.Point(180, 152);
            this.txtNgayNhan.Name = "txtNgayNhan";
            this.txtNgayNhan.Size = new System.Drawing.Size(200, 23);
            this.txtNgayNhan.TabIndex = 6;
            this.txtNgayNhan.Validating += new System.ComponentModel.CancelEventHandler(this.txtNgayNhan_Validating);
            this.txtNgayNhan.Validated += new System.EventHandler(this.TextBox_Validated);

            // lblNgayTra
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(35, 195);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(121, 15);
            this.lblNgayTra.TabIndex = 7;
            this.lblNgayTra.Text = "Ngày trả (dd/MM/yyyy):";

            // txtNgayTra
            this.txtNgayTra.Location = new System.Drawing.Point(180, 192);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(200, 23);
            this.txtNgayTra.TabIndex = 8;
            this.txtNgayTra.Validating += new System.ComponentModel.CancelEventHandler(this.txtNgayTra_Validating);
            this.txtNgayTra.Validated += new System.EventHandler(this.TextBox_Validated);

            // lblSoNguoiLon
            this.lblSoNguoiLon.AutoSize = true;
            this.lblSoNguoiLon.Location = new System.Drawing.Point(35, 235);
            this.lblSoNguoiLon.Name = "lblSoNguoiLon";
            this.lblSoNguoiLon.Size = new System.Drawing.Size(117, 15);
            this.lblSoNguoiLon.TabIndex = 9;
            this.lblSoNguoiLon.Text = "Số người lớn (1–4):";

            // txtSoNguoiLon
            this.txtSoNguoiLon.Location = new System.Drawing.Point(180, 232);
            this.txtSoNguoiLon.Name = "txtSoNguoiLon";
            this.txtSoNguoiLon.Size = new System.Drawing.Size(200, 23);
            this.txtSoNguoiLon.TabIndex = 10;
            this.txtSoNguoiLon.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoNguoiLon_Validating);
            this.txtSoNguoiLon.Validated += new System.EventHandler(this.TextBox_Validated);

            // lblSoTreEm
            this.lblSoTreEm.AutoSize = true;
            this.lblSoTreEm.Location = new System.Drawing.Point(35, 275);
            this.lblSoTreEm.Name = "lblSoTreEm";
            this.lblSoTreEm.Size = new System.Drawing.Size(98, 15);
            this.lblSoTreEm.TabIndex = 11;
            this.lblSoTreEm.Text = "Số trẻ em (0–3):";

            // txtSoTreEm
            this.txtSoTreEm.Location = new System.Drawing.Point(180, 272);
            this.txtSoTreEm.Name = "txtSoTreEm";
            this.txtSoTreEm.Size = new System.Drawing.Size(200, 23);
            this.txtSoTreEm.TabIndex = 12;
            this.txtSoTreEm.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoTreEm_Validating);
            this.txtSoTreEm.Validated += new System.EventHandler(this.TextBox_Validated);

            // btnDatPhong
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDatPhong.Location = new System.Drawing.Point(180, 315);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(200, 35);
            this.btnDatPhong.TabIndex = 13;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);

            // errorProvider1
            this.errorProvider1.ContainerControl = this;

            // FormDatPhong
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 375);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.txtSoTreEm);
            this.Controls.Add(this.lblSoTreEm);
            this.Controls.Add(this.txtSoNguoiLon);
            this.Controls.Add(this.lblSoNguoiLon);
            this.Controls.Add(this.txtNgayTra);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.txtNgayNhan);
            this.Controls.Add(this.lblNgayNhan);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Đặt Phòng Khách Sạn";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblSoNguoiLon;
        private System.Windows.Forms.Label lblSoTreEm;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.TextBox txtSoNguoiLon;
        private System.Windows.Forms.TextBox txtSoTreEm;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
