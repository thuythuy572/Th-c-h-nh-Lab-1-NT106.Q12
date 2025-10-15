using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _23521558_lab01
{
    public partial class Bai8 : Form
    {
        // Chuỗi món ăn “lưu trữ dưới dạng String” (ngăn cách bằng dấu phẩy)
        private string chuoiMonAn =
            "Bún riêu, Bún thịt nướng, Cơm tấm sườn trứng, Phở, Gỏi cuốn";

        // Danh sách để hiển thị / thao tác (sync với chuỗi trên)
        private readonly List<string> dsMonAn = new List<string>();

        private static readonly Random _rng = new Random();

        public Bai8()
        {
            InitializeComponent();
        }

        private void Bai8_Load(object sender, EventArgs e)
        {
            NapDanhSachLenListBox();
        }

        private void NapDanhSachLenListBox()
        {
            dsMonAn.Clear();
            dsMonAn.AddRange(
                chuoiMonAn.Split(',')
                          .Select(s => s.Trim())
                          .Where(s => s.Length > 0));

            lstMonAn.Items.Clear();
            lstMonAn.Items.AddRange(dsMonAn.Cast<object>().ToArray());
        }

        private void CapNhatChuoiMonAnTuDanhSach()
        {
            chuoiMonAn = string.Join(", ", dsMonAn);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mon = txtMon.Text.Trim();
            if (string.IsNullOrEmpty(mon))
            {
                MessageBox.Show("Nhập tên món ăn trước đã nhé!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMon.Focus();
                return;
            }

            // Tránh trùng (so sánh không phân biệt hoa thường)
            if (dsMonAn.Any(x => string.Equals(x, mon, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Món này đã có trong danh sách!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dsMonAn.Add(mon);
            CapNhatChuoiMonAnTuDanhSach();
            NapDanhSachLenListBox();
            txtMon.Clear();
            txtMon.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (dsMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách đang rỗng, thêm món ăn vào đã nhé!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idx = _rng.Next(dsMonAn.Count);
            string monChon = dsMonAn[idx];
            txtKetQua.Text = monChon;
            lstMonAn.SelectedIndex = idx;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa món đang chọn trong ListBox (nếu có)
            if (lstMonAn.SelectedItem is string mon)
            {
                if (MessageBox.Show($"Xóa \"{mon}\" khỏi danh sách?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dsMonAn.Remove(mon);
                    CapNhatChuoiMonAnTuDanhSach();
                    NapDanhSachLenListBox();
                    txtKetQua.Clear();
                }
                return;
            }

            // Nếu không chọn gì thì chỉ xóa ô nhập & kết quả
            txtMon.Clear();
            txtKetQua.Clear();
            txtMon.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
