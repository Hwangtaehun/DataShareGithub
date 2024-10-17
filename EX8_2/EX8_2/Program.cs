using System;

namespace CnslApp
{
    interface IHDMI { void ConnectDisplay(); }

    interface IUSB_C { void ConnectUSBTypeC(); }

    interface IUSB_Hub : IHDMI, IUSB_C
    {
        void CheckPower();
    }

    class HUB : IUSB_Hub
    {
        public void ConnectDisplay() 
        {
            Console.WriteLine("Display connection completed.");
        }
        public void ConnectUSBTypeC() 
        {
            Console.WriteLine("USB-C connection completed.");
        }

        public void CheckPower() 
        {
            Console.WriteLine("Checking Power...");
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            HUB hub = new HUB();
            hub.CheckPower();
            hub.ConnectDisplay();
            hub.ConnectUSBTypeC();
        }
    }
}