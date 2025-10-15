namespace _23521558_lab01
{
    partial class Bai1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_num1 = new TextBox();
            tb_num2 = new TextBox();
            btn_tinh = new Button();
            tb_result = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tb_num1
            // 
            tb_num1.Location = new Point(350, 114);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(258, 27);
            tb_num1.TabIndex = 3;
            tb_num1.TextChanged += tb_num1_TextChanged;
            // 
            // tb_num2
            // 
            tb_num2.Location = new Point(350, 203);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(258, 27);
            tb_num2.TabIndex = 4;
            // 
            // btn_tinh
            // 
            btn_tinh.Location = new Point(350, 274);
            btn_tinh.Name = "btn_tinh";
            btn_tinh.Size = new Size(94, 29);
            btn_tinh.TabIndex = 5;
            btn_tinh.Text = "Tính";
            btn_tinh.UseVisualStyleBackColor = true;
            btn_tinh.Click += btn_tinh_Click;
            // 
            // tb_result
            // 
            tb_result.Location = new Point(350, 334);
            tb_result.Name = "tb_result";
            tb_result.ReadOnly = true;
            tb_result.Size = new Size(258, 27);
            tb_result.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 53);
            label1.Name = "label1";
            label1.Size = new Size(286, 28);
            label1.TabIndex = 7;
            label1.Text = "TÍNH TỔNG HAI SỐ NGUYÊN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 118);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 8;
            label2.Text = "Số thứ nhất";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(169, 207);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 9;
            label3.Text = "Số thứ hai";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(169, 338);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 10;
            label4.Text = "Kết quả";
            label4.Click += label4_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_result);
            Controls.Add(btn_tinh);
            Controls.Add(tb_num2);
            Controls.Add(tb_num1);
            Name = "Bai1";
            Text = "Bai1";
            Load += Bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_num1;
        private TextBox tb_num2;
        private Button btn_tinh;
        private TextBox tb_result;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}