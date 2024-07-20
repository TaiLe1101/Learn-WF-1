using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class FrmThemSinhVien : Form
    {
        public FrmThemSinhVien()
        {
            InitializeComponent();
        }

        private void FrmThemSinhVien_Load(object sender, EventArgs e)
        {
            TaiDanhSachLop();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Giả sử dữ đã ngon lành

            SinhVien sinhVienMoi = new SinhVien()
            {
                MSV = int.Parse(txtMSV.Text),
                TenSinhVien = txtTenSV.Text,
                DiemHoa = double.Parse(txtDiemHoa.Text),
                DiemLy = double.Parse(txtDiemLy.Text),
                DiemToan = double.Parse(txtDiemToan.Text),
                MaLop = (int)cboLop.SelectedValue,
            };

            bool isAddSuccess = QLSV.ThemSinhVien(sinhVienMoi);
            if (isAddSuccess)
            {
                MessageBox.Show("Tạo sinh viên thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Tạo sinh viên thất bại");
            }

        }

        private void TaiDanhSachLop()
        {
            cboLop.DataSource = QLSV.LayDanhSachLopHoc();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }


    }
}
