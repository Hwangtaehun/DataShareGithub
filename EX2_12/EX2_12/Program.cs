short src = 520;
sbyte trgt = (sbyte)src;
Console.WriteLine($"Explicit: short {src} to sbyte {trgt}");

decimal dcmVal = 24.58m;
int iVal = (int)dcmVal;
Console.WriteLine($"Explicit: decimal {dcmVal} to int {iVal} \n");

char ch = 'A';
iVal = ch;
dcmVal = ch;

Console.WriteLine($"Implicit: char {ch} to int {iVal}");
Console.WriteLine($"Implicit: char {ch} to decimal {dcmVal:F2}");