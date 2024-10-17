using System;

namespace CnslApp
{
    interface IMouse { void CheckTouch(); }
    interface IMonitor { void CheckTouch(); }

    class Computer : IMouse, IMonitor
    {
        public void CheckTouch() 
        {
            Console.WriteLine("touched.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer com = new Computer();
            com.CheckTouch();

            IMouse imouse = (IMouse)com;
            imouse.CheckTouch();

            IMonitor imon = (IMonitor)com;
            imon.CheckTouch();
        }
    }
}