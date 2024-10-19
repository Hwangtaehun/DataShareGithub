using System;

namespace CnslApp
{
    class Date
    {
        private int day;
        public int GetDay() { return day; }
        public void SetDay(int x)
        {
            if(x < 1 || x > 31)
                this.day = 1;
            else
                this.day = x;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date();
            d.SetDay(40);
            Console.WriteLine($"Day: {d.GetDay()} \n");
        }
    }
}