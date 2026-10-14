namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTinh = new Button();
            btnLamMoi = new Button();
            lblTongTien = new Label();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtGiamGia = new TextBox();
            lblDongiadv = new Label();
            lblSoluong = new Label();
            lblMagiam = new Label();
            SuspendLayout();
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(109, 181);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(150, 46);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tính tiền";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(277, 181);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(150, 46);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongTien.Location = new Point(109, 243);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(367, 64);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Tổng tiền thanh toán: 0 VNĐ";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(227, 12);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.PlaceholderText = "Đơn giá dịch vụ";
            txtDonGia.Size = new Size(249, 39);
            txtDonGia.TabIndex = 1;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(227, 67);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.PlaceholderText = "Số lượng khách";
            txtSoLuong.Size = new Size(249, 39);
            txtSoLuong.TabIndex = 2;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(227, 122);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.PlaceholderText = "Mã giảm giá (% giảm)";
            txtGiamGia.Size = new Size(249, 39);
            txtGiamGia.TabIndex = 3;
            txtGiamGia.TextChanged += txtGiamGia_TextChanged;
            // 
            // lblDongiadv
            // 
            lblDongiadv.AutoSize = true;
            lblDongiadv.Location = new Point(66, 19);
            lblDongiadv.Name = "lblDongiadv";
            lblDongiadv.Size = new Size(110, 32);
            lblDongiadv.TabIndex = 6;
            lblDongiadv.Text = "Đơn giá :";
            // 
            // lblSoluong
            // 
            lblSoluong.AutoSize = true;
            lblSoluong.Location = new Point(66, 74);
            lblSoluong.Name = "lblSoluong";
            lblSoluong.Size = new Size(122, 32);
            lblSoluong.TabIndex = 7;
            lblSoluong.Text = "Số lượng :";
            lblSoluong.Click += label2_Click;
            // 
            // lblMagiam
            // 
            lblMagiam.AutoSize = true;
            lblMagiam.Location = new Point(66, 125);
            lblMagiam.Name = "lblMagiam";
            lblMagiam.Size = new Size(120, 32);
            lblMagiam.TabIndex = 8;
            lblMagiam.Text = "Giảm giá :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 306);
            Controls.Add(lblMagiam);
            Controls.Add(lblSoluong);
            Controls.Add(lblDongiadv);
            Controls.Add(txtGiamGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(lblTongTien);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTinh);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Charge Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTinh;
        private Button btnLamMoi;
        private Label lblTongTien;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtGiamGia;
        private Label lblDongiadv;
        private Label lblSoluong;
        private Label lblMagiam;
    }
}
