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
        }
    }
}
