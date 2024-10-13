using System;

namespace CnslApp
{
    class Person
    {
        public string name;

        public Person()
        {
            Console.WriteLine("Parent Constructor called");
        }

        public string GetName() { return name; }
    }

    class Farmer: Person
    {
        string crop;

        public Farmer(string nm, string crp)
        {
            base.name = nm;
            this.crop = crp;
            Console.WriteLine("Child Constructor Called");
        }

        public string GetCrop() { return this.crop; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Farmer frmr = new Farmer("Tom", "Rice");
            Console.WriteLine(frmr.GetName());
            Console.WriteLine(frmr.GetCrop());
        }
    }
}