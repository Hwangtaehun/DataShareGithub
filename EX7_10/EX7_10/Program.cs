using System;
using System.Globalization;

namespace CnslApp
{
    abstract class Human
    {
        abstract public void SayHello();
    }

    class Korean : Human
    {
        override public void SayHello() 
        {
            Console.WriteLine("안녕하세요.");
        }
    }

    class American : Human
    {
        override public void SayHello()
        {
            Console.WriteLine("Hello.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Korean kr = new Korean();
            kr.SayHello();

            Human hmn = (Human)kr;
            hmn.SayHello();

            American am = new American();
            am.SayHello();
            hmn = (Human)am;
            hmn.SayHello();
        }
    }
}