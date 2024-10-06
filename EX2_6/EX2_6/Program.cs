Direction drct = Direction.North;

Console.WriteLine(drct);
Console.WriteLine(Direction.South);

Console.WriteLine("Direction.East = {0:d}", Direction.East);
Console.WriteLine("Direction.West = {0:d}", Direction.West);

public enum Direction : byte { North, South, East = 30, West };