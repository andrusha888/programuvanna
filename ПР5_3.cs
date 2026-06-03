using System;

class Program
{
    static void CheckMultiple()
    {
        Console.Write("Введіть перше число: ");
        bool ok1 = int.TryParse(Console.ReadLine(), out int number1);

        Console.Write("Введіть друге число: ");
        bool ok2 = int.TryParse(Console.ReadLine(), out int number2);

        if (!ok1 || !ok2)
        {
            Console.WriteLine("Помилка введення.");
            return;
        }

        if (number2 == 0)
        {
            Console.WriteLine("На нуль ділити не можна.");
            return;
        }

        if (number1 % number2 == 0)
        {
            Console.WriteLine("Число " + number1 + " є кратним числу " + number2);
        }
        else
        {
            Console.WriteLine("Число " + number1 + " не є кратним числу " + number2);
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        CheckMultiple();
    }
}