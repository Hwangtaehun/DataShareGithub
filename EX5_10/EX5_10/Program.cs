using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int rslt;

            rslt = SumInts(20, 30, 40);
            Console.WriteLine(rslt);

            rslt = SumInts(20, 30, 40, 50, 60);
            Console.WriteLine(rslt);
        }

        static int SumInts(params int[] iVals)
        {
            int result = 0;

            for (int i = 0; i < iVals.Length; i++)
                result += iVals[i];

            return result;
        }
    }
}