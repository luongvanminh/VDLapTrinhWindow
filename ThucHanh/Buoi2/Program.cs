using System;

namespace Buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap gia tri phan so a tu nguoi dung
            Console.WriteLine("Nhap tu so cua a:");
            int tuSoCuaA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mau so cua a:");
            int mauSoCuaA = Convert.ToInt32(Console.ReadLine());
            PhanSo phanSoA = new PhanSo(tuSoCuaA, mauSoCuaA);

            // Nhap gia tri phan so b tu nguoi dung
            Console.WriteLine("Nhap tu so cua b:");
            int tuSoCuaB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mau so cua b:");
            int mauSoCuaB = Convert.ToInt32(Console.ReadLine());
            PhanSo phanSoB = new PhanSo(tuSoCuaB, mauSoCuaB);

            PhanSo kq = phanSoA - phanSoB;

            kq = PhanSo.Reduce(kq);
            kq.prettyPrint();

            if (phanSoA >= phanSoB) {
                Console.WriteLine("Phan so A lon hon hoac bang phan so b");
            }

            if (phanSoA < phanSoB) {
                Console.WriteLine("Phan so A nho hon phan so b");
            }
        }
    }
}
