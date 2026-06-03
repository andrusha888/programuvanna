using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Лабораторна робота №1, Таран Андрій";

        double x = 0.33;
        double y = 0.025;
        double z = 32.005;
        double a = 7.65;
        double b = 14.7;

        double h = x * (Math.Pow(Math.Sin(x * x), 2) * Math.Atan(y) + Math.Pow(Math.Cos(z), 2));
        double k = Math.Pow(Math.Log(a * x), 2) / Math.Exp(x / (a * b));
        double m = Math.Sqrt(x) / (a + Math.Sqrt(b * x));
        double r = y / 2 + Math.Pow(Math.Sin(Math.Pow(z, 3)), 2);

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Лабораторна робота №1 Варіант 15");
        Console.WriteLine();

        Console.WriteLine("Початкові значення:");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine("z = " + z);
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine();

        Console.WriteLine("Результати обчислень:");
        Console.WriteLine("h = " + h);
        Console.WriteLine("k = " + k);
        Console.WriteLine("m = " + m);
        Console.WriteLine("r = " + r);
    }
}