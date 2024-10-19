using System;

namespace CnslApp
{
    class Idxer
    {
        private int bField0;
        private int bField1;
        private int bField2;

        public int this[int i]
        {
            get
            {
                if (i == 0) { return bField0; }
                else if (i == 1) { return bField1; }
                else { return bField2; }
            }
            set
            {
                if (i == 0) { bField0 = value; }
                else if (i == 1) { bField1 = value; }
                else { bField2 = value; }
            }
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