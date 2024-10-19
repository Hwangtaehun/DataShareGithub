using System;

namespace CnslApp
{
    class StaticPrpt
    {
        private static int sIntVal;
        public static int SIntVal
        {
            get { return sIntVal; }
            set { sIntVal = value; }
        }
        public static int SAutoIntVal
        {
            get; set;
        }
        public static void Add10ToSAutoIntVal()
        {
            SAutoIntVal += 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StaticPrpt.SIntVal = 20;
            Console.WriteLine(StaticPrpt.SIntVal);

            StaticPrpt.SAutoIntVal = 50;
            StaticPrpt.Add10ToSAutoIntVal();
            Console.WriteLine(StaticPrpt.SAutoIntVal);
        }
    }
}