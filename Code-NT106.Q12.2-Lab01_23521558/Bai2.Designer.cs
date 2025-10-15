namespace _23521558_lab01
{
    partial class Bai2
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
            tb_num3 = new TextBox();
            tb_max = new TextBox();
            tb_min = new TextBox();
            btn_tim = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // tb_num1
            // 
            tb_num1.Location = new Point(120, 34);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(125, 27);
            tb_num1.TabIndex = 5;
            tb_num1.TextChanged += tb_num1_TextChanged;
            // 
            // tb_num2
            // 
            tb_num2.Location = new Point(389, 34);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(125, 27);
            tb_num2.TabIndex = 6;
            tb_num2.TextChanged += tb_num2_TextChanged;
            // 
            // tb_num3
            // 
            tb_num3.Location = new Point(663, 34);
            tb_num3.Name = "tb_num3";
            tb_num3.Size = new Size(125, 27);
            tb_num3.TabIndex = 7;
            tb_num3.TextChanged += tb_num3_TextChanged;
            // 
            // tb_max
            // 
            tb_max.Location = new Point(212, 300);
            tb_max.Name = "tb_max";
            tb_max.ReadOnly = true;
            tb_max.Size = new Size(125, 27);
            tb_max.TabIndex = 8;
            tb_max.TextChanged += tb_max_TextChanged;
            // 
            // tb_min
            // 
            tb_min.Location = new Point(553, 300);
            tb_min.Name = "tb_min";
            tb_min.ReadOnly = true;
            tb_min.Size = new Size(125, 27);
            tb_min.TabIndex = 9;
            tb_min.TextChanged += tb_min_TextChanged;
            // 
            // btn_tim
            // 
            btn_tim.BackColor = Color.LightGray;
            btn_tim.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_tim.Location = new Point(120, 174);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(94, 29);
            btn_tim.TabIndex = 10;
            btn_tim.Text = "Tìm";
            btn_tim.UseVisualStyleBackColor = false;
            btn_tim.Click += btn_tim_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.LightGray;
            btn_xoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_xoa.Location = new Point(343, 174);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 11;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.LightGray;
            btn_thoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_thoat.Location = new Point(574, 174);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 29);
            btn_thoat.TabIndex = 12;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 13;
            label1.Text = "Số thứ nhất";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(283, 38);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 14;
            label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(557, 38);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 15;
            label3.Text = "Số thứ ba";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 304);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 16;
            label4.Text = "Số lớn nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(436, 304);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 17;
            label5.Text = "Số nhỏ nhất";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tim);
            Controls.Add(tb_min);
            Controls.Add(tb_max);
            Controls.Add(tb_num3);
            Controls.Add(tb_num2);
            Controls.Add(tb_num1);
            Name = "Bai2";
            Text = "Bai2";
            Load += Bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_num1;
        private TextBox tb_num2;
        private TextBox tb_num3;
        private TextBox tb_max;
        private TextBox tb_min;
        private Button btn_tim;
        private Button btn_xoa;
        private Button btn_thoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}