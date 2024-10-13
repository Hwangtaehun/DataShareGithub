using System;

namespace CnslApp
{
    class Car
    {
        int year;
        string numPlate;

        public void Run()
        {
            Console.WriteLine("The car is running.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Run();
        }
    }
}