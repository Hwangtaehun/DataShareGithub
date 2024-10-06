Point p;
p.x = 2.5;
p.y = -4.5;

Console.WriteLine("p.x:" + p.x + ", p.y:" + p.y);

Point pnt = p;
Console.WriteLine("pnt.x:" + pnt.x + ", pnt.y:" + pnt.y);

public struct Point
{
    public double x;
    public double y;
}