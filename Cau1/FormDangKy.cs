using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cau1
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        public bool KiemTraHopLe()
        {
            bool hopLe = true;

            // 1. txtHoTen không để trống và tối thiểu 3 ký tự
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen) || hoTen.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống và phải tối thiểu 3 ký tự!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // 2. txtSDT đúng 10 chữ số, bắt đầu bằng "0"
            string sdt = txtSDT.Text.Trim();
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !Regex.IsMatch(sdt, @"^\d+$"))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải có đúng 10 chữ số và bắt đầu bằng '0'!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // 3. txtEmail chứa "@" và "." phía sau "@"
            string email = txtEmail.Text.Trim();
            int atIndex = email.IndexOf('@');
            if (atIndex <= 0 || email.IndexOf('.', atIndex) <= atIndex + 1 || email.EndsWith("."))
            {
                errorProvider1.SetError(txtEmail, "Email phải chứa '@' và có dấu '.' phía sau '@'!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // 4. txtMatKhau tối thiểu 6 ký tự
            string matKhau = txtMatKhau.Text;
            if (matKhau.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải tối thiểu 6 ký tự!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // 5. txtXacNhanMK phải khớp với txtMatKhau
            string xacNhanMK = txtXacNhanMK.Text;
            if (xacNhanMK != matKhau || string.IsNullOrEmpty(xacNhanMK))
            {
                errorProvider1.SetError(txtXacNhanMK, "Xác nhận mật khẩu phải khớp với mật khẩu!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text.Trim(),
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }
    }
}
