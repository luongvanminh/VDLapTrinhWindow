using System;

namespace ExampleTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Nhap vao bien a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap vao bien b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                double c = a / b;
                Console.WriteLine("Gia tri cua a / b la: " + c);
            } catch (Exception e) {
                Console.WriteLine("Co xay ra ngoai le la: " + e.ToString());
                
            }


        }
    }
}
