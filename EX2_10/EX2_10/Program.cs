int[][] jArr = new int[3][] 
{
    new int[]{1, 3, 5 },
    new int[]{2, 3, 5, 8 },
    new int[]{11, 13 }
};

Console.WriteLine($"jArr[0] => [ {jArr[0][0]}, {jArr[0][1]}, {jArr[0][2]} ]");
Console.WriteLine($"jArr[1] => [ {jArr[1][0]}, {jArr[1][1]}, {jArr[1][2]}, {jArr[1][3]} ]");
Console.WriteLine($"jArr[2] => [ {jArr[2][0]}, {jArr[2][1]} ] \n");

jArr[0][1] = 100;
Console.WriteLine($"jArr[0] => [ {jArr[0][0]}, {jArr[0][1]}, {jArr[0][2]} ]");