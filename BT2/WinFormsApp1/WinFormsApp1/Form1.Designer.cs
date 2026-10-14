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
            lblMaPhieu = new Label();
            lblNguoiYeuCau = new Label();
            lblNgayGhiNhan = new Label();
            label4 = new Label();
            txtMaPhieu = new TextBox();
            txtNguoiYeuCau = new TextBox();
            dtpNgayGhiNhan = new DateTimePicker();
            groupBox1 = new GroupBox();
            rdoKhanCap = new RadioButton();
            rdoTrungBinh = new RadioButton();
            rdoThap = new RadioButton();
            label5 = new Label();
            cboLoaiSuCo = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            chkMayTinhBan = new CheckBox();
            chkLaptop = new CheckBox();
            chkMayIn = new CheckBox();
            chkDienThoai = new CheckBox();
            picAnhLoi = new PictureBox();
            btnTaiAnh = new Button();
            btnGui = new Button();
            btnNhapLai = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(12, 14);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(116, 32);
            lblMaPhieu.TabIndex = 0;
            lblMaPhieu.Text = "Mã phiếu";
            // 
            // lblNguoiYeuCau
            // 
            lblNguoiYeuCau.AutoSize = true;
            lblNguoiYeuCau.Location = new Point(12, 77);
            lblNguoiYeuCau.Name = "lblNguoiYeuCau";
            lblNguoiYeuCau.Size = new Size(170, 32);
            lblNguoiYeuCau.TabIndex = 1;
            lblNguoiYeuCau.Text = "Người yêu cầu";
            lblNguoiYeuCau.Click += label2_Click;
            // 
            // lblNgayGhiNhan
            // 
            lblNgayGhiNhan.AutoSize = true;
            lblNgayGhiNhan.Location = new Point(12, 139);
            lblNgayGhiNhan.Name = "lblNgayGhiNhan";
            lblNgayGhiNhan.Size = new Size(172, 32);
            lblNgayGhiNhan.TabIndex = 2;
            lblNgayGhiNhan.Text = "Ngày ghi nhận";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 199);
            label4.Name = "label4";
            label4.Size = new Size(179, 32);
            label4.TabIndex = 3;
            label4.Text = "Mức độ ưu tiên";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(285, 7);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(200, 39);
            txtMaPhieu.TabIndex = 4;
            // 
            // txtNguoiYeuCau
            // 
            txtNguoiYeuCau.Location = new Point(285, 74);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.Size = new Size(200, 39);
            txtNguoiYeuCau.TabIndex = 5;
            // 
            // dtpNgayGhiNhan
            // 
            dtpNgayGhiNhan.Location = new Point(285, 134);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(400, 39);
            dtpNgayGhiNhan.TabIndex = 6;
            dtpNgayGhiNhan.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoKhanCap);
            groupBox1.Controls.Add(rdoTrungBinh);
            groupBox1.Controls.Add(rdoThap);
            groupBox1.Location = new Point(287, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 88);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn độ ưu tiên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdoKhanCap
            // 
            rdoKhanCap.AutoSize = true;
            rdoKhanCap.Location = new Point(308, 35);
            rdoKhanCap.Name = "rdoKhanCap";
            rdoKhanCap.Size = new Size(143, 36);
            rdoKhanCap.TabIndex = 2;
            rdoKhanCap.TabStop = true;
            rdoKhanCap.Text = "Khẩn cấp";
            rdoKhanCap.UseVisualStyleBackColor = true;
            // 
            // rdoTrungBinh
            // 
            rdoTrungBinh.AutoSize = true;
            rdoTrungBinh.Location = new Point(122, 35);
            rdoTrungBinh.Name = "rdoTrungBinh";
            rdoTrungBinh.Size = new Size(161, 36);
            rdoTrungBinh.TabIndex = 1;
            rdoTrungBinh.TabStop = true;
            rdoTrungBinh.Text = "Trung bình";
            rdoTrungBinh.UseVisualStyleBackColor = true;
            // 
            // rdoThap
            // 
            rdoThap.AutoSize = true;
            rdoThap.Location = new Point(3, 35);
            rdoThap.Name = "rdoThap";
            rdoThap.Size = new Size(98, 36);
            rdoThap.TabIndex = 0;
            rdoThap.TabStop = true;
            rdoThap.Text = "Thấp";
            rdoThap.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 285);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 9;
            label5.Text = "Loại sự cố";
            // 
            // cboLoaiSuCo
            // 
            cboLoaiSuCo.FormattingEnabled = true;
            cboLoaiSuCo.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cboLoaiSuCo.Location = new Point(287, 282);
            cboLoaiSuCo.Name = "cboLoaiSuCo";
            cboLoaiSuCo.Size = new Size(242, 40);
            cboLoaiSuCo.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 345);
            label6.Name = "label6";
            label6.Size = new Size(219, 32);
            label6.TabIndex = 11;
            label6.Text = "Thiết bị ảnh hưởng";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 425);
            label7.Name = "label7";
            label7.Size = new Size(150, 32);
            label7.TabIndex = 12;
            label7.Text = "Ảnh chụp lỗi";
            // 
            // chkMayTinhBan
            // 
            chkMayTinhBan.AutoSize = true;
            chkMayTinhBan.Location = new Point(287, 345);
            chkMayTinhBan.Name = "chkMayTinhBan";
            chkMayTinhBan.Size = new Size(188, 36);
            chkMayTinhBan.TabIndex = 13;
            chkMayTinhBan.Text = "Máy tính bàn";
            chkMayTinhBan.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(472, 345);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(119, 36);
            chkLaptop.TabIndex = 14;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(287, 383);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(119, 36);
            chkMayIn.TabIndex = 15;
            chkMayIn.Text = "Máy in";
            chkMayIn.UseVisualStyleBackColor = true;
            // 
            // chkDienThoai
            // 
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(472, 383);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(157, 36);
            chkDienThoai.TabIndex = 16;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // picAnhLoi
            // 
            picAnhLoi.Location = new Point(285, 425);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(200, 100);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 17;
            picAnhLoi.TabStop = false;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(501, 425);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(150, 46);
            btnTaiAnh.TabIndex = 18;
            btnTaiAnh.Text = "Tải ảnh lỗi";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            // 
            // btnGui
            // 
            btnGui.Location = new Point(285, 550);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(150, 46);
            btnGui.TabIndex = 19;
            btnGui.Text = "Gửi yêu cầu";
            btnGui.UseVisualStyleBackColor = true;
            btnGui.Click += btnGui_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(460, 550);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(150, 46);
            btnNhapLai.TabIndex = 20;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 644);
            Controls.Add(btnNhapLai);
            Controls.Add(btnGui);
            Controls.Add(btnTaiAnh);
            Controls.Add(picAnhLoi);
            Controls.Add(chkDienThoai);
            Controls.Add(chkMayIn);
            Controls.Add(chkLaptop);
            Controls.Add(chkMayTinhBan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cboLoaiSuCo);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(dtpNgayGhiNhan);
            Controls.Add(txtNguoiYeuCau);
            Controls.Add(txtMaPhieu);
            Controls.Add(label4);
            Controls.Add(lblNgayGhiNhan);
            Controls.Add(lblNguoiYeuCau);
            Controls.Add(lblMaPhieu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IT Support Ticket Form";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaPhieu;
        private Label lblNguoiYeuCau;
        private Label lblNgayGhiNhan;
        private Label label4;
        private TextBox txtMaPhieu;
        private TextBox txtNguoiYeuCau;
        private DateTimePicker dtpNgayGhiNhan;
        private GroupBox groupBox1;
        private RadioButton rdoTrungBinh;
        private RadioButton rdoThap;
        private RadioButton rdoKhanCap;
        private Label label5;
        private ComboBox cboLoaiSuCo;
        private Label label6;
        private Label label7;
        private CheckBox chkMayTinhBan;
        private CheckBox chkLaptop;
        private CheckBox chkMayIn;
        private CheckBox chkDienThoai;
        private PictureBox picAnhLoi;
        private Button btnTaiAnh;
        private Button btnGui;
        private Button btnNhapLai;
    }
}
