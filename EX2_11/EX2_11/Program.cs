int ix = 30;
object obj = ix;
Console.WriteLine($"(Boxing) obj value => {obj}");

int iy = (int)obj;
Console.WriteLine($"(Unboxing) iy value => {iy} \n");

var x = 135;
var y = 45.9M;
var z = "God is Love.";

Console.WriteLine($"x = {x} \t, x type => {x.GetType()}");
Console.WriteLine($"y = {y} \t, y type => {y.GetType()}");
Console.WriteLine($"z = {z}, z type => {z.GetType()}");