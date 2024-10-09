int iVal = 10;
Console.WriteLine($"iVal is object => {iVal is object}");

double dbVal = 33.3;
object obj = dbVal;
Console.WriteLine($"dbVal is object => {dbVal is object}");
Console.WriteLine($"obj is double = > {obj is double}");
Console.WriteLine($"obj is int => {obj is int}");