using System;

namespace CnslApp
{
    static class Statistics
    {
        static double max;
        static Statistics() { max = double.MinValue; }
        public static double GetMax(double[] value)
        {
            foreach (double v in value)
                max = (max < v) ? v : max;
            return max;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double[] data = { 28.8, 1.1, 33.0, 12.9 };
            double max = Statistics.GetMax(data);
            Console.WriteLine($"max = {max}");
        }
    }
}