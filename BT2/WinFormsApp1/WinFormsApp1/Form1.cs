namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;
            rdoThap.Checked = false;
            rdoTrungBinh.Checked = false;
            rdoKhanCap.Checked = false;
            cboLoaiSuCo.SelectedIndex = -1;
            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;
            picAnhLoi.Image = null;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string thieu = "";

            if (txtMaPhieu.Text.Trim() == "")
                thieu += "- Mã phiếu\n";

            if (txtNguoiYeuCau.Text.Trim() == "")
                thieu += "- Người yêu cầu\n";

            if (!rdoThap.Checked && !rdoTrungBinh.Checked && !rdoKhanCap.Checked)
                thieu += "- Mức độ ưu tiên\n";

            if (cboLoaiSuCo.SelectedIndex == -1)
                thieu += "- Loại sự cố\n";

            if (!chkMayTinhBan.Checked && !chkLaptop.Checked && !chkMayIn.Checked && !chkDienThoai.Checked)
                thieu += "- Thiết bị ảnh hưởng\n";

            if (picAnhLoi.Image == null)
                thieu += "- Ảnh chụp lỗi\n";

            if (thieu != "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin:\n" + thieu,
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string uuTien = "";
            if (rdoThap.Checked) uuTien = "Thấp";
            else if (rdoTrungBinh.Checked) uuTien = "Trung bình";
            else if (rdoKhanCap.Checked) uuTien = "Khẩn cấp";

            string thietBi = "";
            if (chkMayTinhBan.Checked) thietBi += chkMayTinhBan.Text + ", ";
            if (chkLaptop.Checked) thietBi += chkLaptop.Text + ", ";
            if (chkMayIn.Checked) thietBi += chkMayIn.Text + ", ";
            if (chkDienThoai.Checked) thietBi += chkDienThoai.Text + ", ";
            thietBi = thietBi.TrimEnd(',', ' ');

            string anh = picAnhLoi.Image != null ? "Đã đính kèm" : "Không có";

            string tomTat =
                "Mã phiếu: " + txtMaPhieu.Text + "\n" +
                "Người yêu cầu: " + txtNguoiYeuCau.Text + "\n" +
                "Ngày ghi nhận: " + dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy") + "\n" +
                "Mức độ ưu tiên: " + uuTien + "\n" +
                "Loại sự cố: " + cboLoaiSuCo.Text + "\n" +
                "Thiết bị ảnh hưởng: " + thietBi + "\n" +
                "Ảnh chụp lỗi: " + anh;

            MessageBox.Show(tomTat, "Tóm tắt yêu cầu");
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnhLoi.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
