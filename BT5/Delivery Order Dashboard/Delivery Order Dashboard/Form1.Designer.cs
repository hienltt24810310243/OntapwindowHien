namespace Delivery_Order_Dashboard
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
            components = new System.ComponentModel.Container();
            splMain = new SplitContainer();
            cboLoaiVC = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvHangHoa = new DataGridView();
            colTenHang = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colTrongLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            stsMain = new StatusStrip();
            tslThoiGian = new ToolStripStatusLabel();
            tslTongSoLuong = new ToolStripStatusLabel();
            tslTongTrongLuong = new ToolStripStatusLabel();
            tslTongTien = new ToolStripStatusLabel();
            tmrDongHo = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splMain).BeginInit();
            splMain.Panel1.SuspendLayout();
            splMain.Panel2.SuspendLayout();
            splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            stsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splMain
            // 
            splMain.Dock = DockStyle.Fill;
            splMain.Location = new Point(0, 0);
            splMain.Name = "splMain";
            // 
            // splMain.Panel1
            // 
            splMain.Panel1.Controls.Add(cboLoaiVC);
            splMain.Panel1.Controls.Add(textBox3);
            splMain.Panel1.Controls.Add(textBox2);
            splMain.Panel1.Controls.Add(textBox1);
            splMain.Panel1.Controls.Add(label4);
            splMain.Panel1.Controls.Add(label3);
            splMain.Panel1.Controls.Add(label2);
            splMain.Panel1.Controls.Add(label1);
            // 
            // splMain.Panel2
            // 
            splMain.Panel2.Controls.Add(dgvHangHoa);
            splMain.Size = new Size(1274, 529);
            splMain.SplitterDistance = 450;
            splMain.TabIndex = 0;
            // 
            // cboLoaiVC
            // 
            cboLoaiVC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiVC.FormattingEnabled = true;
            cboLoaiVC.Location = new Point(218, 188);
            cboLoaiVC.Name = "cboLoaiVC";
            cboLoaiVC.Size = new Size(200, 40);
            cboLoaiVC.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(218, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 196);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 3;
            label4.Text = "Loại vận chuyển:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(206, 32);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ giao hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng:";
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Columns.AddRange(new DataGridViewColumn[] { colTenHang, colSoLuong, colTrongLuong, colDonGia, colThanhTien });
            dgvHangHoa.Dock = DockStyle.Fill;
            dgvHangHoa.Location = new Point(0, 0);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersVisible = false;
            dgvHangHoa.RowHeadersWidth = 82;
            dgvHangHoa.Size = new Size(820, 529);
            dgvHangHoa.TabIndex = 0;
            // 
            // colTenHang
            // 
            colTenHang.HeaderText = "Tên hàng";
            colTenHang.MinimumWidth = 10;
            colTenHang.Name = "colTenHang";
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 10;
            colSoLuong.Name = "colSoLuong";
            // 
            // colTrongLuong
            // 
            colTrongLuong.HeaderText = "Trọng lượng (kg)";
            colTrongLuong.MinimumWidth = 10;
            colTrongLuong.Name = "colTrongLuong";
            // 
            // colDonGia
            // 
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 10;
            colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 10;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // stsMain
            // 
            stsMain.ImageScalingSize = new Size(32, 32);
            stsMain.Items.AddRange(new ToolStripItem[] { tslThoiGian, tslTongSoLuong, tslTongTrongLuong, tslTongTien });
            stsMain.Location = new Point(0, 487);
            stsMain.Name = "stsMain";
            stsMain.Size = new Size(1274, 42);
            stsMain.TabIndex = 1;
            stsMain.Text = "statusStrip1";
            // 
            // tslThoiGian
            // 
            tslThoiGian.Name = "tslThoiGian";
            tslThoiGian.Size = new Size(114, 32);
            tslThoiGian.Text = "Thời gian";
            // 
            // tslTongSoLuong
            // 
            tslTongSoLuong.Name = "tslTongSoLuong";
            tslTongSoLuong.Size = new Size(194, 32);
            tslTongSoLuong.Text = "Tổng số lượng: 0";
            // 
            // tslTongTrongLuong
            // 
            tslTongTrongLuong.Name = "tslTongTrongLuong";
            tslTongTrongLuong.Size = new Size(261, 32);
            tslTongTrongLuong.Text = "Tổng trọng lượng: 0 kg";
            // 
            // tslTongTien
            // 
            tslTongTien.Name = "tslTongTien";
            tslTongTien.Size = new Size(163, 32);
            tslTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // tmrDongHo
            // 
            tmrDongHo.Interval = 1000;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 529);
            Controls.Add(stsMain);
            Controls.Add(splMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery Order Dashboard";
            Load += Form1_Load;
            splMain.Panel1.ResumeLayout(false);
            splMain.Panel1.PerformLayout();
            splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splMain).EndInit();
            splMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            stsMain.ResumeLayout(false);
            stsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splMain;
        private ComboBox cboLoaiVC;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvHangHoa;
        private StatusStrip stsMain;
        private ToolStripStatusLabel tslThoiGian;
        private ToolStripStatusLabel tslTongSoLuong;
        private ToolStripStatusLabel tslTongTrongLuong;
        private ToolStripStatusLabel tslTongTien;
        private System.Windows.Forms.Timer tmrDongHo;
        private DataGridViewTextBoxColumn colTenHang;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colTrongLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private ErrorProvider errorProvider1;
    }
}
