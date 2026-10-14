namespace Interactive_Slot_Booking
{
    public partial class Form1 : Form
    {
        // Trạng thái của mỗi vị trí (lưu trong Tag của Button)
        private const int TRONG = 0;
        private const int DANG_CHON = 1;
        private const int DA_DAT = 2;

        // Màu theo trạng thái
        private readonly Color mauTrong = Color.WhiteSmoke;
        private readonly Color mauDangChon = Color.LimeGreen;
        private readonly Color mauDaDat = Color.IndianRed;

        public Form1()
        {
            InitializeComponent();

            // Đổi khung giờ thì tính lại tiền (gắn bằng code, không nhấp đúp ComboBox)
            cboKhungGio.SelectedIndexChanged += cboKhungGio_SelectedIndexChanged;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khung giờ
            cboKhungGio.Items.Add("Sáng - 100.000đ");
            cboKhungGio.Items.Add("Tối - 150.000đ");
            cboKhungGio.SelectedIndex = 0;

            // Dùng vòng lặp for tạo 20 nút (4 hàng x 5 cột)
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Text = (char)('A' + i / 5) + ((i % 5) + 1).ToString();   // A1..A5, B1..B5, ...
                btn.Size = new Size(80, 60);
                btn.Margin = new Padding(5);
                btn.FlatStyle = FlatStyle.Flat;
                btn.UseVisualStyleBackColor = false;
                btn.BackColor = mauTrong;
                btn.Tag = TRONG;

                // Gán CHUNG 1 hàm Click cho cả 20 nút
                btn.Click += ViTri_Click;

                pnlSoDo.Controls.Add(btn);
            }

            // Khóa sẵn một số vị trí (đã có người đặt): A3, B3, C4, D4
            int[] viTriDaDat = { 2, 7, 13, 18 };
            foreach (int i in viTriDaDat)
            {
                Button btn = (Button)pnlSoDo.Controls[i];
                btn.Tag = DA_DAT;
                btn.BackColor = mauDaDat;
            }

            CapNhatThongKe();
        }

        // Hàm Click dùng chung cho 20 nút vị trí
        private void ViTri_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int trangThai = (int)btn.Tag;

            if (trangThai == DA_DAT)
            {
                MessageBox.Show("Vị trí " + btn.Text + " đã có người đặt!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trangThai == TRONG)
            {
                btn.Tag = DANG_CHON;
                btn.BackColor = mauDangChon;
            }
            else
            {
                btn.Tag = TRONG;
                btn.BackColor = mauTrong;
            }

            CapNhatThongKe();
        }

        // Cập nhật số vị trí và tạm tính tiền (realtime)
        private void CapNhatThongKe()
        {
            int soLuong = 0;
            foreach (Button btn in pnlSoDo.Controls)
            {
                if ((int)btn.Tag == DANG_CHON) soLuong++;
            }

            int giaMotViTri = cboKhungGio.SelectedIndex == 1 ? 150000 : 100000;
            int tamTinh = soLuong * giaMotViTri;

            lblSoViTri.Text = "Số vị trí đang chọn: " + soLuong;
            lblTamTinh.Text = "Tạm tính tiền: " +
                tamTinh.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " đ";
        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKe();
        }
    }
}