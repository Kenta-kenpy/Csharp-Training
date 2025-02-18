using System;

namespace LeepYear
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("西暦を入力してください：");

            // 入力値の検証
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                // うるう年の判定
                if (year % 4 == 0 && year % 100 == 0 || year % 400 == 0)
                {
                    Console.WriteLine($"西暦{year} 年はうるう年です。");
                }
                else
                {
                    Console.WriteLine($"西暦{year} 年は平年です。");
                }
            }
            else
            {
                Console.WriteLine("無効な入力です。整数を入力してください。");
            }
        }
    }
}
