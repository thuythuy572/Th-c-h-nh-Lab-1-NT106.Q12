using System;
using System.Linq;
using System.Windows.Forms;

namespace _23521558_lab01
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
            string input = txtInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] parts = input.Split(',');

            if (parts.Length < 2)
            {
                MessageBox.Show("Sai định dạng! Cần có tên và ít nhất một điểm.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hoTen = parts[0].Trim();
            double[] diem;

            try
            {
                diem = parts.Skip(1).Select(p => double.Parse(p.Trim())).ToArray();
            }
            catch
            {
                MessageBox.Show("Sai định dạng điểm! Hãy nhập dạng: Tên, 7.5, 8, 9,...", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // kiểm tra 0..10
            if (diem.Any(x => x < 0 || x > 10))
            {
                MessageBox.Show("Mỗi điểm phải nằm trong khoảng 0 đến 10!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Hợp lệ
            txtKetQua.AppendText("✅ Đã nhập đúng format!\r\n\r\n");
            txtKetQua.AppendText($"Họ và tên: {hoTen}\r\n");

            // Danh sách điểm
            txtKetQua.AppendText("\r\nDanh sách điểm:\r\n");
            for (int i = 0; i < diem.Length; i++)
            {
                txtKetQua.AppendText($"Môn {i + 1}: {diem[i]}\r\n");
            }

            // Tính toán
            double dtb = diem.Average();
            double max = diem.Max();
            double min = diem.Min();
            int soMonDau = diem.Count(x => x >= 5);
            int soMonRot = diem.Length - soMonDau;

            // Xếp loại
            string xepLoai;
            if (dtb >= 8 && diem.All(x => x >= 6.5))
                xepLoai = "Giỏi";
            else if (dtb >= 6.5 && diem.All(x => x >= 5))
                xepLoai = "Khá";
            else if (dtb >= 5 && diem.All(x => x >= 3.5))
                xepLoai = "Trung bình";
            else if (dtb >= 3.5 && diem.All(x => x >= 2))
                xepLoai = "Yếu";
            else
                xepLoai = "Kém";

            // Xuất kết quả
            txtKetQua.AppendText("\r\n------------------------------\r\n");
            txtKetQua.AppendText($"Điểm trung bình: {dtb:F2}\r\n");
            txtKetQua.AppendText($"Môn cao nhất: {max}\r\n");
            txtKetQua.AppendText($"Môn thấp nhất: {min}\r\n");
            txtKetQua.AppendText($"Số môn đậu: {soMonDau}\r\n");
            txtKetQua.AppendText($"Số môn không đậu: {soMonRot}\r\n");
            txtKetQua.AppendText($"Xếp loại: {xepLoai}\r\n");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtKetQua.Clear();
            txtInput.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
