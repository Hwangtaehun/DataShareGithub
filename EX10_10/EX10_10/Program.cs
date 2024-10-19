using System;

namespace CnslApp
{
    abstract class Vehicle
    {
        int idNumber;

        public int IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        abstract public string Type { get; set; }
        abstract public int this[int i] { get; set; }
    }

    class Car : Vehicle
    {
        int[] power = { 10, 200, 300 };

        override public string Type { get; set; }

        override public int this[int i]
        {
            get { return power[i]; }
            set { power[i] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.IdNumber = 822022;
            Console.WriteLine($"myCar.IdNumber: {myCar.IdNumber}");

            myCar.Type = "SUV";
            Console.WriteLine($"myCar.Type: {myCar.Type}");

            myCar[0] = 100;
            Console.WriteLine($"myCar[1]: {myCar[1]} \n");
        }
    }
}