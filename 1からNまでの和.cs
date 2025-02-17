using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1からどこまでの合計を求めますか: ");
        int N = int.Parse(Console.ReadLine());

        // 数学的公式を用いて和を計算
        int sum = N * (N + 1) / 2;
        Console.WriteLine(); // 空行
        Console.WriteLine("合計");
        Console.WriteLine(sum);
    }
}
