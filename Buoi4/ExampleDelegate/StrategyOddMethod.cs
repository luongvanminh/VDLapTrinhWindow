﻿using System;

namespace ExampleDelegate
{
    public class StrategyOddMethod
    {

        public static void command(int [] arr) {
            Console.WriteLine("StrategyOddMethod run command");
            foreach (int i in arr)
            {
                if (i%2!=0) {
                    System.Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("");
        }

    }
}
