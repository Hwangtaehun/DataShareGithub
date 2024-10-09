int x = 3;
double y = 16.4;
double z;

Console.WriteLine("x++ == {0}", x++);
Console.WriteLine("x == {0}", x);

z = x++ + ++y;
Console.WriteLine("x == {0}, y == {1}, z == {2}", x, y, z);

z = --x + y--;
Console.WriteLine("x == {0}, y == {1}, z == {2}", x, y, z);