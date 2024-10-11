using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 35, b = 50;
            Console.WriteLine($"Before: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After: a = {a}, b = {b}");
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}