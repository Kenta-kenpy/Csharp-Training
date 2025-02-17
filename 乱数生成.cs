using System;

namespace 乱数生成
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // 乱数生成の準備
            //整数の乱数
            int x;
            for (int i = 1; i <= 10; i++)
            {
                x = rnd.Next(10); // 乱数生成(0以上10未満) ※指定しなければ0～int.MaxValue未満
                Console.WriteLine("Random number: " + x);
            }
            Console.WriteLine();

            //小数の乱数
            double y;
            for (int i = 1; i <= 10; i++)
            {
                y = rnd.NextDouble(); // 乱数生成(0以上1.0未満小数)
                Console.WriteLine("Random number: " + y);
            }
        }
    }
}
