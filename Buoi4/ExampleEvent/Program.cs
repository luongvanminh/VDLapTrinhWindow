using System;

namespace ExampleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            // BaseDelegate baseDelegate = StrategySortMethod.command;
            // baseDelegate += StrategyOddMethod.command;
            // baseDelegate += StrategyEvenMethod.command;
            // baseDelegate = StrategyOddMethod.command;

            MyList mList = new MyList(StrategySortMethod.command);
            // mList.Display();

            // Subscribe 
            mList.strategy += StrategyOddMethod.command;
            
            // mList.strategy(mList.arr);
            mList.Display();
            // int [] arr = new int[4]  { 9, 3, 2, 6};
            // mList.RaiseEvent(arr);
        }
    }
}
