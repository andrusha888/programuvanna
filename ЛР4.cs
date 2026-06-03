using System;
using System.Text;

class Program
{
    static int SumDigits(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum = sum + digit;
            number = number / 10;
        }

        return sum;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Лабораторна робота №4, Таран Андрій";

        string answer;

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Лабораторна робота №4 Варіант 15");
        Console.WriteLine();

        do
        {
            Console.Write("Введіть ціле додатне число X: ");
            bool ok = int.TryParse(Console.ReadLine(), out int number);

            if (!ok || number < 0)
            {
                Console.WriteLine("Помилка введення. Потрібно ввести ціле додатне число.");
            }
            else
            {
                int result = SumDigits(number);

                Console.WriteLine("Сума цифр числа " + number + " = " + result);
            }

            Console.WriteLine();
            Console.Write("Бажаєте продовжити? Введіть так або ні: ");
            answer = Console.ReadLine().ToLower();

            Console.WriteLine();

        } while (answer == "так");
    }
}