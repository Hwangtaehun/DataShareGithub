using System;

namespace CnslApp
{
    class Nation
    {
        public string name;
        public Nation(string n) { name = n; }
    }

    class Exchanger
    {
        public const double DEFAULT = 1000.0;
        public readonly double DAY_RATE;
        public readonly Nation COUNTRY;

        public Exchanger(double value, string name)
        {
            DAY_RATE = value;
            COUNTRY = new Nation(name);
        }

        public void Calculate(double cost)
        {
            Console.WriteLine($"Country: {COUNTRY.name}");
            Console.WriteLine($"Default: {cost} to {DEFAULT * cost} won");
            Console.WriteLine($"Day Rate: {cost} to {DAY_RATE * cost} won");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exchanger usToKor = new Exchanger(1192.5, "USA");
            Exchanger ausToKor = new Exchanger(875.5, "AUSTRALIA");

            Console.WriteLine($"const field: {Exchanger.DEFAULT}");
            Console.WriteLine($"readonly field: {usToKor.DAY_RATE} \n");

            usToKor.Calculate(30.0);
            Console.WriteLine();
            ausToKor.Calculate(30.0);
        }
    }
}