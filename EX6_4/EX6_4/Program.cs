using System;

namespace CnslApp
{
    class Car
    {
        public int year;
        public string numPlate;

        public Car()
        {
            this.year = 2000;
            this.numPlate = "21CAL0201";
        }

        public void Run()
        {
            Console.WriteLine("The car is runnings.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.year);
            Console.WriteLine(myCar.numPlate);
        }
    }
}