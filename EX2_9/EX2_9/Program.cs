int[,] iArr = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };

Console.WriteLine($"iArr의 1행 => [ {iArr[0, 0]}, {iArr[0, 1]}, {iArr[0, 2]} ]"); 
Console.WriteLine($"iArr의 2행 => [ {iArr[1, 0]}, {iArr[1, 1]}, {iArr[1, 2]} ] \n");

iArr[1, 0] = 4;
iArr[1, 1] = 5;
Console.WriteLine($"iArr의 2행 => [ {iArr[1, 0]}, {iArr[1, 1]}, {iArr[1, 2]} ] \n");

int[,,] miArr = new int[2, 2, 3] {
    { {10, 20, 30 }, {40, 50, 60 } },
    { {1, 3, 5 }, {7, 9, 11  } }
};

Console.WriteLine("miArr 1면:");
Console.WriteLine($"[ {miArr[1, 0, 0]}, {miArr[1, 0, 1]}, {miArr[1, 0, 2]}");
Console.WriteLine($" {miArr[1, 1, 0]}, {miArr[1, 1, 1]}, {miArr[1, 1, 2]} ] \n");

miArr[0, 1, 0] = 4;
miArr[0, 1, 1] = 6;
miArr[0, 1, 2] = 8;

Console.WriteLine($"miArr 0면 1행 => [ {miArr[0, 1, 0]}, {miArr[0, 1, 1]}, {miArr[0, 1, 2]} ] \n");