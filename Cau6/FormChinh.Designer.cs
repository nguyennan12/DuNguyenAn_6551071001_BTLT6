namespace Cau6
{
    partial class FormChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoGhiChuMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepTang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepNgang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSoGhiChu = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuTep,
                this.mnuCuaSo
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // mnuTep
            this.mnuTep.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuMoGhiChuMoi,
                this.toolStripSeparator1,
                this.mnuThoat
            });
            this.mnuTep.Name = "mnuTep";
            this.mnuTep.Size = new System.Drawing.Size(38, 20);
            this.mnuTep.Text = "&Tệp";

            // mnuMoGhiChuMoi
            this.mnuMoGhiChuMoi.Name = "mnuMoGhiChuMoi";
            this.mnuMoGhiChuMoi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuMoGhiChuMoi.Size = new System.Drawing.Size(206, 22);
            this.mnuMoGhiChuMoi.Text = "Mở ghi chú mới";
            this.mnuMoGhiChuMoi.Click += new System.EventHandler(this.mnuMoGhiChuMoi_Click);

            // toolStripSeparator1
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);

            // mnuThoat
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(206, 22);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);

            // mnuCuaSo
            this.mnuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuXepTang,
                this.mnuXepNgang,
                this.mnuXepDoc
            });
            this.mnuCuaSo.Name = "mnuCuaSo";
            this.mnuCuaSo.Size = new System.Drawing.Size(56, 20);
            this.mnuCuaSo.Text = "&Cửa sổ";

            // mnuXepTang
            this.mnuXepTang.Name = "mnuXepTang";
            this.mnuXepTang.Size = new System.Drawing.Size(180, 22);
            this.mnuXepTang.Text = "Xếp tầng";
            this.mnuXepTang.Click += new System.EventHandler(this.mnuXepTang_Click);

            // mnuXepNgang
            this.mnuXepNgang.Name = "mnuXepNgang";
            this.mnuXepNgang.Size = new System.Drawing.Size(180, 22);
            this.mnuXepNgang.Text = "Xếp ngang";
            this.mnuXepNgang.Click += new System.EventHandler(this.mnuXepNgang_Click);

            // mnuXepDoc
            this.mnuXepDoc.Name = "mnuXepDoc";
            this.mnuXepDoc.Size = new System.Drawing.Size(180, 22);
            this.mnuXepDoc.Text = "Xếp dọc";
            this.mnuXepDoc.Click += new System.EventHandler(this.mnuXepDoc_Click);

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblSoGhiChu
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";

            // lblSoGhiChu
            this.lblSoGhiChu.Name = "lblSoGhiChu";
            this.lblSoGhiChu.Size = new System.Drawing.Size(117, 17);
            this.lblSoGhiChu.Text = "Số ghi chú đang mở: 0";

            // FormChinh
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng Dụng Quản Lý Ghi Chú Công Việc (Note Manager)";
            this.Load += new System.EventHandler(this.FormChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTep;
        private System.Windows.Forms.ToolStripMenuItem mnuMoGhiChuMoi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem mnuXepTang;
        private System.Windows.Forms.ToolStripMenuItem mnuXepNgang;
        private System.Windows.Forms.ToolStripMenuItem mnuXepDoc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSoGhiChu;
    }
}
