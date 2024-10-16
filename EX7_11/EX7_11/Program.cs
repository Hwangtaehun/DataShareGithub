using System;

namespace CnslApp
{
    class Human { }

    sealed class Korean : Human
    {
        public Korean() { }
        public void WhoAreYou()
        {
            Console.WriteLine("I am a korean.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Korean kor = new Korean();
            kor.WhoAreYou();
        }
    }
}