namespace Item_List_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        // Kiểm tra dữ liệu nhập, dùng chung cho Thêm mới và Cập nhật
        private bool DuLieuHopLe()
        {
            if (txtMaVT.Text.Trim() == "" || txtTenVT.Text.Trim() == "" || cboDonViTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã, Tên và Đơn vị tính!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal gia) || gia < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                txtDonGia.SelectAll();
                return false;
            }
            return true;
        }

        // Chọn 1 dòng trong ListView: đẩy dữ liệu ngược lên các ô bên trái
        private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0) return;

            ListViewItem it = lvVatTu.SelectedItems[0];
            txtMaVT.Text = it.SubItems[0].Text;
            txtTenVT.Text = it.SubItems[1].Text;
            cboDonViTinh.Text = it.SubItems[2].Text;
            txtDonGia.Text = it.SubItems[3].Text;
        }

        // Nút Thêm mới
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (!DuLieuHopLe()) return;

            string ma = txtMaVT.Text.Trim();

            // Không cho thêm nếu Mã VT đã tồn tại
            foreach (ListViewItem it in lvVatTu.Items)
            {
                if (it.SubItems[0].Text.Equals(ma, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã VT đã tồn tại trong danh sách!", "Trùng mã",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaVT.Focus();
                    txtMaVT.SelectAll();
                    return;
                }
            }

            ListViewItem item = new ListViewItem(ma);
            item.SubItems.Add(txtTenVT.Text.Trim());
            item.SubItems.Add(cboDonViTinh.Text);
            item.SubItems.Add(txtDonGia.Text.Trim());
            lvVatTu.Items.Add(item);
        }

        // Nút Cập nhật
        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng cần cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!DuLieuHopLe()) return;

            ListViewItem dong = lvVatTu.SelectedItems[0];
            string ma = txtMaVT.Text.Trim();

            // Nếu đổi Mã VT thì không được trùng với dòng khác
            foreach (ListViewItem it in lvVatTu.Items)
            {
                if (it != dong && it.SubItems[0].Text.Equals(ma, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã VT đã tồn tại trong danh sách!", "Trùng mã",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            dong.SubItems[0].Text = ma;
            dong.SubItems[1].Text = txtTenVT.Text.Trim();
            dong.SubItems[2].Text = cboDonViTinh.Text;
            dong.SubItems[3].Text = txtDonGia.Text.Trim();
        }

        // Nút Xóa dòng (có hỏi Yes/No)
        private void btnXoaDong_Click_1(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvVatTu.Items.Remove(lvVatTu.SelectedItems[0]);
            }
        }

        // Nút Xóa toàn bộ
        private void btnXoaTatCa_Click_1(object sender, EventArgs e)
        {
            lvVatTu.Items.Clear();
        }
    }
}