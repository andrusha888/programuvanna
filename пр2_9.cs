using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть рік: ");
        bool ok = int.TryParse(Console.ReadLine(), out int year);

        if (!ok || year <= 0)
        {
            Console.WriteLine("Помилка введення");
            return;
        }

        if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
        {
            Console.WriteLine("Рік " + year + " є високосним");
        }
        else
        {
            Console.WriteLine("Рік " + year + " не є високосним");
        }
    }
}