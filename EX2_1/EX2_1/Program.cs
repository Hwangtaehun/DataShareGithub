using System;

int iVal = 30000;
const Int32 cVal = 0X3ABC;

iVal = iVal + cVal;

Console.WriteLine(iVal);

Console.WriteLine(int.MinValue);
Console.WriteLine(UInt64.MinValue);
Console.WriteLine(short.Parse("1234") + 4321);
Console.WriteLine(cVal.ToString() + " *** " + 2000.ToString());