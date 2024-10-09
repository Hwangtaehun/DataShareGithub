int iVal = 10;
object obj = iVal as object;
Console.WriteLine(obj != null ? obj : "null");

string str = "Wonderful!";
obj = str as object;
Console.WriteLine(obj != null ? obj : "null");

obj = iVal;
str = obj as string;
Console.WriteLine(str != null ? str : "null");