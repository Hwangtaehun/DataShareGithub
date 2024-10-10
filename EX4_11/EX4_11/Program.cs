int val, idx = 0, sum = 0;

Console.Write("자연수를 입력하시요: ");
val = Convert.ToInt32(Console.ReadLine());

do
{
    sum += idx;
    idx++;
}
while (idx <= val);

Console.WriteLine($"1부터 {val}까지의 합은 {sum}입니다.");