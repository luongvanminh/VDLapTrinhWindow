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

        // So sanh nho hon hoac bang a / b va c / d => a / b - c / d <= 0 <=> (a*d - b*c)/(b*d) <= 0
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

        public override bool Equals(object o) {
            if(o == null)
                return false;

            var second = o as PhanSo;

            return second != null && tuSo == second.tuSo && mauSo == second.mauSo;
        }

        public override int GetHashCode() {
            return Tuple.Create(tuSo, mauSo).GetHashCode();;
        }

        public void prettyPrint() {
            Console.WriteLine("Gia tri la: " + tuSo + " / " + mauSo);
        }

        public static PhanSo Parse(string phanSo) {
            if (phanSo == null) throw new FormatException();

            string[] split = phanSo.Split( '/' );
            int len = split.Length;

            if ( len == 2 )
            {
                int s0 = int.Parse( split[0] );
                int s1 = int.Parse( split[1] );
                return new PhanSo( s0, s1 );
            }
            else if ( len == 4 )
            {
                int s0 = int.Parse( split[0] );
                int s1 = int.Parse( split[1] );
                PhanSo f1 = new PhanSo( s0, s1 );

                int s2 = int.Parse( split[2] );
                int s3 = int.Parse( split[3] );
                PhanSo f2 = new PhanSo( s2, s3 );

                return f1 / f2;
            }
            else
                throw new FormatException();
        }

        static int gcd(int a, int b)
        {
            while (a != b)
                if (a < b) b = b - a;
                else a = a - b;

            return (a);
        }

        static int division(int a, int b)
            {
            int remainder=a, quotient=0;
            while (remainder >= b)
            {
                remainder = remainder - b;
                quotient++;
            }
            return (quotient);            
        }

        public static PhanSo Reduce(PhanSo phanSo) {
            int divisor, numerator, denominator, reducedNumerator, reducedDenominator;
            numerator = phanSo.tuSo;
            denominator = phanSo.mauSo;
            
            divisor = gcd(numerator, denominator);
            
            if (divisor!=1)
            {
                reducedNumerator = division(numerator, divisor);
                reducedDenominator = division(denominator, divisor);
                return new PhanSo(reducedNumerator, reducedDenominator);
            }
            else
                return phanSo;
        }

    }

    
}
