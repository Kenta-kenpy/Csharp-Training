using System;

class MonteCarloPi
{
    static void Main()
    {
        int totalPoints;
        // 自然数の入力を促すプロンプト
        while (true)
        {
            Console.Write("自然数を入力してください: ");
            string input = Console.ReadLine();  // 総点数
            if (int.TryParse(input, out totalPoints) && totalPoints > 0)
            {
                break; // 正しい入力があった場合はループを抜ける
            }
            else
            {
                Console.WriteLine("自然数を入力してください。");
            }
        }

        int insideCircle = 0; // 円内に入った点の数
        Random rnd = new Random(); // 乱数生成の準備

        // モンテカルロ法による円周率の近似
        for (int i = 0; i < totalPoints; i++)
        {
            double x = rnd.NextDouble() * 2 - 1; // -1 から 1 の範囲でランダムな x 座標
            double y = rnd.NextDouble() * 2 - 1; // -1 から 1 の範囲でランダムな y 座標

            // (x, y) が円の内部かどうかを判定
            if (x * x + y * y <= 1)
            {
                insideCircle++; // 円内に点があった場合
            }
        }

        // 円周率の近似値
        double pi = 4.0 * insideCircle / totalPoints;
        Console.WriteLine($"円周率概算値: {pi}");

        // 処理が終了する前に一時停止する
        Console.WriteLine("処理が完了しました。Enter キーを押してください...");
        Console.ReadLine();  // ユーザーが Enter キーを押すまで待機
    }
}
