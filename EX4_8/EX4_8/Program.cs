int[]fib = new int[] { 1, 2, 3, 5, 8 };
int sum = 0;

foreach (var val in fib)
{
    sum += val;
}

Console.WriteLine($"피보나치 수열의 합은 {sum} 입니다.");