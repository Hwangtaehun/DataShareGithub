int val = default(int);
Console.Write("자연수를 입력하세요:");
val = Convert.ToInt32(Console.ReadLine());

if (val % 2 == 0)
    Console.WriteLine($"{val}은 짝수입니다.");