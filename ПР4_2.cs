using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int[] array = new int[10];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введіть елемент " + i + ": ");
            bool ok = int.TryParse(Console.ReadLine(), out array[i]);

            if (!ok)
            {
                Console.WriteLine("Помилка введення");
                return;
            }
        }

        int min = array[0];
        int max = array[0];
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }

            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        int start;
        int end;

        if (minIndex < maxIndex)
        {
            start = minIndex;
            end = maxIndex;
        }
        else
        {
            start = maxIndex;
            end = minIndex;
        }

        int sum = 0;

        for (int i = start + 1; i < end; i++)
        {
            sum += array[i];
        }

        Console.WriteLine("Мінімальний елемент: " + min);
        Console.WriteLine("Максимальний елемент: " + max);
        Console.WriteLine("Сума елементів між ними: " + sum);
    }
}