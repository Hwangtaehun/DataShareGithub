using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
                foreach(string str in args)
                    Console.WriteLine("Main Method Parameter: {0}", str);
        }
    }
}