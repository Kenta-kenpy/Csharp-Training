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

        // 最初の要素を入力してもらい、それを最大値と最小値の初期値として使用
        Console.Write("先頭要素を入力してください: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out array[0])) break;
            Console.Write("整数を入力してください: ");
        }

        // 最初の要素を最大値と最小値として設定
        int max = array[0];
        int min = array[0];

        // 先頭の要素はすでに入力されたので、その後の要素を処理
        int sum = 0; // 配列の要素の合計
        sum += array[0];  // 先頭要素も合計に加える

        for (int i = 1; i < n; i++)
        {
            Console.Write($"{i} 番目の要素を入力してください: ");
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out array[i])) break;
                Console.Write("整数を入力してください: ");
            }

            // 合計の更新
            sum += array[i];

            // 最大値の更新
            if (array[i] > max)
            {
                max = array[i];
            }

            // 最小値の更新
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        double average = (double)sum / array.Length;  

        Console.WriteLine("\n配列の内容: " + string.Join(", ", array));
        Console.WriteLine("配列の長さ: " + array.Length);
        Console.WriteLine("先頭要素: " + array[0]);
        Console.WriteLine("末尾要素: " + array[array.Length - 1]);
        Console.WriteLine("合計値: " + sum);
        Console.WriteLine("最大値: " + max);
        Console.WriteLine("最小値: " + min);
        Console.WriteLine("平均値: " + average.ToString("#,0.000")); // 小数点以下3桁で表示
    }
}
