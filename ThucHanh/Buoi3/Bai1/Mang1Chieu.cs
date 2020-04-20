using System;

namespace Bai1
{
    public class Mang1Chieu
    {
        private int[] arr = new int[100];

        public Mang1Chieu() {}

        public Mang1Chieu(int soPhanTu) {
            this.arr = new int [soPhanTu];
        }

        public int length {
            get { return arr.Length; }
        }

        // operator []
        public int this[int i] {
            get { return arr[i]; }
            set {
                arr[i] = value;
            }
        }

        public void prettyPrint() {
            foreach (var i in arr) {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        public void printEven() {
            // foreach (var i in arr) {
            //     if (i%2==0)
            //         Console.Write(i + " ");
            // }

            for (int i = 0; i < this.length; i++) {
                if (this[i]%2==0)
                    Console.Write(this[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
