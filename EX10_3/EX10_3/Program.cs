using System;

namespace CnslApp
{
    class Circle
    {
        private double radius;
        private double pi = 3.14;
        public double Radius
        {
            set { radius = value; }
        }
        public double Area
        {
            get 
            {
                return pi * radius * radius;
            }
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            Circle c = new Circle();
            c.Radius = 2.0;
            Console.WriteLine($"Area: {c.Area} \n");
        }
    }
}