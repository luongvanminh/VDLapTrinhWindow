using System;

namespace Bai3
{
    public class DayPhanSo
    {
        PhanSo[] arrPhanSo;
        public int soLuongPhanTu;

        public DayPhanSo() {
            arrPhanSo = new PhanSo[0];
        }

        public DayPhanSo(int soLuongPhanTu) {
            arrPhanSo = new PhanSo[soLuongPhanTu];
            this.soLuongPhanTu = soLuongPhanTu;
        }

        // operator []
        public PhanSo this[int i] {
            get { return arrPhanSo[i]; }
            set { arrPhanSo[i] = value; }
        }

        public void KhoiTaoDayPhanSo() {
            Console.WriteLine("Vui long nhap day phan so");
            for (int i = 0; i < this.soLuongPhanTu; i++) {
                // PhanSo mPhanSo = this[i];
                Console.Write("Vui long nhap tu so cua phan so thu " + i + ":");
                int tuSoMoi = int.Parse(Console.ReadLine());
                Console.Write("Vui long nhap mau so cua phan so thu " + i + ":");
                int mauSoMoi = int.Parse(Console.ReadLine());
                this[i] = new PhanSo(tuSoMoi, mauSoMoi);
            }
        }

        public void prettyPrint() {
            Console.Write("Day so la: ");
            for (int i = 0; i < this.soLuongPhanTu; i++) {
                this[i].prettyPrint();
                if (i != this.soLuongPhanTu-1)
                    Console.Write(", ");     
            }
            Console.WriteLine();
        }

        public PhanSo TongDayPhanSo() {
            PhanSo kq = new PhanSo();
            for (int i = 0; i < this.soLuongPhanTu; i++) {
                kq = kq + this[i];
            }

            return PhanSo.Reduce(kq);
        }
    }
}
