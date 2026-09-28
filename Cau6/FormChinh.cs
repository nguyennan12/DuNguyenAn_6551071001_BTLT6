using System;
using System.Windows.Forms;

namespace Cau6
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void FormChinh_Load(object? sender, EventArgs e)
        {
            CapNhatStatus();
        }

        private void mnuMoGhiChuMoi_Click(object? sender, EventArgs e)
        {
            FormGhiChu note = new FormGhiChu();
            note.MdiParent = this;
            note.FormClosed += Note_FormClosed;
            note.Show();
            CapNhatStatus();
        }

        private void Note_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CapNhatStatus();
        }

        private void CapNhatStatus()
        {
            lblSoGhiChu.Text = $"Số ghi chú đang mở: {this.MdiChildren.Length}";
        }

        private void mnuXepTang_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuXepNgang_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuXepDoc_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuThoat_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
