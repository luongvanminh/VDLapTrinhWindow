using System;

namespace ExampleDelegate
{
    public class MyList
    {
        // Attrubutes
        public int [] arr = new int[8]  { 2,  5, 4, 7, 9, 3, 2, 6};

        public delegate void BaseDelegate(int [] arr);
        public event BaseDelegate strategy;

        // Constructor
        public MyList(BaseDelegate mStrategy) {
            this.strategy = mStrategy;
        }

        public void Display() {
            // Publisher
            this.strategy(this.arr);
        }

        public void RaiseEvent(int[] arr) {
            // Publisher
            this.strategy(arr);
        }


    }
}
