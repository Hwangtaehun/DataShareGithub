using System;

namespace CnslApp
{
    class Car
    {
        public int year;
        public string numPlate;

        public Car()
        {
            year = 2000;
            numPlate = "21CAL0201";
        }

        public Car(int y)
        {
            year = y;
            numPlate = "21CAL0201";
        }

        public Car(string nP)
        {
            year = 2000;
            numPlate = nP;
        }

        public Car(int y, string nP)
        {
            year = y;
            numPlate = nP;
        }

        public void Run()
        {
            Console.WriteLine("The car is running.");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Car myCar = new Car();
                Car tCar = new Car(2021, "TA0031");

                Console.WriteLine($"myCar.numPlate = {myCar.numPlate}");
                Console.WriteLine($"tCar.numPlate = {tCar.numPlate}");
            }
        }
    }
}