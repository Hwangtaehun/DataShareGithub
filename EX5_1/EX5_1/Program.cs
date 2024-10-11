using System;

namespace CnslApp
{
    class Program
    {
        static void Main(String[] args)
        {
            int a = 2, b = 5, c;

            c = Adder(a, b);

            Console.WriteLine($"{a} + {b} = {c}");
        }

        static int Adder(int x, int y)
        {
            int z = x + y;
            return z;
        }
    }
}
