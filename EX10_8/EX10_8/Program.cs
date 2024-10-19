using System;

namespace CnslApp
{
    class Idxer
    {
        private int[] arr = new int[3];
        private int[,] arr2d = new int[2, 2];

        public int this[int i]
        {
            set { arr[i] = value; }
            get { return arr[i]; }
        }

        public int this[double d]
        {
            set
            {
                if (0 <= d && d < 1) { arr[0] = value; }
                else if(1 <= d && d < 2) { arr[1] = value; }
                else { arr[2] = value; }
            }
            get
            {
                if (0 <= d && d < 1) { return arr[0]; }
                else if (1 <= d && d < 2) { return arr[1]; }
                else { return arr[2]; }
            }
        }

        public int this[int i, int j]
        {
            set { arr2d[i, j] = value; }
            get { return arr2d[i, j]; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Idxer idx = new Idxer();
            idx[0] = 10; idx[1] = 20; idx[2] = 30;

            Console.WriteLine($"{idx[0]}, {idx[1]}, {idx[2]}");

            idx[0, 0] = 1; idx[0, 1] = 2; idx[1, 0] = 3; idx[1, 1] = 4;
            Console.WriteLine($"{idx[0,0]}, {idx[0,1]}, {idx[1,0]}, {idx[1,1]} ");

            idx[0.23] = 100;
            Console.WriteLine(idx[0.23]);
        }
    }
}