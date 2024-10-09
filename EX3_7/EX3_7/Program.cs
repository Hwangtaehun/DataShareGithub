int[] arr = null;
int? len = null;

len = arr?.Length;
Console.WriteLine($"arr?.Length : {len}");
Console.WriteLine($"arr?[2] : {arr?[2]}");

arr = new int[] { 1, 1, 2, 3 };
len = arr?.Length;
Console.WriteLine("arr?.Length : {0}", len);
Console.WriteLine("arr?[2] : {0}", arr?[2]);