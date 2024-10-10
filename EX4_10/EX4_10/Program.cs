int val, idx = 1, sum = 0;

Console.Write("자연수를 입력하시오: ");
val = Convert.ToInt32(Console.ReadLine());

while(idx <= val)
{
    sum += idx;
    idx++;
}

Console.WriteLine($"1부터 {val}까지의 합은 {sum}입니다.");