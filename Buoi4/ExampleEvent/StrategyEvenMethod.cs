using System;

namespace ExampleDelegate
{
    public class StrategyEvenMethod
    {

        public static void command(object sender, MyListEventArgs args) {
            int [] arr = args.Arr;
            Console.WriteLine("StrategyEvenMethod run command with name: " + args.name);
            foreach (int i in arr)
            {
                if (i%2==0) {
                    System.Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("");
        }

    }
}
