using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 35;

            AddTen(ref x);

            Console.WriteLine(x);
        }
        static void AddTen(ref int refx)
        {
            refx = refx + 10;
        }
    }
}