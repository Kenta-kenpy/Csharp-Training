using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("配列を表示");
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; // int型の配列を宣言

        // 配列全体を文字列に変換して表示
        /*Console.WriteLine(array); をそのまま実行すると、配列の型情報（System.Int32[] など）が表示されるだけで、配列の中身は表示されません。
        配列全体を適切に表示するには、string.Join を使うか、foreach ループを利用するのが一般的です。*/
        Console.WriteLine("配列array: " + string.Join(", ", array));
        Console.WriteLine();

        // インデックス付きで個別に表示
        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine($"{index} 番目の要素: {array[index]}");
        }
    }
}
