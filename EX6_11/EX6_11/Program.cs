using System;

namespace CnslApp
{
    class Computer { }

    class LapTop : Computer { }

    class Program
    {
        static void Main(string[] args)
        {
            Computer com = new Computer();
            LapTop lap = new LapTop();

            Console.WriteLine($"com is LapTop : {com is LapTop}");
            Console.WriteLine($"lap is Computer : {lap is Computer} \n");

            Console.WriteLine($"com as LapTop : {com as LapTop}");
            Console.WriteLine($"lap as Computer : {lap as Computer}");

            com = lap;
        }
    }
}