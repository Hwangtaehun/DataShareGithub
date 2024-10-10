int val, fctrl = 1;

Console.Write("팩토리얼을 계산할 자연수를 입력하세요: ");
val = int.Parse(Console.ReadLine());

for (int i = 1; ; i++)
{
    if (i > val)
        break;
    fctrl *= i;
}

Console.WriteLine($"{val}!은 {fctrl}입니다.");