using System;

namespace ExampleStrategy
{
    public class StrategyEvenMethod:BaseStrategy
    {

        public override void command(int [] arr) {
            Console.WriteLine("StrategyEvenMethod run command");
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
