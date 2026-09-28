using System;
using System.Windows.Forms;

namespace Cau5
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
        }

        private void FormBanVe_Load(object? sender, EventArgs e)
        {
            cboPhim.Items.Clear();
            cboPhim.Items.Add("Mai");
            cboPhim.Items.Add("Lật Mặt 7: Một Điều Ước");
            cboPhim.Items.Add("Dune: Hành Tinh Cát 2");
            cboPhim.Items.Add("Kung Fu Panda 4");
            cboPhim.Items.Add("Godzilla x Kong");
            if (cboPhim.Items.Count > 0) cboPhim.SelectedIndex = 0;

            cboSuatChieu.Items.Clear();
            cboSuatChieu.Items.Add("09:00 - Sáng");
            cboSuatChieu.Items.Add("12:00 - Trưa");
            cboSuatChieu.Items.Add("15:00 - Chiều");
            cboSuatChieu.Items.Add("18:00 - Tối");
            cboSuatChieu.Items.Add("21:00 - Đêm");
            if (cboSuatChieu.Items.Count > 0) cboSuatChieu.SelectedIndex = 3;
        }

        private void btnChonGhe_Click(object? sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboSuatChieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng bấm chọn ghế trước khi đặt vé!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thongTin = $"ĐẶT VÉ XEM PHIM THÀNH CÔNG!\n\n" +
                              $"- Tên khách: {txtTenKhach.Text.Trim()}\n" +
                              $"- Phim: {cboPhim.SelectedItem}\n" +
                              $"- Suất chiếu: {cboSuatChieu.SelectedItem}\n" +
                              $"- Ghế chọn: {txtGheDaChon.Text}\n" +
                              $"- Giá vé: 75.000đ/vé";

            MessageBox.Show(thongTin, "Xác Nhận Đặt Vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object? sender, EventArgs e)
        {
            txtTenKhach.Clear();
            if (cboPhim.Items.Count > 0) cboPhim.SelectedIndex = 0;
            if (cboSuatChieu.Items.Count > 0) cboSuatChieu.SelectedIndex = 0;
            txtGheDaChon.Clear();
            txtTenKhach.Focus();
        }
    }
}
