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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void tb_sothuba_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_num3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(tb_num1.Text);
                double num2 = double.Parse(tb_num2.Text);
                double num3 = double.Parse(tb_num3.Text);

                double max = num1;
                if (num2 > max) max = num2;
                if (num3 > max) max = num3;

                double min = num1;
                if (num2 < min) min = num2;
                if (num3 < min) min = num3;

                tb_max.Text = max.ToString();
                tb_min.Text = min.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng số!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void tb_max_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_num1.Clear();
            tb_num2.Clear();
            tb_num3.Clear();
            tb_max.Clear();
            tb_min.Clear();

            tb_num1.Focus(); // dua con tro nhap lieu vao o nay
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_sonhonhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_sothunhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
