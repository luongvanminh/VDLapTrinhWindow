using System;

namespace ExampleDelegate
{
    public class MyList
    {
        // Attrubutes
        private int [] arr = new int[8]  { 2,  5, 4, 7, 9, 3, 2, 6};

        // public delegate void BaseDelegate(int [] arr);
        public event EventHandler<MyListEventArgs> strategy;

        // Constructor
        public MyList(EventHandler<MyListEventArgs> mStrategy) {
            this.strategy = mStrategy;
        }

        public void Display() {
            MyListEventArgs args = new MyListEventArgs();
            args.Arr = this.arr;
            args.name = "Nguyen Van A";

            // Publisher
            this.strategy(this, args);
        }

        public void RaiseEvent(int[] arr) {
            MyListEventArgs args = new MyListEventArgs();
            args.Arr = this.arr;

            // Publisher
            this.strategy(this, args);
        }
    }

    public class MyListEventArgs : EventArgs
    {
        public int[] Arr { get; set; }
        public int age;
        public bool gender;
        public string name;
    }
}
