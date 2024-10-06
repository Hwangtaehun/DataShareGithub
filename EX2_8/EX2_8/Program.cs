int[] iArr = new int[3];

Console.WriteLine($"iArr.Length = {iArr.Length} ");

Console.WriteLine("iArr.Rank = " +  iArr.Rank);

iArr[2] = 200;
iArr.SetValue(100, 1);
Console.WriteLine($"iArr = [ {iArr[0]}, {iArr[1]}, {iArr[2]} ]");

Array.Reverse(iArr, 0, 3);
Console.WriteLine($"(Reversed) iArr = [ {iArr[0]}, {iArr[1]}, {iArr[2]} ]");

Array.Sort(iArr);
Console.WriteLine($"(Sorted) iArr = [ {iArr[0]}, {iArr[1]}, {iArr[2]} ]");

int[] cpArr = iArr;
cpArr[2] = 1000;
Console.WriteLine($"(Reference Copied) iArr[2]:{iArr[2]}, cpArr[2]:{cpArr[2]}");

cpArr = (int[])iArr.Clone();
cpArr[2] = 2000;
Console.WriteLine($"(Instance Copied) iArr[2]: {iArr[2]}, cpArr[2]:{cpArr[2]}");