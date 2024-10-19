using System;

namespace CnslApp
{
    class Idxer
    {
        private int[] arr = new int[3];

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            Idxer idx = new Idxer();
            idx[0] = 10;
            idx[1] = 20;
            idx[2] = 30;

            Console.WriteLine(idx[0]);
            Console.WriteLine(idx[1]);
            Console.WriteLine(idx[2]);
        }
    }
}