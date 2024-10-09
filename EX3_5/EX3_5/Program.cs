double temp = 0.0;
Console.Write("Type today's temperature: ");
temp = Convert.ToDouble(Console.ReadLine());
string weather = temp < 25.0 ? "cool" : ((temp < 35.0) ? "hot" : "very hot");
Console.WriteLine("Today is " + weather);