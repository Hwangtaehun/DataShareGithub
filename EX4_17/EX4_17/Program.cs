int val, sum = 0;

Console.Write("홀수의 합을 계산할 자연수를 입력하세요: ");
val = int.Parse(Console.ReadLine());

for (int i = val; i > 0; i--)
{
    if (i % 2 == 0)
        continue;
    sum += i;
}

Console.WriteLine($"1부터 {val}까지 홀수의 합은 {sum}입니다.");