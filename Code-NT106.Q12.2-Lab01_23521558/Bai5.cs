using System;
using System.Windows.Forms;

namespace _23521558_lab01
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            // Thêm các lựa chọn vào ComboBox
            cboLuaChon.Items.Add("Bảng cửu chương");
            cboLuaChon.Items.Add("Tính toán giá trị");
            cboLuaChon.SelectedIndex = 0; // Mặc định chọn dòng đầu tiên
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            // Xóa kết quả cũ
            txtKetQua.Clear();

            // Kiểm tra dữ liệu nhập
            if (!int.TryParse(txtA.Text, out int A) || !int.TryParse(txtB.Text, out int B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy lựa chọn trong ComboBox
            string luaChon = cboLuaChon.SelectedItem.ToString();

            if (luaChon == "Bảng cửu chương")
            {
                if (A > B)
                {
                    txtKetQua.AppendText("Lỗi: A phải nhỏ hơn hoặc bằng B để in bảng cửu chương.\r\n");
                    return;
                }
                // In bảng cửu chương từ A đến B
                for (int i = A; i <= B; i++)
                {
                    txtKetQua.AppendText($"--- Bảng cửu chương {i} ---\r\n");
                    for (int j = 1; j <= 10; j++)
                    {
                        txtKetQua.AppendText($"{i} x {j} = {i * j}\r\n");
                    }
                    txtKetQua.AppendText("\r\n");
                }
            }
            else if (luaChon == "Tính toán giá trị")
            {
                int hieu = A - B;

                // Tính giai thừa của (A - B)
                long giaiThua = 1;
                if (hieu < 0)
                    txtKetQua.AppendText($"Không thể tính giai thừa của số âm ({hieu})\r\n");
                else
                {
                    for (int i = 1; i <= hieu; i++)
                        giaiThua *= i;
                    txtKetQua.AppendText($"({A} - {B})! = {giaiThua}\r\n");
                }

                // Tính tổng S = A^1 + A^2 + ... + A^B
                double tong = 0;
                for (int i = 1; i <= B; i++)
                    tong += Math.Pow(A, i);

                txtKetQua.AppendText($"Tổng S = A¹ + A² + ... + Aᴮ = {tong}\r\n");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
