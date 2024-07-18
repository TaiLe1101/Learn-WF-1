using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public static class MockData
    {
        private static List<SinhVien> sinhViens = new List<SinhVien>
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
        private static List<LopHoc> lopHocs;
        public static List<SinhVien> GetSinhViens()
        {

            return sinhViens;
        }

        public static List<LopHoc> GetLopHocs()
        {
            lopHocs = new List<LopHoc> { new LopHoc() { TenLop = "Lop VIP", MaLop = 1 }, new LopHoc() { TenLop = "Lop Cui Bap", MaLop = 2 } };
            return lopHocs;
        }


        public static bool AddSinhVien(SinhVien sv)
        {
            sinhViens.Add(sv);
            return true;
        }
    }
}
