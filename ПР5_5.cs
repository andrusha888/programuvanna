using System;

class Program
{
    static void Swap(ref double number1, ref double number2)
    {
        double temp = number1;
        number1 = number2;
        number2 = temp;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть перше число: ");
        bool ok1 = double.TryParse(Console.ReadLine(), out double number1);

        Console.Write("Введіть друге число: ");
        bool ok2 = double.TryParse(Console.ReadLine(), out double number2);

        if (!ok1 || !ok2)
        {
            Console.WriteLine("Помилка введення.");
            return;
        }

        Console.WriteLine("До обміну:");
        Console.WriteLine("Перше число = " + number1);
        Console.WriteLine("Друге число = " + number2);

        Swap(ref number1, ref number2);

        Console.WriteLine("Після обміну:");
        Console.WriteLine("Перше число = " + number1);
        Console.WriteLine("Друге число = " + number2);
    }
}