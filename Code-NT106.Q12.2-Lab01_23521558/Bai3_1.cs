using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23521558_lab01
{
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_input.Clear();
            tb_ketqua.Clear();
            tb_input.Focus();
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            string raw = tb_input.Text ?? "";

            // Chuẩn hóa: bỏ khoảng trắng, dấu phẩy, dấu chấm
            string normalized = raw.Replace(" ", "")
                                   .Replace(",", "")
                                   .Replace(".", "");

            // Chỉ cho phép chữ số
            if (string.IsNullOrEmpty(normalized) || !normalized.All(char.IsDigit))
            {
                MessageBox.Show("Bạn phải nhập số nguyên!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Giới hạn 12 chữ số
            if (normalized.Length > 12)
            {
                MessageBox.Show("Vui lòng nhập số từ 0 đến 12 chữ số!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long number = long.Parse(normalized);
            tb_ketqua.Text = DocSoTiengViet(number);
        }

        // ---------------------------
        // Hàm đọc số bằng chữ
        // ---------------------------
        private string[] soChu = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        private string DocSo3ChuSo(int n, bool docDayDu)
        {
            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donvi = n % 10;
            string kq = "";

            if (tram > 0)
            {
                kq += soChu[tram] + " trăm";
                if (chuc == 0 && donvi > 0) kq += " lẻ";
            }
            else if (docDayDu && (chuc > 0 || donvi > 0))
            {
                kq += "không trăm";
                if (chuc == 0 && donvi > 0) kq += " lẻ";
            }

            if (chuc > 1)
            {
                kq += (kq == "" ? "" : " ") + soChu[chuc] + " mươi";
                if (donvi == 1) kq += " mốt";
                else if (donvi == 5) kq += " lăm";
                else if (donvi > 0) kq += " " + soChu[donvi];
            }
            else if (chuc == 1)
            {
                kq += (kq == "" ? "" : " ") + "mười";
                if (donvi == 1) kq += " một";
                else if (donvi == 5) kq += " lăm";
                else if (donvi > 0) kq += " " + soChu[donvi];
            }
            else if (chuc == 0 && donvi > 0)
            {
                kq += (kq == "" ? "" : " ") + soChu[donvi];
            }

            return kq.Trim();
        }

        private string DocSoTiengViet(long n)
        {
            if (n == 0) return "Không";

            int[] group = new int[4];
            group[3] = (int)(n % 1000); n /= 1000;       // đơn vị
            group[2] = (int)(n % 1000); n /= 1000;       // nghìn
            group[1] = (int)(n % 1000); n /= 1000;       // triệu
            group[0] = (int)(n % 1000);                  // tỷ

            string[] donViNhom = { "tỷ", "triệu", "nghìn", "" };

            string ketQua = "";
            bool daGapNhomTruoc = false; // đã có nhóm lớn hơn khác 0 chưa?

            for (int i = 0; i < 4; i++)
            {
                if (group[i] > 0)
                {
                    // nếu đã có nhóm trước đó và nhóm hiện tại < 100 => phải đọc "không trăm/lẻ"
                    bool docDayDu = daGapNhomTruoc;
                    string g = DocSo3ChuSo(group[i], docDayDu);
                    ketQua += (ketQua == "" ? "" : " ") + g;
                    if (donViNhom[i] != "") ketQua += " " + donViNhom[i];
                    daGapNhomTruoc = true;
                }
                else
                {
                    // nhóm 0 nhưng vẫn đánh dấu đã gặp để nhóm sau <100 đọc đầy đủ
                    if (daGapNhomTruoc) daGapNhomTruoc = true;
                }
            }

            return ketQua.Trim();
        }
    
    }
}
