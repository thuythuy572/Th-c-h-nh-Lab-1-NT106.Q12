using System;
using System.Windows.Forms;

namespace _23521558_lab01
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int ngay = (int)numNgay.Value;
            int thang = (int)numThang.Value;
            int nam = (int)numNam.Value;
            int maxDay = DateTime.DaysInMonth(nam, thang);
            if (ngay < 1 || ngay > maxDay)
            {
                MessageBox.Show("Ngày tháng không hợp lệ!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKetQua.Clear();
                return;
            }
            string cung = "";

            switch (thang)
            {
                case 1:
                    cung = (ngay >= 21) ? "Bảo Bình" : "Ma Kết";
                    break;
                case 2:
                    cung = (ngay >= 20) ? "Song Ngư" : "Bảo Bình";
                    break;
                case 3:
                    cung = (ngay >= 21) ? "Bạch Dương" : "Song Ngư";
                    break;
                case 4:
                    cung = (ngay >= 21) ? "Kim Ngưu" : "Bạch Dương";
                    break;
                case 5:
                    cung = (ngay >= 22) ? "Song Tử" : "Kim Ngưu";
                    break;
                case 6:
                    cung = (ngay >= 22) ? "Cự Giải" : "Song Tử";
                    break;
                case 7:
                    cung = (ngay >= 23) ? "Sư Tử" : "Cự Giải";
                    break;
                case 8:
                    cung = (ngay >= 23) ? "Xử Nữ" : "Sư Tử";
                    break;
                case 9:
                    cung = (ngay >= 24) ? "Thiên Bình" : "Xử Nữ";
                    break;
                case 10:
                    cung = (ngay >= 24) ? "Thần Nông" : "Thiên Bình";
                    break;
                case 11:
                    cung = (ngay >= 23) ? "Nhân Mã" : "Thần Nông";
                    break;
                case 12:
                    cung = (ngay >= 22) ? "Ma Kết" : "Nhân Mã";
                    break;
                default:
                    cung = "Không hợp lệ!";
                    break;
            }

            txtKetQua.Text = $"Ngày {ngay}/{thang}/{nam} → Cung {cung}";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            numNgay.Value = 1;
            numThang.Value = 1;
            numNam.Value = DateTime.Now.Year;
            txtKetQua.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
