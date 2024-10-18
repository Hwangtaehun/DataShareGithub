using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] array = { 30, 2, 88, 49, 100 };

            try
            {
                for (int i = 0; i < 10; i++)
                    Console.WriteLine(array[i]);
            }
            catch (IndexOutOfRangeException e) { Console.WriteLine(e.Message); }
            finally { Console.WriteLine("try-catch block completed \n"); }

            Console.WriteLine("Program Finished");
        }
    }
}