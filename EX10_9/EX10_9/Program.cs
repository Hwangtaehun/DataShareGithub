using System;

namespace CnslApp
{
    interface IVehicle
    {
        string Type { get; set; }
        int this[int i] {  get; set; }
    }

    class Car : IVehicle
    {
        int[] power = { 10, 200, 300 };
        public string Type { get; set; }
        public int this[int i] 
        {
            get {  return power[i]; }
            set { power[i] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Type = "SUV";
            Console.WriteLine($"myCar.Type: {myCar.Type}");

            myCar[0] = 100;
            Console.WriteLine($"myCar[1]: {myCar[1]} \n");
        }
    }
}