double x = 4.5;
double y = 3.0;

Console.WriteLine($"{x} > {y} => {x > y}");
Console.WriteLine($"{x} < {y} => {x < y}");
Console.WriteLine($"{x} >= {y} => {x >= y}");
Console.WriteLine($"{x} <= {y} => {x <= y}");
Console.WriteLine($"{x} == {y} => {x == y}");
Console.WriteLine($"{x} != {y} => {x != y}");

x = 10.5;
Console.WriteLine($"x < 0 || x > 5.0 => {x < 0 || x > 5.0}");
Console.WriteLine($"0 <= x && x <= 5.0 => {0 <= x && x <= 5.0}");
Console.WriteLine($"!(x >= 100) => {!(x >= 100)}");