using System;
using Things;

namespace CnslApp
{
    class Drill : Machine
    {
       public void ModifyData()
        {
            pub = 20;
            pro = 50;
            proIntr = 60;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Machine mchn = new Machine();
            mchn.pub = 20;
            Console.WriteLine(mchn.ToString());
        }
    }
}