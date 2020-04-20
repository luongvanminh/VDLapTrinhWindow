using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mang1Chieu mMang = new Mang1Chieu(3);

            for (int i = 0; i<mMang.length; i++) {
                Console.WriteLine("Nhap gia tri phan tu thu " + i + " :");
                mMang[i] = int.Parse(Console.ReadLine());
            }

            mMang.prettyPrint();
            Console.Write("Cac so chan cua day la: ");
            mMang.printEven();
        }
    }
}
