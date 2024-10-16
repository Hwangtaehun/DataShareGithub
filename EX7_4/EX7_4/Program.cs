using System;

namespace CnslApp
{
    class Calculator
    {
        public int Add(int x) { return x + 1; }
        public int Add(int x, int y) {return x + y; }
        public double Add(double x, double y) { return x + y; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine($"calc.Add(10) => {calc.Add(10)}");
            Console.WriteLine($"calc.Add(10, 20) => {calc.Add(10, 20)}");
            Console.WriteLine($"calc.Add(10.2, 20) => {calc.Add(10.2, 20)}");
        }
    }
}