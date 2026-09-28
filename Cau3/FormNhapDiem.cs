using System;
using System.Globalization;
using System.Windows.Forms;

namespace Cau3
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.KeyPress += Txt_KeyPress;
                }
            }
        }

        private void Txt_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == '\r')
            {
                e.Handled = true;
                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else if (sender is Control ctrl)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
            }
        }

        private void ScoreTextBox_Enter(object? sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();
            }
        }

        private bool KiemTraHopLe(out decimal toan, out decimal van, out decimal anh)
        {
            bool hopLe = true;
            toan = 0;
            van = 0;
            anh = 0;

            // Mã HS
            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(txtMaHS, "Mã học sinh không được để trống!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMaHS, "");
            }

            // Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên học sinh không được để trống!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // Điểm Toán (0.0 - 10.0)
            string sToan = txtToan.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(sToan, NumberStyles.Any, CultureInfo.InvariantCulture, out toan) || toan < 0 || toan > 10)
            {
                errorProvider1.SetError(txtToan, "Điểm Toán phải là số từ 0.0 đến 10.0!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtToan, "");
            }

            // Điểm Văn (0.0 - 10.0)
            string sVan = txtVan.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(sVan, NumberStyles.Any, CultureInfo.InvariantCulture, out van) || van < 0 || van > 10)
            {
                errorProvider1.SetError(txtVan, "Điểm Văn phải là số từ 0.0 đến 10.0!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtVan, "");
            }

            // Điểm Anh (0.0 - 10.0)
            string sAnh = txtAnh.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(sAnh, NumberStyles.Any, CultureInfo.InvariantCulture, out anh) || anh < 0 || anh > 10)
            {
                errorProvider1.SetError(txtAnh, "Điểm Anh phải là số từ 0.0 đến 10.0!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtAnh, "");
            }

            return hopLe;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe(out decimal toan, out decimal van, out decimal anh))
            {
                return;
            }

            string line = $"[{txtMaHS.Text.Trim()}] | [{txtHoTen.Text.Trim()}] | T:{toan:0.0} V:{van:0.0} A:{anh:0.0}";
            lstDanhSach.Items.Add(line);

            XoaTrangForm();
            txtMaHS.Focus();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
            txtMaHS.Focus();
        }

        private void XoaTrangForm()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
        }
    }
}
