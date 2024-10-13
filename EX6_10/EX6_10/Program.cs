using System;

namespace CnslApp
{
    class Computer
    {
        public string cpu;
        public Computer() { this.cpu = "Intel"; }
        public string getCPU() { return this.cpu; }
    }

    class LapTop : Computer
    {
        string ssd;
        public LapTop() : base() { this.ssd = "1TB"; }
        public string getSSD() { return this.ssd; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer cmptr = new Computer();
            Console.WriteLine($"Computer CPU : {cmptr.getCPU()}");
            Console.WriteLine($"Computer HashCode : {cmptr.GetHashCode()}");
            Console.WriteLine($"Computer ToString : {cmptr.ToString()}");

            LapTop noteBook = new LapTop();
            Console.WriteLine($"LapTop SSD : {noteBook.getSSD()}");
            Console.WriteLine($"LapTop HashCode : {noteBook.GetHashCode()}");
            Console.WriteLine($"LapTop ToString : {noteBook.ToString()}");
        }
    }
}