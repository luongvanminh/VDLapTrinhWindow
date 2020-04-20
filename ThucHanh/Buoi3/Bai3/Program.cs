using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vui long nhap so luong phan tu cua day phan so: ");
            int n = int.Parse(Console.ReadLine());
            DayPhanSo mDayPhanSo = new DayPhanSo(n);
            mDayPhanSo.KhoiTaoDayPhanSo();
            mDayPhanSo.prettyPrint();
            Console.Write("Tong cua day so nay la: " );
            mDayPhanSo.TongDayPhanSo().prettyPrint();
            Console.WriteLine();
        }
    }
}
