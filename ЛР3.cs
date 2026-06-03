using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Лабораторна робота №3, Таран Андрій";

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Лабораторна робота №3 Варіант 15");
        Console.WriteLine();

        int[,] matrix = new int[10, 10];
        Random rnd = new Random();

        Console.WriteLine("Сформована матриця:");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = rnd.Next(-20, 51);
                Console.Write(matrix[i, j] + "\t");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Максимальні елементи у парних стовпцях:");

        for (int j = 1; j < 10; j += 2)
        {
            int max = matrix[0, j];

            for (int i = 1; i < 10; i++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }

            Console.WriteLine("Стовпець " + (j + 1) + ": максимальний елемент = " + max);
        }
    }
}