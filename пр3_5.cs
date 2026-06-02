using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Таблиця значень функції y = |x - 3| + |x + 2|");

        Console.WriteLine("x\t y");

        for (double x = -5; x <= 5.0001; x = x + 0.4)
        {
            double y = Math.Abs(x - 3) + Math.Abs(x + 2);

            Console.WriteLine(Math.Round(x, 1) + "\t " + Math.Round(y, 2));
        }
    }
}