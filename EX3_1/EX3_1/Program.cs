Console.WriteLine($"3+4 => {3 + 4}");
Console.WriteLine($"3-4 => {3 - 4}");
Console.WriteLine($"23*0.5 => {23 * 0.5}");
Console.WriteLine($"23/5 => {23 / 5}");
Console.WriteLine($"23/5.0 => {23 / 5.0}");
Console.WriteLine($"2.3M/5.0M => {2.3M / 5.0M:F3}");

Console.WriteLine($"40.0%4.5 => {40.0 % 4.5}");
Console.WriteLine($"-40.0%4.5 => {-40.0 % 4.5}");

short shVal = 3;
int iVal = 40;
Console.WriteLine($"short + int: {shVal + iVal}");

double dblVal = 4.5;
decimal dcmlVal = (decimal)(iVal - dblVal);
Console.WriteLine($"(decimal)(iVal - dblVal) => {dcmlVal}");

dcmlVal = (decimal)dblVal * dcmlVal;
Console.WriteLine($"(decimal)dblVal * dcmVal => {dcmlVal}");