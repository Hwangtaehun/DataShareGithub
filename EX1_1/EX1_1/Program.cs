using System;

namespace EX1_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world");
            Console.Write("Let me know your name: ");
            String? name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
        }
    }
}