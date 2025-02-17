using System;

class Program
{
    static void Main()
    {
        Console.Write("配列の要素数を入力してください: ");
        Console.WriteLine(); // 空行を追加
        int n;

        // ユーザーが正しい整数を入力するまで繰り返す
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out n) && n > 0) break;
            Console.Write("正の整数を入力してください: ");
        }

        int[] array = new int[n]; // ユーザーが指定した要素数で配列を作成

        int sum = 0; // 配列の要素の合計
        int max = int.MinValue; // 配列の最大値
        int min = int.MaxValue; // 配列の最小値

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i} 番目の要素を入力してください: ");
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out array[i])) break;
                Console.Write("整数を入力してください: ");
            }

            sum += array[i]; // 配列の要素を合計
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }

        Console.WriteLine("\n配列の内容: " + string.Join(", ", array));
        Console.WriteLine("配列の長さ: " + array.Length);
        Console.WriteLine("先頭要素: " + array[0]);
        Console.WriteLine("末尾要素: " + array[^1]); // `array[array.Length - 1]` の簡略形
        Console.WriteLine("合計: " + sum);
        Console.WriteLine("最大値: " + max);
        Console.WriteLine("最小値: " + min);
        Console.WriteLine("平均: " + (double)sum / array.Length);
    }
}
