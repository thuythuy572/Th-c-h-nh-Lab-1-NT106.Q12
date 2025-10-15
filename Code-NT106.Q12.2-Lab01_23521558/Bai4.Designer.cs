namespace _23521558_lab01
{
    partial class Bai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.pnlSoDoGhe = new System.Windows.Forms.Panel();
            this.txtKhach = new System.Windows.Forms.TextBox();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstHoaDon = new System.Windows.Forms.ListBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhim = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblSoDo = new System.Windows.Forms.Label();
            this.lblKhach = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblManHinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(25, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(227, 32);
            this.lblTieuDe.Text = "QUẢN LÝ PHÒNG VÉ";
            // 
            // lblPhim
            // 
            this.lblPhim.AutoSize = true;
            this.lblPhim.Location = new System.Drawing.Point(28, 70);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(43, 20);
            this.lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            this.cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(90, 66);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(260, 28);
            this.cboPhim.SelectedIndexChanged += new System.EventHandler(this.cboPhim_SelectedIndexChanged);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(28, 110);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(54, 20);
            this.lblPhong.Text = "Phòng:";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(90, 106);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(120, 28);
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            // 
            // lblSoDo
            // 
            this.lblSoDo.AutoSize = true;
            this.lblSoDo.Location = new System.Drawing.Point(28, 150);
            this.lblSoDo.Name = "lblSoDo";
            this.lblSoDo.Size = new System.Drawing.Size(84, 20);
            this.lblSoDo.Text = "Sơ đồ ghế:";
            // 
            // lblManHinh
            // 
            this.lblManHinh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblManHinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblManHinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblManHinh.Location = new System.Drawing.Point(32, 170);
            this.lblManHinh.Name = "lblManHinh";
            this.lblManHinh.Size = new System.Drawing.Size(330, 25);
            this.lblManHinh.TabIndex = 99;
            this.lblManHinh.Text = "MÀN HÌNH";
            this.lblManHinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSoDoGhe
            // 
            this.pnlSoDoGhe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSoDoGhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSoDoGhe.Location = new System.Drawing.Point(32, 200);
            this.pnlSoDoGhe.Name = "pnlSoDoGhe";
            this.pnlSoDoGhe.Size = new System.Drawing.Size(330, 180);
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Location = new System.Drawing.Point(28, 400);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(57, 20);
            this.lblKhach.Text = "Họ tên:";
            // 
            // txtKhach
            // 
            this.txtKhach.Location = new System.Drawing.Point(90, 396);
            this.txtKhach.Name = "txtKhach";
            this.txtKhach.Size = new System.Drawing.Size(260, 27);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BackColor = System.Drawing.Color.LightGreen;
            this.btnDatVe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatVe.Location = new System.Drawing.Point(90, 440);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(100, 35);
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = false;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(210, 440);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Text = "Xóa chọn";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Location = new System.Drawing.Point(400, 70);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(126, 20);
            this.lblHoaDon.Text = "Hóa đơn / Kết quả";
            // 
            // lstHoaDon
            // 
            this.lstHoaDon.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstHoaDon.FormattingEnabled = true;
            this.lstHoaDon.ItemHeight = 20;
            this.lstHoaDon.Location = new System.Drawing.Point(400, 95);
            this.lstHoaDon.Name = "lstHoaDon";
            this.lstHoaDon.Size = new System.Drawing.Size(390, 364);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 500);
            this.Controls.Add(this.lblManHinh);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblPhim);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.lblSoDo);
            this.Controls.Add(this.pnlSoDoGhe);
            this.Controls.Add(this.lblKhach);
            this.Controls.Add(this.txtKhach);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lstHoaDon);
            this.Name = "Bai4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 04 - Quản lý phòng vé";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Panel pnlSoDoGhe;
        private System.Windows.Forms.TextBox txtKhach;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lstHoaDon;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblSoDo;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblManHinh;
    }
}
