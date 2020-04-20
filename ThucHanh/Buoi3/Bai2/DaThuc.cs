using System;

namespace Bai2
{
    public class DaThuc
    {
        // f(x) = a0 * x^0 + a1 * x^1 + a2 * x^2 + ... + an * x^n
        private DonThuc[] mangDonThuc;
        private int soLuongDonThuc = 1;

        public double x = 0;

        public DaThuc() {
            mangDonThuc = new DonThuc[1];
            mangDonThuc[0] = new DonThuc();
        }

        public DaThuc(int soLuongDonThuc) {
            mangDonThuc = new DonThuc[soLuongDonThuc];
            this.soLuongDonThuc = soLuongDonThuc;

            // Khoi tao cac don thuc trong da thuc
            for (int i = 0; i < this.soLuongDonThuc; i++) {
                this[i] = new DonThuc(1, i);
            }
        }

        // operator []
        public DonThuc this[int i] {
            get { return mangDonThuc[i]; }
            set { mangDonThuc[i] = value; }
        }

        public void KhoiTaoDaThuc() {
            for (int i = 0; i < this.soLuongDonThuc; i++) {
                DonThuc mDonThuc = this[i];
                mDonThuc.soMuN = i;
                Console.Write("Vui long nhap he so a tai don thuc thu " + i + " :");
                mDonThuc.heSoA = double.Parse(Console.ReadLine());
            }
        }

        public void prettyPrint() {
            Console.WriteLine("In da thuc:");
            for (int i=0; i< this.soLuongDonThuc; i++) {
                DonThuc mDonThuc = this[i];
                Console.Write(mDonThuc.heSoA + "*" + "x^" + mDonThuc.soMuN);
                if (i != this.soLuongDonThuc - 1) {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }

        public double GiaTriCuaDaThuc() {
            double kq = 0;
            for (int i = 0; i < this.soLuongDonThuc; i++) {
                kq += this[i].heSoA * Math.Pow(this.x, this[i].soMuN);
            }
            return kq;
        }

        public double GiaTriCuaDaThuc(double x) {
            double kq = 0;
            for (int i = 0; i < this.soLuongDonThuc; i++) {
                kq += this[i].heSoA * Math.Pow(x, this[i].soMuN);
            }
            return kq;
        }
    }
}
