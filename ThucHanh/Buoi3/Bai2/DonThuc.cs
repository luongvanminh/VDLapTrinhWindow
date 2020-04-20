using System;

namespace Bai2
{
    public class DonThuc
    {
        // f(x) = a * x ^ n
        public double heSoA;
        public int soMuN;

        public DonThuc() {
            heSoA = 1;
            soMuN = 0;
        }

        public DonThuc(double paramHeSoA, int paramSoMuN) {
            this.heSoA = paramHeSoA;
            this.soMuN = paramSoMuN;
        }
    }
}
