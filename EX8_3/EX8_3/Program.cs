using System;

namespace CnslApp
{
    interface IHDMI { void ConnectDisplay(); }

    interface IUSB_C { void ConnectUSBTypeC(); }

    class CPU
    {
        public void CommandExecute()
        {
            Console.WriteLine("Command Execution.");
        }
    }

    class Computer : CPU, IHDMI, IUSB_C
    {
        public void ConnectDisplay()
        {
            Console.WriteLine("Display connection completed.");
        }

        public void ConnectUSBTypeC()
        {
            Console.WriteLine("USB-C connection completed.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer laptop = new Computer();
            laptop.CommandExecute();
            laptop.ConnectDisplay();
            laptop.ConnectUSBTypeC();
        }
    }
}