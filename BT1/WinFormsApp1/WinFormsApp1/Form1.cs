namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ. Vui lòng nhập số!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                txtDonGia.SelectAll();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng khách không hợp lệ. Vui lòng nhập số nguyên dương!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                txtSoLuong.SelectAll();
                return;
            }

            if (!decimal.TryParse(txtGiamGia.Text.Trim(), out decimal giam) || giam < 0 || giam > 100)
            {
                MessageBox.Show("% giảm không hợp lệ. Vui lòng nhập số từ 0 đến 100!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamGia.Focus();
                txtGiamGia.SelectAll();
                return;
            }

            // Tổng tiền = (Đơn giá × Số lượng) × (100 - %Giảm) / 100
            decimal tong = (donGia * soLuong) * (100 - giam) / 100;
            lblTongTien.Text = "Tổng tiền thanh toán: " + tong.ToString("N0") + " VNĐ";
        }
        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "Tổng tiền thanh toán: 0 VNĐ";
            txtDonGia.Focus();
        }
    }
}
