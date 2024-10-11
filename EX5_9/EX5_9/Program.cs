using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double krWon = 987234.9;
            double usDollar;

            usDollar = ChangeWontoUSDollar(krWon);
            Console.WriteLine($"By Default Rate: {usDollar:F2}");

            usDollar = ChangeWontoUSDollar(krWon, 1200.5);
            Console.WriteLine($"By Given Rate: {usDollar:F2}");
        }

        static double ChangeWontoUSDollar(double kwAmount, double rate = 1000.0)
        {
            double usdAmnt;
            usdAmnt = kwAmount / rate;
            return usdAmnt;
        }
    }
}