object obj = 13.5;

switch(obj)
{
    case int:
        Console.WriteLine("int 형입니다.");
        break;
    case float:
        Console.WriteLine("float형입니다.");
        break;
    case double d when d > 0:
        Console.WriteLine("positive double입니다.");
        break;
}