using System;

namespace カウントダウン
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("カウントダウンを開始します");
            Console.Write("自然数を入力>> ");

            // 入力値を取得し、整数に変換
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 0)
            {
                for (int i = num; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("終わり");
            }
            else // 入力値が自然数でない場合
            {
                Console.WriteLine("無効な入力です。自然数を入力してください。");
            }
        }
    }
}
