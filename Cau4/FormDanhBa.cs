using System;
using System.Windows.Forms;

namespace Cau4
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên và số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemText = $"{ten} - {sdt}";

            if (_indexDangSua == -1)
            {
                // Thêm mới
                lstLienHe.Items.Add(itemText);
                txtTen.Clear();
                txtSDT.Clear();
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật
                if (_indexDangSua >= 0 && _indexDangSua < lstLienHe.Items.Count)
                {
                    lstLienHe.Items[_indexDangSua] = itemText;
                }
                _indexDangSua = -1;
                btnThem.Text = "Thêm";
                txtTen.Clear();
                txtSDT.Clear();
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;
            string selectedText = lstLienHe.SelectedItem?.ToString() ?? "";

            string[] parts = selectedText.Split(new[] { " - " }, StringSplitOptions.None);
            if (parts.Length >= 2)
            {
                txtTen.Text = parts[0];
                txtSDT.Text = parts[1];
            }
            else
            {
                txtTen.Text = selectedText;
                txtSDT.Text = "";
            }

            btnThem.Text = "Cập nhật";
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = lstLienHe.SelectedItem?.ToString() ?? "";
            string ten = selectedItem;
            int dashIdx = selectedItem.LastIndexOf(" - ");
            if (dashIdx > 0)
            {
                ten = selectedItem.Substring(0, dashIdx);
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa liên hệ {ten}? Thao tác này không thể hoàn tác!",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int removeIndex = lstLienHe.SelectedIndex;
                lstLienHe.Items.RemoveAt(removeIndex);
                if (_indexDangSua == removeIndex)
                {
                    _indexDangSua = -1;
                    btnThem.Text = "Thêm";
                    txtTen.Clear();
                    txtSDT.Clear();
                }
                MessageBox.Show("Xóa liên hệ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhBa_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                                                  "Cảnh báo",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    // Cho phép thoát giữ nguyên
                }
                else if (dr == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();
                    // Tiếp tục thoát
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
