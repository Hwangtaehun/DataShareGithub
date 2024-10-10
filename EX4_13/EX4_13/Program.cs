int val = 0;
Console.Write("약수를 찾을 자연수를 입력하세요: ");

val = int.Parse(Console.ReadLine());

Console.Write($"{val}의 약수는 ");

for (int i = 1; i <= val; i++)
{
    if (val == i)
        Console.Write($"{i}");
    else if (val % i == 0)
        Console.Write($"{i}, ");
}

Console.WriteLine("입니다.");