int val;
Console.Write("프로그래밍 과목 점수를 입력하세요: ");
val = int.Parse(Console.ReadLine());

switch(val / 10)
{
    case 10:
    case 9:
        Console.WriteLine("A 학점입니다.");
        break;
    case 8:
        Console.WriteLine("B 학점입니다.");
        break;
    case 7:
        Console.WriteLine("C 학점입니다.");
        break;
    default:
        Console.WriteLine("F 학점입니다.");
        break;
}