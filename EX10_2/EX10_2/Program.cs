using System;

namespace CnslApp
{
    class Date
    {
        private int day;
        public int PrptDay
        {
            get
            {
                return day;
            }
            set
            {
                if(value < 1 || value > 31) this.day = 1;
                else this.day = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date();
            d.PrptDay = 20;
            int val = d.PrptDay;  
            Console.WriteLine($"val : {val} \n");
        }
    }
}