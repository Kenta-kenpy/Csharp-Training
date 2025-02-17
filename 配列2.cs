using System;

class Program
{
    static void Main()
    {
        Console.Write("配列の要素数を入力してください: ");
        Console.WriteLine(); // 空行を追加
        int n;

        // ユーザーが正しい整数を入力するまで繰り返す
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("正の整数を入力してください: ");
        }

        int[] array = new int[n]; // ユーザーが指定した要素数で配列を作成

        // 配列の各要素を入力
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i} 番目の要素を入力してください: ");
            while (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.Write("整数を入力してください: ");
            }
        }

        // 配列全体を表示
        Console.WriteLine("\n配列の内容: " + string.Join(", ", array));
        // 配列の長さ
        Console.WriteLine("配列の長さ: " + array.Length);

        // 先頭要素
        Console.WriteLine("先頭要素: " + array[0]);
        // 末尾要素
        Console.WriteLine("末尾要素: " + array[array.Length -1]);
        }
    }



/*配列の要素数 n を入力 → ユーザーが入力した数だけの配列を作成。
各要素を入力できるようにする → for ループで array[i] にユーザーの入力を格納。
配列全体を表示 → string.Join(", ", array) を使用。
インデックス付きで個別表示 → for ループで要素を表示。*/
