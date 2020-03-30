using System;

namespace VDDieuKhien
{
    class Program
    {
        static void Main(string[] args)
        {
            var x=5;
            var y=6;
            
            var z=9;
            var r =x<y?y<z?(x,y,z):x<z?(x,z,y):(z,x,y):x<z?(y,x,z):y<z?(y,z,x):(z,y,x);

            Console.WriteLine("r: " + r);
        }
    }
}
