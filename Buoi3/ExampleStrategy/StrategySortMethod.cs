using System;

namespace ExampleStrategy
{
    public class StrategySortMethod:BaseStrategy
    {

        public override void command(int [] arr) {
            Console.WriteLine("StrategySortMethod run command");
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++) {
                for (int i = 0; i <= arr.Length - 2; i++) {
                    if (arr[i] > arr[i + 1]) {
                        temp= arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            foreach (int i in arr)
            {
                System.Console.Write("{0} ", i);
            }
            Console.WriteLine("");
        }

    }
}
