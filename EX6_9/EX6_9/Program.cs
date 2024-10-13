using System;

namespace CnslApp
{
    class Person
    {
        public string name;

        public Person() { this.name = "Bob"; }
        public Person(string n) { this.name = n; }

        public string GetName() { return this.name; }
    }

    class Farmer : Person
    {
        string crop;

        public Farmer() : base() { this.crop = "barley"; }
        public Farmer(string nm) : base(nm) { this.crop = "barley"; }
        public Farmer(string nm, string crp) : base(nm) { this.crop = crp; }

        public string GetCrop() { return this.crop; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Farmer frmr1 = new Farmer();
            Farmer frmr2 = new Farmer("Tom");
            Farmer frmr3 = new Farmer("Tom", "Rice");

            Console.WriteLine(frmr1.GetName());
            Console.WriteLine(frmr2.GetName());
            Console.WriteLine(frmr3.GetCrop());
        }
    }
}