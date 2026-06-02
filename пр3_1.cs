using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть кількість повторень N: ");
        bool ok = int.TryParse(Console.ReadLine(), out int n);

        if (!ok || n <= 0)
        {
            Console.WriteLine("Помилка введення. N має бути додатним цілим числом");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Таран Андрій");
        }
    }
}