int[] arr = { 4, 9, 7, 10, 11, 8 };

foreach (var val in arr)
{
    if (val % 2 == 0)
    {
        for (int j = 0; j < val; j++)
            Console.Write("*");

        Console.WriteLine();
    }
}