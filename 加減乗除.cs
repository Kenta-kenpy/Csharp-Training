using System;

namespace 加減乗除
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int seisu1, seisu2;

            Console.Write("整数1を入力してください: ");
            seisu1 = int.Parse(Console.ReadLine());

            Console.Write("整数2を入力してください: ");
            seisu2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"和: {seisu1 + seisu2}");
            Console.WriteLine($"整数1-整数2の差: {seisu1 - seisu2}");
            Console.WriteLine($"整数2-整数1の差: {seisu2 - seisu1}");
            Console.WriteLine($"積: {seisu1 * seisu2}");

            if (seisu2 != 0)
            {
                Console.WriteLine("整数1÷整数2");
                Console.WriteLine($"商: {seisu1 / seisu2}");
                Console.WriteLine($"余り: {seisu1 % seisu2}");
            }
            if(seisu1 != 0)
            {
                Console.WriteLine("整数2÷整数1");
                Console.WriteLine($"商: {seisu2 / seisu1}");
                Console.WriteLine($"余り: {seisu2 % seisu1}");
            }
            else
            {
                Console.WriteLine("商: 計算不可（ゼロ除算）");
                Console.WriteLine("余り: 計算不可（ゼロ除算）");
            }
        }
    }
}

/*Console.WriteLine("整数1を入力してください: " , seisu1); → Console.Write("整数1を入力してください: "); に修正し、Console.ReadLine() で入力を取得。
文字列補間 ($"") を使用して、変数の値を含むメッセージを適切に出力。
ゼロ除算 (seisu2 == 0 の場合) を防ぐための条件分岐を追加。*/
