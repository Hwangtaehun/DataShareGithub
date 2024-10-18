using System;

namespace CnslApp
{
    class Program
    {
        static void Eagle()
        {
            throw new DivideByZeroException();
        }
        static void Bear()
        {
            Eagle();
            Console.WriteLine("Bear");
        }
        static void Main(string[] args)
        {
            Bear();
            Console.WriteLine("TheEnd");
        }
    }
}