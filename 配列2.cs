using System;

class Program
{
    static void Main()
    {
        Console.Write("配列の要素数を入力してください: ");
        Console.WriteLine(); // 空行を追加
        int n;

        // ユーザーが正しい整数を入力するまで繰り返す
        // TryParse は、特定の型 (int, double, DateTime など) に変換できるかどうかを確認し、成功すれば変換結果を変数に格納し、失敗すれば false を返します。
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("正の整数を入力してください: ");
        }

        int[] array = new int[n]; // ユーザーが指定した要素数で配列を作成

        // 合計、最大値、最小値を初期化
        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i} 番目の要素を入力してください: ");
            while (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.Write("整数を入力してください: ");
            }

            sum = sum + array[i]; // 配列の要素を合計
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }

        // 配列全体を表示
        Console.WriteLine("\n配列の内容: " + string.Join(", ", array));
        // 配列の長さ
        Console.WriteLine("配列の長さ: " + array.Length);

        // 先頭要素
        Console.WriteLine("先頭要素: " + array[0]);
        // 末尾要素
        Console.WriteLine("末尾要素: " + array[array.Length - 1]);

        // 合計
        Console.WriteLine("合計: " + sum);
        // 最大値
        Console.WriteLine("最大値: " + max);
        // 最小値
        Console.WriteLine("最小値: " + min);
        // 平均
        Console.WriteLine("平均: " + (double)sum / array.Length);
    }
}
