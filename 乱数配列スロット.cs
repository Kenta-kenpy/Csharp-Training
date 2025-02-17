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
            if (int.TryParse(input, out n) && n > 2) break;
            Console.Write("3以上の自然数を入力してください: ");
        }

        int[] array = new int[n]; // ユーザーが指定した要素数で配列を作成

        Random rnd = new Random(); // 乱数生成の準備

        /// 配列に乱数を代入
        for (int i = 0; i < n; i++)
        {
            array[i] = rnd.Next(1, 10); // 1以上10未満の乱数を生成
            Console.WriteLine("配列要素 {0} の値: {1}", i + 1, array[i]);　// {0}と{1}に値を代入
        }

        // すべての要素が一致するかチェック
        bool Icchi = true;
        for (int i = 1; i < n; i++)
        {
            if (array[i] != array[0])
            {
                Icchi = false;
                break;
            }
        }

        // 結果を表示
        if (Icchi)
        {
            Console.WriteLine("Lucky!");
        }
        else
        {
            Console.WriteLine("Luckyではありません");
        }

        Console.ReadLine();
    }
}
