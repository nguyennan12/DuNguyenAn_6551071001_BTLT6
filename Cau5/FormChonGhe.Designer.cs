namespace Cau5
{
    partial class FormChonGhe
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
            this.lstGhe = new System.Windows.Forms.ListBox();
            this.lblGheDaChon = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(80, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHỌN GHẾ XEM PHIM";

            // lstGhe
            this.lstGhe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstGhe.FormattingEnabled = true;
            this.lstGhe.ItemHeight = 17;
            this.lstGhe.Location = new System.Drawing.Point(30, 50);
            this.lstGhe.Name = "lstGhe";
            this.lstGhe.Size = new System.Drawing.Size(280, 191);
            this.lstGhe.TabIndex = 1;
            this.lstGhe.SelectedIndexChanged += new System.EventHandler(this.lstGhe_SelectedIndexChanged);

            // lblGheDaChon
            this.lblGheDaChon.AutoSize = true;
            this.lblGheDaChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGheDaChon.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblGheDaChon.Location = new System.Drawing.Point(30, 255);
            this.lblGheDaChon.Name = "lblGheDaChon";
            this.lblGheDaChon.Size = new System.Drawing.Size(164, 19);
            this.lblGheDaChon.TabIndex = 2;
            this.lblGheDaChon.Text = "Đang chọn: (Chưa chọn)";

            // btnXacNhan
            this.btnXacNhan.Location = new System.Drawing.Point(50, 290);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(110, 32);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);

            // btnBoQua
            this.btnBoQua.Location = new System.Drawing.Point(180, 290);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(110, 32);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);

            // FormChonGhe
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 340);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lblGheDaChon);
            this.Controls.Add(this.lstGhe);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChonGhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn Ghế Xem Phim";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstGhe;
        private System.Windows.Forms.Label lblGheDaChon;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnBoQua;
    }
}
