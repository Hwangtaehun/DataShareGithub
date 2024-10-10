int drct = 1;

string dStr = drct switch
{
    0 => "North",
    1 => "South",
    2 => "East",
    3 => "West",
    _ => "No Dirction"
};

Console.WriteLine($"Number {drct} means {dStr}");