using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = ChangeNumber('5', '4');
            Console.WriteLine(number);

            number = ChangeNumber(one: '5', ten: '4');
            Console.WriteLine(number);
        }

        static int ChangeNumber(char ten, char one)
        {
            int nmbr;
            nmbr = 10 * int.Parse(ten.ToString()) + (int)char.GetNumericValue(one);
            return nmbr;
        }
    }
}