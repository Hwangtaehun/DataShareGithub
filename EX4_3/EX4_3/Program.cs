double score = 0;
Console.Write("프로그래밍 점수를 입력하세요: ");

score = double.Parse(Console.ReadLine());

if (score >= 90)
    Console.WriteLine("A 학점입니다.");
else if (score >= 80)
    Console.WriteLine("B 학점입니다.");
else if (score >= 70)
    Console.WriteLine("C 학점입니다.");
else
    Console.WriteLine("F 학점입니다.");