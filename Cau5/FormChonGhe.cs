using System;
using System.Windows.Forms;

namespace Cau5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; } = "";

        public FormChonGhe(string gheHienTai = "")
        {
            InitializeComponent();

            // Populate seat list: A1-A5, B1-B5, C1-C5
            lstGhe.Items.Clear();
            string[] rows = { "A", "B", "C" };
            foreach (string row in rows)
            {
                for (int i = 1; i <= 5; i++)
                {
                    lstGhe.Items.Add($"{row}{i}");
                }
            }

            // Preselect existing seat if valid
            if (!string.IsNullOrEmpty(gheHienTai) && lstGhe.Items.Contains(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
            }
            else
            {
                lblGheDaChon.Text = "Đang chọn: (Chưa chọn)";
            }
        }

        private void lstGhe_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text = "Đang chọn: " + lstGhe.SelectedItem.ToString();
            }
            else
            {
                lblGheDaChon.Text = "Đang chọn: (Chưa chọn)";
            }
        }

        private void btnXacNhan_Click(object? sender, EventArgs e)
        {
            if (lstGhe.SelectedIndex == -1 || lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế trước khi xác nhận!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GheChon = lstGhe.SelectedItem.ToString() ?? "";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
