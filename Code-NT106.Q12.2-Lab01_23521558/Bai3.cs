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
    public partial class Bai3 : Form
    {
        public Bai3()
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
            int n;
            if (int.TryParse(tb_input.Text, out n))
            {
                string kq;
                switch (n)
                {
                    case 0: kq = "Không"; break;
                    case 1: kq = "Một"; break;
                    case 2: kq = "Hai"; break;
                    case 3: kq = "Ba"; break;
                    case 4: kq = "Bốn"; break;
                    case 5: kq = "Năm"; break;
                    case 6: kq = "Sáu"; break;
                    case 7: kq = "Bảy"; break;
                    case 8: kq = "Tám"; break;
                    case 9: kq = "Chín"; break;
                    default:
                        kq = "Vui lòng nhập số từ 0 đến 9!";
                        break;
                }

                tb_ketqua.Text = kq;
            }
            else
            {
                MessageBox.Show("Bạn phải nhập số nguyên!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_ketqua3_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
