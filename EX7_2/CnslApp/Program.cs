using System;
using Device.CPU;
using Device.HDD;
using Peri;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Intel iCPU = new Intel();
            Device.CPU.AMD amdCPU = new Device.CPU.AMD();
            Device.HDD.AMD amdHDD = new Device.HDD.AMD();
            Mouse ms = new Mouse();

            Console.WriteLine(amdCPU.ToString());
            Console.WriteLine(amdHDD.ToString());
            Console.WriteLine(ms.ToString());
        }
    }
}