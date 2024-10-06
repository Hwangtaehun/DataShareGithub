string str = "Coding";
Console.WriteLine(str[^4]);
Console.WriteLine(str[1..3]);
Console.WriteLine(str[^4..^1]);

Console.WriteLine(str.ToUpper());
Console.WriteLine(str.StartsWith('C'));

str = string.Format("Name:{0}, Age:{1}, Nationality: {2}", "Tom", 23, "Korea");
Console.WriteLine(str);

int iVal = 12345;
double dVal = 3.14519;

Console.WriteLine(string.Format("A{0,10:D}A", iVal));
Console.WriteLine(string.Format("A{0,-10:F2}A", dVal));

Console.WriteLine($"A{ iVal,10:D}A");
Console.WriteLine($"A{ 3.14519,-10:F2}A");