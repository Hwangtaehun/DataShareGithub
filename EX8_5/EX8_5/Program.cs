using System;

namespace CnslApp
{
    interface IMouse { void CheckTouch(); }
    interface IMonitor { void CheckTouch(); }

    class Computer : IMouse, IMonitor
    {
        void IMouse.CheckTouch() 
        {
            Console.WriteLine("Mousepad touched.");
        }

        void IMonitor.CheckTouch()
        {
            Console.WriteLine("Monitor touched.");
        }
    }

    class Program
    {
        static void Main(string[] args) 
        { 
            Computer com = new Computer();

            IMouse imouse = (IMouse)com;
            imouse.CheckTouch();

            IMonitor imon = (IMonitor)com;
            imon.CheckTouch();
        }
    }
}