using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int iVal = 10000;

            for(int i = 5; ; i--)
                Console.WriteLine($"{iVal} / {i} = {iVal/i}");
        }
    }
}