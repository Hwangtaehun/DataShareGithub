using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 4, area;
            area = CircleArea(radius);
            Console.WriteLine(area);
        }

        static double CircleArea(double red)
        {
            const double PI = 3.14;
            return PI * Math.Pow(red, 2.0);
        }
    }
}