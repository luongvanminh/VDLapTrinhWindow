using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vui long nhap bac cua da thuc: ");
            int n = int.Parse(Console.ReadLine());
            DaThuc mDathuc = new DaThuc(n);
            mDathuc.KhoiTaoDaThuc();
            mDathuc.prettyPrint();

            Console.Write("Vui long nhap gia tri cua x: ");
            mDathuc.x = double.Parse(Console.ReadLine());

            Console.WriteLine("Gia tri da thuc tai x = " + mDathuc.x + " la: " +mDathuc.GiaTriCuaDaThuc());
            // f(x) = 3.6 + 2.7 * x^1 + 4.1 * x^2 + 8.9 * x^3 + 0.3 * x^4
            // tinh gia tri tai x = 1.5
        }
    }
}
