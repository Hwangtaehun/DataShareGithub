using System;

namespace CnslApp
{
    class PrntCls
    {
        public int iPrnt = 30;
        public void SayHello()
        {
            Console.WriteLine("Hello, PrntCls.");
        }
    }

    class ChldCls : PrntCls
    {
        public int iChld = 20;
        public void SayHello()
        {
            Console.WriteLine("Hello, ChldCls.");
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            ChldCls chld = new ChldCls();
            chld.SayHello();
            Console.WriteLine($"chld.iPrnt => {chld.iPrnt}");
            Console.WriteLine($"chld.iChld => {chld.iChld}");

            PrntCls prnt = (PrntCls)chld;
            prnt.SayHello();
            Console.WriteLine($"prnt.iPrnt => {prnt.iPrnt}");
        }
    }
}