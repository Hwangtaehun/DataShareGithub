int? x = 213;
int? y = null;
int z;

z = x ?? 100;
Console.WriteLine(z);

z = y ?? 100;
Console.WriteLine(z);