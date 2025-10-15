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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_num1.Text, out int num1) && (int.TryParse(tb_num2.Text, out int num2)))
            {
                int sum = num1 + num2;
                tb_result.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui long nhap so nguyen", "Loi nhap lieu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
