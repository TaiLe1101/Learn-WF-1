using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public static class QLSV
    {
        private static List<SinhVien> sinhViens = new List<SinhVien>()
        {
            new SinhVien()
            {
                MSV = 1,
                TenSinhVien = "Nguyen Van A",
                MaLop = 1,
                DiemHoa = 7,
                DiemLy = 8,
                DiemToan = 9,
            },
            new SinhVien()
            {
                MSV = 2,
                TenSinhVien = "Nguyen Van B",
                MaLop = 1,
                DiemHoa = 9,
                DiemLy = 7,
                DiemToan = 2,
            }
        };
        private static List<LopHoc> lopHocs = new List<LopHoc>() { new LopHoc() { TenLop = "Lop VIP", MaLop = 1 }, new LopHoc() { TenLop = "Lop Cui Bap", MaLop = 2 } };

        public static List<SinhVien> LayDanhSachSinhVien()
        {
            return sinhViens;
        }

        public static List<LopHoc> LayDanhSachLopHoc()
        {
            return lopHocs;
        }

        public static bool ThemSinhVien(SinhVien sinhVienMoi)
        {
            sinhViens.Add(sinhVienMoi);
            return true;
        }

        public static bool XoaSinhVienTheoMaSinhVien(int maSinhVien)
        {
            foreach (SinhVien sinhVien in sinhViens)
            {
                if (sinhVien.MSV == maSinhVien)
                {
                    sinhViens.Remove(sinhVien);
                    return true;
                }
            }
            return false;
        }

        public static bool ChinhSuaThongTinSinhVienTheoMaSinhVien(int maSinhVien, SinhVien thongTinSinhVienMoi)
        {
            foreach (SinhVien sinhVienTrongDanhSach in sinhViens)
            {
                if (sinhVienTrongDanhSach.MSV == maSinhVien)
                {
                    sinhVienTrongDanhSach.TenSinhVien = thongTinSinhVienMoi.TenSinhVien;
                    sinhVienTrongDanhSach.DiemToan = thongTinSinhVienMoi.DiemToan;
                    sinhVienTrongDanhSach.DiemLy = thongTinSinhVienMoi.DiemLy;
                    sinhVienTrongDanhSach.DiemHoa = thongTinSinhVienMoi.DiemHoa;
                    return true;
                }
            }

            return false;
        }

    }
}
