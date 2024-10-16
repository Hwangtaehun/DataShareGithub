using System;

namespace CnslApp
{
    class PrntCls
    {
        virtual public void SayHello()
        {
            Console.WriteLine("Hello, PrntCls. ");
        }
    }

    class SonCls : PrntCls
    {
        override public void SayHello()
        {
            Console.WriteLine("Hello, SonCls. ");
        }
    }

    class DaughterCls : PrntCls
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello, DaughterCls. ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SonCls son = new SonCls();
            DaughterCls dter = new DaughterCls();

            son.SayHello();
            PrntCls prnt = (PrntCls)son;
            prnt.SayHello();

            dter.SayHello();
            prnt = (PrntCls)dter;
            prnt.SayHello();
        }
    }
}