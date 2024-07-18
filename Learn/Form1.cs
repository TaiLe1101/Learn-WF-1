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
    public partial class Form1 : Form
    {
        public static BindingSource bindingSourceSinhVien;
        public Form1()
        {
            InitializeComponent();
            bindingSourceSinhVien = new BindingSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboLop.DataSource = MockData.GetLopHocs();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            bindingSourceSinhVien.DataSource = MockData.GetSinhViens();
            dgvSinhViens.DataSource = bindingSourceSinhVien;
        }



        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.Focused)
            {
                int maLop = (int)cboLop.SelectedValue;
                List<SinhVien> filterSinhViens = new List<SinhVien>();

                foreach (var sinhVien in MockData.GetSinhViens())
                {
                    if (sinhVien.MaLop == maLop)
                    {
                        filterSinhViens.Add(sinhVien);
                    }
                }

                bindingSourceSinhVien.DataSource = filterSinhViens;
            }
        }

        private void btnLuaChon_Click(object sender, EventArgs e)
        {
            int luaChon = int.Parse(txtLuaChon.Text);
            if (luaChon == 1)
            {
                FrmAddSinhVien frmAddSinhVien = new FrmAddSinhVien();
                frmAddSinhVien.ShowDialog();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            int maLop = (int)cboLop.SelectedValue;
            List<SinhVien> filterSinhViens = new List<SinhVien>();

            foreach (var sinhVien in MockData.GetSinhViens())
            {
                if (sinhVien.MaLop == maLop)
                {
                    filterSinhViens.Add(sinhVien);
                }
            }

            bindingSourceSinhVien.DataSource = filterSinhViens;
        }
    }
}
