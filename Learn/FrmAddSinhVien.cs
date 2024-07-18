using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class FrmAddSinhVien : Form
    {
        public FrmAddSinhVien()
        {
            InitializeComponent();
        }

        private void FrmAddSinhVien_Load(object sender, EventArgs e)
        {
            cboLop.DataSource = MockData.GetLopHocs();
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maSV = int.Parse(txtMSV.Text);
            // Kiểm tra trùng lặp mã sinh viên trong danh sách sinh viên
            foreach (var sinhVien in MockData.GetSinhViens())
            {
                if (sinhVien.MSV == maSV)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!, vui lòng thử lại");
                    txtMSV.Focus();
                    return;
                }
            }

            string tenSV = txtTenSV.Text;
            int maLop = (int)cboLop.SelectedValue;
            double diemToan = double.Parse(txtDiemToan.Text);
            double diemLy = double.Parse(txtDiemLy.Text);
            double diemHoa = double.Parse(txtDiemHoa.Text);

            SinhVien createSinhVien = new SinhVien()
            {
                MSV = maSV,
                MaLop = maLop,
                DiemHoa = diemHoa,
                DiemLy = diemLy,
                DiemToan = diemToan,
                TenSinhVien = tenSV
            };

            bool isCreatedSuccess = MockData.AddSinhVien(createSinhVien);
            if (isCreatedSuccess)
            {
                Form1.bindingSourceSinhVien.DataSource = MockData.GetSinhViens();
                this.Dispose();
            }
        }
    }
}
