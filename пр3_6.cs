using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть число A: ");
        bool okA = int.TryParse(Console.ReadLine(), out int a);

        Console.Write("Введіть число B: ");
        bool okB = int.TryParse(Console.ReadLine(), out int b);

        if (!okA || !okB)
        {
            Console.WriteLine("Помилка введення");
            return;
        }

        if (a == b)
        {
            Console.WriteLine("Між однаковими числами немає цілих чисел.");
            Console.WriteLine("Кількість чисел: 0");
            return;
        }

        int max, min;

        if (a > b)
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }

        int count = 0;

        Console.WriteLine("Числа між A і B у порядку убування:");

        for (int i = max - 1; i > min; i--)
        {
            Console.WriteLine(i);
            count++;
        }

        Console.WriteLine("Кількість чисел: " + count);
    }
}