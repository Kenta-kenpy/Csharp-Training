using System;

namespace 偶奇判定
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("整数を入力してください：");

            // 入力値の検証
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                // 偶数・奇数の判定
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} は偶数です。");
                }
                else
                {
                    Console.WriteLine($"{number} は奇数です。");
                }
            }
            else
            {
                Console.WriteLine("無効な入力です。整数を入力してください。");
            }
        }
    }
}
