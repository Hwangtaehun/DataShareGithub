using System;

namespace CnslApp
{
    internal interface IUSB
    {
        static double width = 11.5;
        static double height = 4.5;
        static int numPins = 4;
        void USBRead();
        void USBWrite();
    }

    class SanDisk : IUSB
    {
        public void USBRead()
        {
            Console.WriteLine("Read data from USB Memory. ");
        }

        public void USBWrite() 
        {
            Console.WriteLine("Write data to USB Memory. ");
        }

        public void DisplayManufacturer()
        {
            Console.WriteLine("by SanDisk");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SanDisk sMem = new SanDisk();
            sMem.USBRead();
            sMem.USBWrite();
            sMem.DisplayManufacturer();

            IUSB usb = (IUSB)sMem;
            usb.USBRead();
            usb.USBWrite();
            Console.WriteLine($"USB Pins = {IUSB.numPins}");
        }
    }
}