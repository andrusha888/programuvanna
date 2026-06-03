using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть кількість спортсменів n: ");
        bool okN = int.TryParse(Console.ReadLine(), out int n);

        Console.Write("Введіть кількість стрибків m: ");
        bool okM = int.TryParse(Console.ReadLine(), out int m);

        if (!okN || !okM || n <= 0 || m <= 0)
        {
            Console.WriteLine("Помилка введення.");
            return;
        }

        double[,] results = new double[n, m];
        Random rnd = new Random();

        int winner = 0;
        double bestSum = 0;

        Console.WriteLine("Таблиця результатів:");

        for (int i = 0; i < n; i++)
        {
            double sum = 0;

            Console.Write("Спортсмен " + (i + 1) + ": ");

            for (int j = 0; j < m; j++)
            {
                results[i, j] = Math.Round(rnd.NextDouble() * 3 + 4, 2);
                sum += results[i, j];

                Console.Write(results[i, j] + "\t");
            }

            Console.WriteLine("Сума: " + Math.Round(sum, 2));

            if (i == 0 || sum > bestSum)
            {
                bestSum = sum;
                winner = i + 1;
            }
        }

        Console.WriteLine("Переможець: спортсмен №" + winner);
        Console.WriteLine("Його результат: " + Math.Round(bestSum, 2));
    }
}