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
    public partial class Form1 : Form
    {
        private static BindingSource bindingSource;


        public Form1()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaiDanhSachSinhVien();
            TaiDanhSachLop();
        }

        private void TaiDanhSachSinhVien()
        {
            bindingSource.DataSource = QLSV.LayDanhSachSinhVien();
            dgvDanhSachSinhVien.DataSource = bindingSource;
        }

        private void TaiDanhSachLop()
        {
            cboLopHoc.DataSource = QLSV.LayDanhSachLopHoc();
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "MaLop";
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopHoc.Focused)
            {
                int maLopDuocChon = (int)cboLopHoc.SelectedValue;
                List<SinhVien> danhSachSinhVienTheoLop = new List<SinhVien>();
                foreach (SinhVien sinhVien in QLSV.LayDanhSachSinhVien())
                {
                    if (sinhVien.MaLop == maLopDuocChon)
                    {
                        danhSachSinhVienTheoLop.Add(sinhVien);
                    }
                }

                bindingSource.DataSource = danhSachSinhVienTheoLop;
            }
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            FrmThemSinhVien frmThemSinhVien = new FrmThemSinhVien();
            frmThemSinhVien.ShowDialog();
        }



        private void Form1_Activated(object sender, EventArgs e)
        {
            int maLopDuocChon = (int)cboLopHoc.SelectedValue;
            List<SinhVien> danhSachSinhVienTheoLop = new List<SinhVien>();
            foreach (SinhVien sinhVien in QLSV.LayDanhSachSinhVien())
            {
                if (sinhVien.MaLop == maLopDuocChon)
                {
                    danhSachSinhVienTheoLop.Add(sinhVien);
                }
            }

            bindingSource.DataSource = danhSachSinhVienTheoLop;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int columnIndex = 0;
            int rowIndex = dgvDanhSachSinhVien.SelectedRows[0].Index;

            int maSinhVien = (int)dgvDanhSachSinhVien.Rows[rowIndex].Cells[columnIndex].Value;

            bool isDeleted = QLSV.XoaSinhVienTheoMaSinhVien(maSinhVien);
            if (isDeleted)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
