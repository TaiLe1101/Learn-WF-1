namespace Bai2
{
    public class SinhVien
    {
        public int MSV { get; set; }
        public string TenSinhVien { get; set; }
        public int MaLop { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }


        public HocLuc TinhLoaiSinhVien()
        {
            double diemTB = TinhDiemTB();
            if (diemTB >= 8 && diemTB <= 10)
            {
                return HocLuc.GIOI;
            }
            else if (diemTB > 6.5)
            {
                return HocLuc.KHA;
            }
            else if (diemTB >= 5)
            {
                return HocLuc.TRUNG_BINH;
            }
            else
            {
                return HocLuc.YEU;
            }
        }

        public double TinhDiemTB()
        {
            return (DiemToan + DiemLy + DiemHoa) / 3;
        }

        public void test()
        {
            HocLuc a = TinhLoaiSinhVien();

            switch (a)
            {
                case HocLuc.GIOI:
                    break;
                case HocLuc.KHA:
                    break;
                case HocLuc.TRUNG_BINH:
                    break;
                case HocLuc.YEU:
                    break;
                default:
                    break;
            }
        }
    }
}

public enum HocLuc
{
    GIOI,
    KHA,
    TRUNG_BINH,
    YEU
}
