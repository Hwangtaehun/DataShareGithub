float fVar = 4.5f;
double dVar = -123.45E-1;
decimal dcmVar = 2.238_61E3M;

Console.WriteLine(fVar + float.Parse("5.0"));
Console.WriteLine(dVar.ToString() + " -> " + (-123.45E-1).ToString());
Console.WriteLine(dcmVar + 1_000.0M);

Console.WriteLine(dVar / 0.0D);
Console.WriteLine(double.PositiveInfinity - double.PositiveInfinity);
Console.WriteLine(System.Double.NegativeInfinity / System.Double.PositiveInfinity);