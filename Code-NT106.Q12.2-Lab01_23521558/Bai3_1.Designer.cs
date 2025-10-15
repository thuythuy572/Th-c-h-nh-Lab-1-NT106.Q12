namespace _23521558_lab01
{
    partial class Bai3_1
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
            btn_doc = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            tb_input = new TextBox();
            tb_ketqua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 58);
            label1.Name = "label1";
            label1.Size = new Size(296, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào một số có tối đa 12 chữ số:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 239);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 1;
            label2.Text = "Kết quả:";
            // 
            // btn_doc
            // 
            btn_doc.BackColor = SystemColors.ControlLight;
            btn_doc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_doc.Location = new Point(654, 58);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(94, 29);
            btn_doc.TabIndex = 2;
            btn_doc.Text = "Đọc";
            btn_doc.UseVisualStyleBackColor = false;
            btn_doc.Click += btn_doc_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = SystemColors.ControlLight;
            btn_xoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_xoa.Location = new Point(654, 159);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 3;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = SystemColors.ControlLight;
            btn_thoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_thoat.Location = new Point(654, 278);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 29);
            btn_thoat.TabIndex = 4;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // tb_input
            // 
            tb_input.Location = new Point(360, 54);
            tb_input.Name = "tb_input";
            tb_input.Size = new Size(125, 27);
            tb_input.TabIndex = 5;
            // 
            // tb_ketqua
            // 
            tb_ketqua.Location = new Point(37, 280);
            tb_ketqua.Name = "tb_ketqua";
            tb_ketqua.ReadOnly = true;
            tb_ketqua.Size = new Size(529, 27);
            tb_ketqua.TabIndex = 6;
            // 
            // Bai3_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_ketqua);
            Controls.Add(tb_input);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_doc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai3_1";
            Text = "Bai3_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_doc;
        private Button btn_xoa;
        private Button btn_thoat;
        private TextBox tb_input;
        private TextBox tb_ketqua;
    }
}