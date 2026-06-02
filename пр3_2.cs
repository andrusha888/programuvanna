using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть ціле додатне число n: ");
        bool ok = int.TryParse(Console.ReadLine(), out int n);

        if (!ok || n <= 0)
        {
            Console.WriteLine("Помилка введення. n має бути додатним цілим числом");
            return;
        }

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + i;
            }
        }

        Console.WriteLine("Сума парних чисел від 1 до " + n + " = " + sum);
    }
}