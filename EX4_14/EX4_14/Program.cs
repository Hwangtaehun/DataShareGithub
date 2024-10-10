int lbl;

Console.Write("자연수를 입력하시오:");
lbl = int.Parse(Console.ReadLine());

if (lbl % 3 == 0)
    goto LAPTOP;
if (lbl % 3 == 1)
    goto DESKTOP;
if (lbl % 3 == 2)
    goto TABLET;

LAPTOP:
Console.WriteLine("LapTop");

DESKTOP:
Console.WriteLine("DeskTop");

TABLET:
Console.WriteLine("Tablet");