using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int rslt = 0;
            rslt = RecursiveSum(3);
            Console.WriteLine(rslt);
        }
        static int RecursiveSum(int val)
        {
            int result = 0;
            if (val == 1)
                return val;
            else
                result = val + RecursiveSum(val - 1);
            return result;
        }
    }
}