using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cau6
{
    public partial class FormGhiChu : Form
    {
        private bool _isModified = false;
        private Color _btnOriginalBackColor;

        public FormGhiChu()
        {
            InitializeComponent();
            this.KeyPreview = true;
            _btnOriginalBackColor = btnLuuGhiChu.BackColor;

            cboMucDoUuTien.Items.Clear();
            cboMucDoUuTien.Items.Add("Thấp");
            cboMucDoUuTien.Items.Add("Trung bình");
            cboMucDoUuTien.Items.Add("Cao");
            cboMucDoUuTien.SelectedIndex = 1; // Default: Trung bình

            txtTieuDe.TextChanged += Field_TextChanged;
            txtNoiDung.TextChanged += Field_TextChanged;
            cboMucDoUuTien.SelectedIndexChanged += Field_TextChanged;
        }

        private void Field_TextChanged(object? sender, EventArgs e)
        {
            _isModified = true;
        }

        private void FormGhiChu_KeyDown(object? sender, KeyEventArgs e)
        {
            // Ctrl + S -> Lưu
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                btnLuuGhiChu.PerformClick();
            }
            // Escape -> Đóng ghi chú (hỏi nếu có thay đổi)
            else if (e.KeyCode == Keys.Escape)
            {
                if (_isModified)
                {
                    DialogResult dr = MessageBox.Show("Ghi chú có nội dung chưa được lưu. Bạn có muốn đóng mà không lưu không?",
                                                      "Xác nhận đóng",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void txtNoiDung_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Đếm và giới hạn tối đa 500 ký tự (cho phép phím Backspace '\b')
            if (txtNoiDung.Text.Length >= 500 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Chặn ký tự thêm
            }
        }

        private void lblTieuDeForm_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnLuuGhiChu_MouseEnter(object? sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightSkyBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object? sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = _btnOriginalBackColor;
        }

        private void txtTieuDe_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();
            if (string.IsNullOrEmpty(tieuDe) || tieuDe.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống và tối đa 50 ký tự!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtTieuDe, "");
                txtTieuDe.BackColor = Color.White;
            }
        }

        private void txtTieuDe_Validated(object? sender, EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;
            errorProvider1.SetError(txtTieuDe, "");
        }

        private void btnLuuGhiChu_Click(object? sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text.Trim();
            _isModified = false;
            MessageBox.Show("Đã lưu ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
