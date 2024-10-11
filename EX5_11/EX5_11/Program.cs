using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int rslt;
            int[] intArr = new int[] { 2, 3, 5, 8 };

            rslt = SumInts(intArr);
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