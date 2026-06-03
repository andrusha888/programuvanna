using System;
using System.Text;

class Program
{
    static void InsertionSort(double[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            double key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }

    static void PrintArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Лабораторна робота №5, Таран Андрій";

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Лабораторна робота №5 Варіант 15");
        Console.WriteLine();

        double[] array = new double[10];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введіть елемент масиву [" + i + "]: ");
            bool ok = double.TryParse(Console.ReadLine(), out array[i]);

            if (!ok)
            {
                Console.WriteLine("Помилка введення. Потрібно ввести дробове число.");
                return;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        InsertionSort(array);

        Console.WriteLine();
        Console.WriteLine("Відсортований масив за зростанням:");
        PrintArray(array);
    }
}