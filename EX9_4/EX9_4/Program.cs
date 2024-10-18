using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] array = { 30, 2, 88, 49, 100 };
            int idx = 0, dvsor = 0, result = 0;

            try
            {
                Console.Write("배열의 인덱스를 입력하세요: ");
                idx = Convert.ToInt32(Console.ReadLine());

                Console.Write("나누기의 제수를 입력하세요: ");
                dvsor = Convert.ToInt32(Console.ReadLine());

                result = array[idx] / dvsor;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException: " + e.Message);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("ArithmeticException: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}