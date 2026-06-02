using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть число x: ");
        bool okX = double.TryParse(Console.ReadLine(), out double x);

        Console.Write("Введіть цілий додатний степінь k: ");
        bool okK = int.TryParse(Console.ReadLine(), out int k);

        if (!okX || !okK || k <= 0)
        {
            Console.WriteLine("Помилка введення");
            return;
        }

        double result = 1;

        for (int i = 1; i <= k; i++)
        {
            result = result * x;
        }

        Console.WriteLine(x + "^" + k + " = " + result);
    }
}