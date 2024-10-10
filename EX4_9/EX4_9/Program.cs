int[] arr = new int[] { 8, 2, 9, 5, 11 };
int max = arr[0];

foreach (var val in arr)
{
    max = (val > max) ? val : max;
}

Console.WriteLine($"최대값은 {max} 입니다.");