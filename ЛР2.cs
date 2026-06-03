using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Лабораторна робота №2, Таран Андрій";

        double x = 3.0;
        double y = Math.PI / 2;
        double y1 = Math.Atan(x);

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Лабораторна робота №2 Варіант 15");
        Console.WriteLine();

        Console.WriteLine("*************************************************************");
        Console.Write("y = π/2");

        for (int n = 0; n < 20; n++)
        {
            double term = Math.Pow(-1, n + 1) * 1 / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));

            y = y + term;

            if (term >= 0)
            {
                Console.Write(" + " + term);
            }
            else
            {
                Console.Write(" - " + Math.Abs(term));
            }
        }

        Console.WriteLine(" = " + y);
        Console.WriteLine("*************************************************************");
        Console.WriteLine("x = " + x + " y = " + y + " y1 = " + y1);
    }
}