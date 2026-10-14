namespace Item_List_Manager
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
            grpNhapLieu = new GroupBox();
            cboDonViTinh = new ComboBox();
            txtDonGia = new TextBox();
            txtTenVT = new TextBox();
            txtMaVT = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpDanhSach = new GroupBox();
            lvVatTu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoaTatCa = new Button();
            btnXoaDong = new Button();
            grpNhapLieu.SuspendLayout();
            grpDanhSach.SuspendLayout();
            SuspendLayout();
            // 
            // grpNhapLieu
            // 
            grpNhapLieu.Controls.Add(cboDonViTinh);
            grpNhapLieu.Controls.Add(txtDonGia);
            grpNhapLieu.Controls.Add(txtTenVT);
            grpNhapLieu.Controls.Add(txtMaVT);
            grpNhapLieu.Controls.Add(label4);
            grpNhapLieu.Controls.Add(label3);
            grpNhapLieu.Controls.Add(label2);
            grpNhapLieu.Controls.Add(label1);
            grpNhapLieu.Location = new Point(25, 12);
            grpNhapLieu.Name = "grpNhapLieu";
            grpNhapLieu.Size = new Size(400, 270);
            grpNhapLieu.TabIndex = 0;
            grpNhapLieu.TabStop = false;
            grpNhapLieu.Text = "Thông tin vật tư";
            // 
            // cboDonViTinh
            // 
            cboDonViTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonViTinh.FormattingEnabled = true;
            cboDonViTinh.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDonViTinh.Location = new Point(178, 160);
            cboDonViTinh.Name = "cboDonViTinh";
            cboDonViTinh.Size = new Size(200, 40);
            cboDonViTinh.TabIndex = 6;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(178, 217);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(200, 39);
            txtDonGia.TabIndex = 7;
            // 
            // txtTenVT
            // 
            txtTenVT.Location = new Point(178, 102);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(200, 39);
            txtTenVT.TabIndex = 5;
            // 
            // txtMaVT
            // 
            txtMaVT.Location = new Point(178, 47);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(200, 39);
            txtMaVT.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 224);
            label4.Name = "label4";
            label4.Size = new Size(164, 32);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 168);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 2;
            label3.Text = "Đơn vị tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 109);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 1;
            label2.Text = "Tên vật tư:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã vật tư:";
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(lvVatTu);
            grpDanhSach.Location = new Point(449, 12);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(574, 270);
            grpDanhSach.TabIndex = 1;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách vật tư";
            grpDanhSach.Enter += groupBox2_Enter;
            // 
            // lvVatTu
            // 
            lvVatTu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvVatTu.Dock = DockStyle.Fill;
            lvVatTu.FullRowSelect = true;
            lvVatTu.Location = new Point(3, 35);
            lvVatTu.MultiSelect = false;
            lvVatTu.Name = "lvVatTu";
            lvVatTu.Size = new Size(568, 232);
            lvVatTu.TabIndex = 0;
            lvVatTu.UseCompatibleStateImageBehavior = false;
            lvVatTu.View = View.Details;
            lvVatTu.SelectedIndexChanged += lvVatTu_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã VT";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên VT";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn vị tính";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Đơn giá";
            columnHeader4.Width = 120;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(253, 299);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(452, 299);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(150, 46);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click_1;
            // 
            // btnXoaTatCa
            // 
            btnXoaTatCa.Location = new Point(848, 299);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(172, 46);
            btnXoaTatCa.TabIndex = 5;
            btnXoaTatCa.Text = "Xóa toàn bộ";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            btnXoaTatCa.Click += btnXoaTatCa_Click_1;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(655, 299);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(150, 46);
            btnXoaDong.TabIndex = 4;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 379);
            Controls.Add(btnXoaDong);
            Controls.Add(btnXoaTatCa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(grpDanhSach);
            Controls.Add(grpNhapLieu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item List Manager";
            grpNhapLieu.ResumeLayout(false);
            grpNhapLieu.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNhapLieu;
        private TextBox txtDonGia;
        private TextBox txtTenVT;
        private TextBox txtMaVT;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpDanhSach;
        private ComboBox cboDonViTinh;
        private ListView lvVatTu;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoaTatCa;
        private Button btnXoaDong;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
