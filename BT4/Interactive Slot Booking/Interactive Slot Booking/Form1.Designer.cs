namespace Interactive_Slot_Booking
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
            pnlSoDo = new FlowLayoutPanel();
            lblKhungGio = new Label();
            lblSoViTri = new Label();
            lblTamTinh = new Label();
            cboKhungGio = new ComboBox();
            btnXacNhan = new Button();
            btnHuyChon = new Button();
            SuspendLayout();
            // 
            // pnlSoDo
            // 
            pnlSoDo.BorderStyle = BorderStyle.FixedSingle;
            pnlSoDo.Location = new Point(29, 32);
            pnlSoDo.Name = "pnlSoDo";
            pnlSoDo.Size = new Size(400, 282);
            pnlSoDo.TabIndex = 0;
            // 
            // lblKhungGio
            // 
            lblKhungGio.AutoSize = true;
            lblKhungGio.Location = new Point(465, 32);
            lblKhungGio.Name = "lblKhungGio";
            lblKhungGio.Size = new Size(130, 32);
            lblKhungGio.TabIndex = 1;
            lblKhungGio.Text = "Khung giờ:";
            // 
            // lblSoViTri
            // 
            lblSoViTri.AutoSize = true;
            lblSoViTri.Location = new Point(465, 126);
            lblSoViTri.Name = "lblSoViTri";
            lblSoViTri.Size = new Size(241, 32);
            lblSoViTri.TabIndex = 2;
            lblSoViTri.Text = "Số vị trí đang chọn: 0";
            lblSoViTri.Click += label2_Click;
            // 
            // lblTamTinh
            // 
            lblTamTinh.AutoSize = true;
            lblTamTinh.Location = new Point(465, 168);
            lblTamTinh.Name = "lblTamTinh";
            lblTamTinh.Size = new Size(203, 32);
            lblTamTinh.TabIndex = 3;
            lblTamTinh.Text = "Tạm tính tiền: 0 đ";
            // 
            // cboKhungGio
            // 
            cboKhungGio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhungGio.FormattingEnabled = true;
            cboKhungGio.Location = new Point(465, 67);
            cboKhungGio.Name = "cboKhungGio";
            cboKhungGio.Size = new Size(242, 40);
            cboKhungGio.TabIndex = 4;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(465, 216);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(150, 46);
            btnXacNhan.TabIndex = 5;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnHuyChon
            // 
            btnHuyChon.Location = new Point(465, 268);
            btnHuyChon.Name = "btnHuyChon";
            btnHuyChon.Size = new Size(203, 46);
            btnHuyChon.TabIndex = 6;
            btnHuyChon.Text = "Hủy chọn tất cả";
            btnHuyChon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 349);
            Controls.Add(btnHuyChon);
            Controls.Add(btnXacNhan);
            Controls.Add(cboKhungGio);
            Controls.Add(lblTamTinh);
            Controls.Add(lblSoViTri);
            Controls.Add(lblKhungGio);
            Controls.Add(pnlSoDo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interactive Slot Booking";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel pnlSoDo;
        private Label lblKhungGio;
        private Label lblSoViTri;
        private Label lblTamTinh;
        private ComboBox cboKhungGio;
        private Button btnXacNhan;
        private Button btnHuyChon;
    }
}
