using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, rslt;
            x = 10;
            y = 20;
            Sum(x, y, out rslt);
            Console.WriteLine(rslt);
        }

        static void Sum(int a, int b, out int result)
        {
            result = a + b;
        }
    }
}