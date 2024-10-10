int val = 0;
Console.Write("프로그래밍 점수를 입력하세요:");

val = int.Parse(Console.ReadLine());

if (val >= 60)
    Console.WriteLine("패스하셨습니다.");
else
    Console.WriteLine("재수강하셔야 합니다.");