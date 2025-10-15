using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _23521558_lab01
{
    public partial class Bai4 : Form
    {
        // ==========================
        // DỮ LIỆU RẠP PHIM
        // ==========================

        // Phim: tên → (giá chuẩn, phòng chiếu)
        private readonly Dictionary<string, (int giaChuan, int[] phongChieu)> danhSachPhim = new()
        {
            ["Đào, phở và piano"] = (45000, new[] { 1, 2, 3 }),
            ["Mai"] = (100000, new[] { 2, 3 }),
            ["Gặp lại chị bầu"] = (70000, new[] { 1 }),
            ["Tarot"] = (90000, new[] { 3 })
        };

        // Hệ số giá từng ghế
        private readonly Dictionary<string, double> heSoGiaGhe = new()
        {
            // Vé vớt
            ["A1"] = 0.25,
            ["A5"] = 0.25,
            ["C1"] = 0.25,
            ["C5"] = 0.25,
            // Vé thường
            ["A2"] = 1,
            ["A3"] = 1,
            ["A4"] = 1,
            ["C2"] = 1,
            ["C3"] = 1,
            ["C4"] = 1,
            // Vé VIP
            ["B2"] = 2,
            ["B3"] = 2,
            ["B4"] = 2
        };

        // Danh sách ghế đã bán: (phòng, ghế)
        private readonly HashSet<(int phong, string ghe)> gheDaBan = new();

        public Bai4()
        {
            InitializeComponent();
        }

        // ==========================
        // LOAD FORM → NẠP DANH SÁCH PHIM
        // ==========================
        private void Bai4_Load(object sender, EventArgs e)
        {
            cboPhim.Items.Clear();
            cboPhim.Items.AddRange(danhSachPhim.Keys.ToArray());
            if (cboPhim.Items.Count > 0)
                cboPhim.SelectedIndex = 0;
        }

        // ==========================
        // CHỌN PHIM → HIỂN THỊ PHÒNG
        // ==========================
        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPhong.Items.Clear();
            if (cboPhim.SelectedItem is string tenPhim)
            {
                foreach (int phong in danhSachPhim[tenPhim].phongChieu)
                    cboPhong.Items.Add(phong);
                if (cboPhong.Items.Count > 0)
                    cboPhong.SelectedIndex = 0;
            }
        }

        // ==========================
        // CHỌN PHÒNG → VẼ SƠ ĐỒ GHẾ
        // ==========================
        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlSoDoGhe.Controls.Clear();
            if (cboPhong.SelectedItem == null) return;

            int phong = Convert.ToInt32(cboPhong.SelectedItem);

            string[] hang = { "A", "B", "C" };
            int soCot = 5;
            int gheWidth = 50, gheHeight = 40;
            int margin = 10;

            for (int i = 0; i < hang.Length; i++)
            {
                for (int j = 1; j <= soCot; j++)
                {
                    string maGhe = hang[i] + j;
                    Button btnGhe = new Button();
                    btnGhe.Text = maGhe;
                    btnGhe.Width = gheWidth;
                    btnGhe.Height = gheHeight;
                    btnGhe.Left = margin + (j - 1) * (gheWidth + 5);
                    btnGhe.Top = margin + i * (gheHeight + 5);
                    btnGhe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

                    // Màu theo loại vé
                    if (new[] { "A1", "A5", "C1", "C5" }.Contains(maGhe))
                        btnGhe.BackColor = Color.LightGreen;   // vé vớt
                    else if (new[] { "B2", "B3", "B4" }.Contains(maGhe))
                        btnGhe.BackColor = Color.MediumPurple; // VIP
                    else
                        btnGhe.BackColor = Color.LightGray;     // thường

                    // Nếu đã bán
                    if (gheDaBan.Contains((phong, maGhe)))
                    {
                        btnGhe.BackColor = Color.Red;
                        btnGhe.Enabled = false;
                    }

                    // Gán sự kiện chọn/bỏ chọn ghế
                    btnGhe.Click += (s, ev) =>
                    {
                        if (!btnGhe.Enabled) return;

                        if (btnGhe.BackColor == Color.Yellow) // bỏ chọn
                        {
                            // Trả lại màu gốc
                            if (new[] { "A1", "A5", "C1", "C5" }.Contains(maGhe))
                                btnGhe.BackColor = Color.LightGreen;
                            else if (new[] { "B2", "B3", "B4" }.Contains(maGhe))
                                btnGhe.BackColor = Color.MediumPurple;
                            else
                                btnGhe.BackColor = Color.LightGray;
                        }
                        else
                        {
                            btnGhe.BackColor = Color.Yellow; // chọn
                        }
                    };

                    pnlSoDoGhe.Controls.Add(btnGhe);
                }
            }
        }

        // ==========================
        // ĐẶT VÉ
        // ==========================
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (cboPhim.SelectedItem == null || cboPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!", "Thông báo");
                return;
            }

            string tenKhach = txtKhach.Text.Trim();
            if (tenKhach == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo");
                txtKhach.Focus();
                return;
            }

            int phong = Convert.ToInt32(cboPhong.SelectedItem);
            string tenPhim = cboPhim.SelectedItem.ToString();

            // Lấy danh sách ghế màu vàng (được chọn)
            var gheChon = pnlSoDoGhe.Controls.OfType<Button>()
                            .Where(b => b.BackColor == Color.Yellow)
                            .Select(b => b.Text)
                            .ToList();

            if (gheChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo");
                return;
            }

            // Tính tổng tiền
            int giaChuan = danhSachPhim[tenPhim].giaChuan;
            double tongTien = 0;
            foreach (string ghe in gheChon)
            {
                if (heSoGiaGhe.TryGetValue(ghe, out double hs))
                    tongTien += giaChuan * hs;
            }

            // Cập nhật ghế đã bán
            foreach (string ghe in gheChon)
                gheDaBan.Add((phong, ghe));

            // In hóa đơn
            lstHoaDon.Items.Add($"Khách: {tenKhach}");
            lstHoaDon.Items.Add($"Phim : {tenPhim}");
            lstHoaDon.Items.Add($"Phòng: {phong}");
            lstHoaDon.Items.Add($"Ghế  : {string.Join(", ", gheChon)}");
            lstHoaDon.Items.Add($"Tổng : {tongTien:N0} đ");
            lstHoaDon.Items.Add(new string('-', 40));

            // Cập nhật lại giao diện ghế (đổi sang đỏ)
            foreach (Button b in pnlSoDoGhe.Controls.OfType<Button>())
            {
                if (gheChon.Contains(b.Text))
                {
                    b.BackColor = Color.Red;
                    b.Enabled = false;
                }
            }

            txtKhach.Clear();
        }

        // ==========================
        // XÓA / LÀM MỚI
        // ==========================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKhach.Clear();
            foreach (Button b in pnlSoDoGhe.Controls.OfType<Button>())
            {
                if (b.Enabled)
                {
                    if (new[] { "A1", "A5", "C1", "C5" }.Contains(b.Text))
                        b.BackColor = Color.LightGreen;
                    else if (new[] { "B2", "B3", "B4" }.Contains(b.Text))
                        b.BackColor = Color.MediumPurple;
                    else
                        b.BackColor = Color.LightGray;
                }
            }
            txtKhach.Focus();
        }
    }
}
