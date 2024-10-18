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
            try
            {
                Bear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("TheEnd");
        }
    }
}