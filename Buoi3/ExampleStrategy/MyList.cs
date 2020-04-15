using System;

namespace ExampleStrategy
{
    public class MyList
    {
        // Attrubutes
        private int [] arr = new int[8]  { 2,  5, 4, 7, 9, 3, 2, 6};
        BaseStrategy strategy;

        // public delegate int command(int [] arr);

        // Constructor
        public MyList(BaseStrategy mStrategy) {
            this.strategy = mStrategy;
        }

        public void Display() {
            this.strategy.command(this.arr);
        }


    }
}
