using System;

namespace CnslApp
{
    class AutoPrpt
    {
        public int IntVal
        {
            get; set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AutoPrpt aPrpt = new AutoPrpt();
            aPrpt.IntVal = 20;
            Console.WriteLine($"Auto Property: {aPrpt.IntVal} \n");
        }
    }
}