namespace Delivery_Order_Dashboard
{
    public partial class Form1 : Form
    {
        // Thứ tự cột: 0 Tên hàng, 1 Số lượng, 2 Trọng lượng, 3 Đơn giá, 4 Thành tiền
        const int cTen = 0, cSL = 1, cTL = 2, cGia = 3, cTien = 4;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            tmrDongHo.Tick += tmrDongHo_Tick;

            dgvHangHoa.CellValueChanged += dgvHangHoa_CellValueChanged;
            dgvHangHoa.CellValidating += dgvHangHoa_CellValidating;
            dgvHangHoa.RowsRemoved += (s, e) => TinhTong();
            dgvHangHoa.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvHangHoa.IsCurrentCellDirty)
                    dgvHangHoa.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            cboLoaiVC.Items.Add("Tiêu chuẩn");
            cboLoaiVC.Items.Add("Nhanh");
            cboLoaiVC.Items.Add("Hỏa tốc");
            cboLoaiVC.SelectedIndex = 0;

            tslThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmrDongHo.Interval = 1000;
            tmrDongHo.Start();

            dgvHangHoa.Columns[cTien].ReadOnly = true;
            TinhTong();
        }

        private void tmrDongHo_Tick(object? sender, EventArgs e)
        {
            tslThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private static double Num(DataGridViewCell c)
        {
            return double.TryParse(c.Value?.ToString(), out double v) ? v : 0;
        }

        private void dgvHangHoa_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex == cTien) return;

            var row = dgvHangHoa.Rows[e.RowIndex];
            row.Cells[cTien].Value = Num(row.Cells[cSL]) * Num(row.Cells[cGia]);
            TinhTong();
        }

        private void TinhTong()
        {
            double tongSL = 0, tongTL = 0, tongTien = 0;
            foreach (DataGridViewRow r in dgvHangHoa.Rows)
            {
                if (r.IsNewRow) continue;
                double sl = Num(r.Cells[cSL]);
                tongSL += sl;
                tongTL += sl * Num(r.Cells[cTL]);
                tongTien += Num(r.Cells[cTien]);
            }

            // Items[0] = thời gian, [1] = tổng SL, [2] = tổng TL, [3] = tổng tiền
            stsMain.Items[1].Text = $"Tổng số lượng: {tongSL}";
            stsMain.Items[2].Text = $"Tổng trọng lượng: {tongTL} kg";
            stsMain.Items[3].Text = $"Tổng tiền: {tongTien:N0} đ";
        }

        private void dgvHangHoa_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvHangHoa.Rows[e.RowIndex].IsNewRow) return;
            if (e.ColumnIndex != cSL && e.ColumnIndex != cTL) return;

            string ten = e.ColumnIndex == cSL ? "Số lượng" : "Trọng lượng";
            var cell = dgvHangHoa.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (!double.TryParse(e.FormattedValue?.ToString(), out double v) || v <= 0)
            {
                string msg = $"{ten} phải lớn hơn 0";
                cell.ErrorText = msg;
                errorProvider1.SetError(dgvHangHoa, msg);
            }
            else
            {
                cell.ErrorText = "";
                errorProvider1.SetError(dgvHangHoa, "");
            }
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                int i = dgvHangHoa.Rows.Add();
                dgvHangHoa.CurrentCell = dgvHangHoa.Rows[i].Cells[cTen];
                dgvHangHoa.BeginEdit(true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Delete
                     && dgvHangHoa.Focused
                     && !dgvHangHoa.IsCurrentCellInEditMode
                     && dgvHangHoa.CurrentRow != null
                     && !dgvHangHoa.CurrentRow.IsNewRow)
            {
                dgvHangHoa.Rows.Remove(dgvHangHoa.CurrentRow);
                e.Handled = true;
            }
        }
    }
}