using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // 1～1000までの範囲
            for (int input = 1; input <= 1000; input++)
            {
                // 3と5の公倍数
                if (input % 15 == 0)
                {
                    Console.WriteLine($"{input}  FizzBuzz");
                }
                // 3の倍数
                else if (input % 3 == 0)
                {
                    Console.WriteLine($"{input}  Fizz");
                }
                // 5の倍数
                else if (input % 5 == 0)
                {
                    Console.WriteLine($"{input}  Buzz");
                }
                // 3の倍数でも5の倍数でもない数
                else
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
