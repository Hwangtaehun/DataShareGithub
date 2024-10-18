using System;

namespace CnslApp
{
    class NegativeNumberException : ApplicationException
    {
        public NegativeNumberException() : base("Negative Number appeared! \n") { }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            int iVal = 3;

            while(true)
            {
                if(iVal < 0)
                    throw new NegativeNumberException();

                Console.WriteLine($"iVal = {iVal}");
                iVal--;
            }
        }
    }
}