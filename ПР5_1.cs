using System;

class Program
{
    static void PrintTable(int number)
    {
        if (number == 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("Таблиця множення для числа " + i);

                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Таблиця множення для числа " + number);

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + (number * i));
            }
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть число від 1 до 9 або 0 для всієї таблиці: ");
        bool ok = int.TryParse(Console.ReadLine(), out int number);

        if (!ok || number < 0 || number > 9)
        {
            Console.WriteLine("Помилка введення");
            return;
        }

        PrintTable(number);
    }
}