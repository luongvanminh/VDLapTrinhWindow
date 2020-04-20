using System;

namespace ExampleStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseStrategy baseStrategy = new StrategySortMethod();
            MyList mList = new MyList(baseStrategy);
            mList.Display();

            try {
                // Vd ve Exception

                // InvalidCastException
                StrategyEvenMethod mStrategy = (StrategyEvenMethod) new BaseStrategy();
                int [] arr = new int[4] { 1, 2, 3, 4};
                mStrategy.command(arr);

                // NullReferenceException:
                StrategySortMethod strategySort = new StrategySortMethod();
                strategySort = null;
                strategySort.command(arr);

            } catch (InvalidCastException e) {
                Console.WriteLine("Xay ra ngoai le: " + e.ToString());
            } catch (Exception e) {
                Console.WriteLine("Xay ra ngoai le: " + e.ToString());
            }
        }
    }
}
