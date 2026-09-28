using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cau2
{
    public partial class FormDatPhong : Form
    {
        private string[] formats = new string[] { "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "yyyy-MM-dd" };

        public FormDatPhong()
        {
            InitializeComponent();
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ và tên không được để trống!");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            if (cccd.Length != 12 || !Regex.IsMatch(cccd, @"^\d+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "Số CCCD phải có đúng 12 chữ số!");
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            string text = txtNgayNhan.Text.Trim();
            bool isDate = DateTime.TryParseExact(text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan);

            if (!isDate || ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phải theo định dạng dd/MM/yyyy và từ ngày hôm nay trở đi!");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayNhan, "");
                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            string textTra = txtNgayTra.Text.Trim();
            string textNhan = txtNgayNhan.Text.Trim();

            bool isNhanValid = DateTime.TryParseExact(textNhan, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan);
            bool isTraValid = DateTime.TryParseExact(textTra, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayTra);

            if (!isTraValid)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phải theo định dạng dd/MM/yyyy!");
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else if (isNhanValid && ngayTra.Date <= ngayNhan.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phòng phải lớn hơn ngày nhận phòng!");
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayTra, "");
                txtNgayTra.BackColor = Color.Honeydew;
            }
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out int nguoiLon) || nguoiLon < 1 || nguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoNguoiLon, "Số người lớn phải là số nguyên từ 1 đến 4!");
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoNguoiLon, "");
                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out int treEm) || treEm < 0 || treEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoTreEm, "Số trẻ em phải là số nguyên từ 0 đến 3!");
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoTreEm, "");
                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        private void TextBox_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.Honeydew;
                errorProvider1.SetError(txt, "");
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            int soDem = (ngayTra - ngayNhan).Days;

            string thongTin = $"ĐẶT PHÒNG THÀNH CÔNG!\n\n" +
                              $"- Khách hàng: {txtHoTen.Text.Trim()}\n" +
                              $"- Số CCCD: {txtCCCD.Text.Trim()}\n" +
                              $"- Ngày nhận: {ngayNhan:dd/MM/yyyy}\n" +
                              $"- Ngày trả: {ngayTra:dd/MM/yyyy}\n" +
                              $"- Số đêm lưu trú: {soDem} đêm\n" +
                              $"- Số người lớn: {txtSoNguoiLon.Text.Trim()}\n" +
                              $"- Số trẻ em: {txtSoTreEm.Text.Trim()}";

            MessageBox.Show(thongTin, "Thông Báo Đặt Phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
