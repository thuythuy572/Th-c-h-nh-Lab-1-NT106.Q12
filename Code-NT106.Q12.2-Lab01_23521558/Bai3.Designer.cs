namespace _23521558_lab01
{
    partial class Bai3
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
            label1 = new Label();
            label2 = new Label();
            tb_input = new TextBox();
            tb_ketqua = new TextBox();
            btn_doc = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 68);
            label1.Name = "label1";
            label1.Size = new Size(251, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 226);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 1;
            label2.Text = "Kết quả";
            // 
            // tb_input
            // 
            tb_input.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_input.Location = new Point(338, 61);
            tb_input.Name = "tb_input";
            tb_input.Size = new Size(139, 30);
            tb_input.TabIndex = 2;
            // 
            // tb_ketqua
            // 
            tb_ketqua.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ketqua.Location = new Point(34, 280);
            tb_ketqua.Name = "tb_ketqua";
            tb_ketqua.ReadOnly = true;
            tb_ketqua.Size = new Size(354, 30);
            tb_ketqua.TabIndex = 3;
            // 
            // btn_doc
            // 
            btn_doc.BackColor = Color.FromArgb(224, 224, 224);
            btn_doc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_doc.Location = new Point(599, 51);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(94, 40);
            btn_doc.TabIndex = 4;
            btn_doc.Text = "Đọc";
            btn_doc.UseVisualStyleBackColor = false;
            btn_doc.Click += btn_doc_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.FromArgb(224, 224, 224);
            btn_xoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_xoa.Location = new Point(599, 141);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 40);
            btn_xoa.TabIndex = 5;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.FromArgb(224, 224, 224);
            btn_thoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_thoat.Location = new Point(599, 236);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 40);
            btn_thoat.TabIndex = 6;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_doc);
            Controls.Add(tb_ketqua);
            Controls.Add(tb_input);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_input;
        private TextBox tb_ketqua;
        private Button btn_doc;
        private Button btn_xoa;
        private Button btn_thoat;
    }
}