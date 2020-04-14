using System;

namespace Buoi2
{
    public class PhanSo
    {
        int tuSo;
        int mauSo;

        public PhanSo() { 
            tuSo = 0;
            mauSo = 1;
        }

        public PhanSo(int soNguyen) {
            tuSo = soNguyen;
            mauSo = 1;
        }

        public PhanSo(int tuSoArg, int mauSoArg) {
            tuSo = tuSoArg;
            mauSo = mauSoArg;
        }

        // Cong hai phan so: a / b + c / d = (a*d+b*c) / (b*d)
        public static PhanSo operator + (PhanSo a, PhanSo b) {
            int tuSoMoi = a.tuSo * b.mauSo +  a.mauSo * b.tuSo;
            int mauSoMoi = a.mauSo * b.mauSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }

        // Tru hai phan so: a / b - c / d = (a*d-b*c) / (b*d)
        public static PhanSo operator - (PhanSo a, PhanSo b) {
            int tuSoMoi = a.tuSo * b.mauSo -  a.mauSo * b.tuSo;
            int mauSoMoi = a.mauSo * b.mauSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }

        // Nhan hai phan so: a / b * c / d = (a*c) / (b*d)
        public static PhanSo operator * (PhanSo a, PhanSo b) {
            int tuSoMoi = a.tuSo * b.tuSo;
            int mauSoMoi = a.mauSo * b.mauSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }

        // Chia hai phan so: a / b * c / d = (a*d) / (b*c)
        public static PhanSo operator / (PhanSo a, PhanSo b) {
            int tuSoMoi = a.tuSo * b.mauSo;
            int mauSoMoi = a.mauSo * b.tuSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }

        // So sanh lon hon a / b va c / d => a / b - c / d > 0 <=> (a*d - b*c)/(b*d) > 0
        public static bool operator > (PhanSo a, PhanSo b) {
            PhanSo kq = a - b;
            return kq.tuSo > 0;
        }

        // So sanh nho hon a / b va c / d => a / b - c / d < 0
        public static bool operator < (PhanSo a, PhanSo b) {
            PhanSo kq = a - b;
            return kq.tuSo < 0;
        }

        // So sanh lon hon hoac bang a / b va c / d => a / b - c / d >= 0 <=> (a*d - b*c)/(b*d) >= 0
        public static bool operator >= (PhanSo a, PhanSo b) {
            return !(a<b);
        }

        // So sanh lon hon hoac bang a / b va c / d => a / b - c / d >= 0 <=> (a*d - b*c)/(b*d) >= 0
        public static bool operator <= (PhanSo a, PhanSo b) {
            return !(a>b);
        }

        // So sanh bang a / b va c / d => a / b - c / d = 0
        public static bool operator == (PhanSo a, PhanSo b) {
            PhanSo kq = a - b;
            return kq.tuSo == 0;
        }

        // So sanh khac a / b va c / d => a / b - c / d != 0
        public static bool operator != (PhanSo a, PhanSo b) {
            return !(a==b);
        }

        public void prettyPrint() {
            Console.WriteLine("Gia tri la: " + tuSo + " / " + mauSo);
        }
    }
}
