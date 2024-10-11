using System;

namespace CnslApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int rslt = 0;
            rslt = Calculate(27, 5, '+');
            Console.WriteLine(rslt);
            rslt = Calculate(67, 28, '-');
            Console.WriteLine(rslt);
            rslt = Calculate(4, 5, '*');
            Console.WriteLine(rslt);
            rslt = Calculate(39, 4, '/');
            Console.WriteLine(rslt);
        }
        static int Calculate(int x, int y, char op)
        {
            int result = 0;

            int Add(int a, int b) { return a + b; }
            int Subtract(int a, int b) { return a - b; }
            int Multiply(int a, int b) { return a * b; }
            int Divide(int a, int b) { return a / b; }

            switch(op)
            {
                case '+': result = Add(x, y); break;
                case '-': result = Subtract(x, y); break;
                case '*': result = Multiply(x, y); break;
                case '/': result = Divide(x, y); break;
            }

            return result;
        }
    }
}