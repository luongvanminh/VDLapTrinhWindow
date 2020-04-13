using System;

namespace ExampleDelegate
{
    public class StrategySortMethod
    {

        public static void command(object sender, MyListEventArgs args) {
            int [] arr = args.Arr;
            Console.WriteLine("sender object: " + sender);
            // MyList tempList = (MyList) sender;
            Console.WriteLine("StrategySortMethod run command with name: " + args.name);
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
