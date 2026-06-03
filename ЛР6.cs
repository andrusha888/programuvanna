using System;
using System.Text;

class Program
{
    static int BinarySearch(int[] array, int value)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (array[middle] == value)
            {
                return middle;
            }
            else if (value < array[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return -1;
    }

    static void PrintArray(int[] array)
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
        Console.Title = "Лабораторна робота №6, Таран Андрій";

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Лабораторна робота №6 Варіант 7");
        Console.WriteLine();

        Console.Write("Введіть розмір масиву: ");
        bool okSize = int.TryParse(Console.ReadLine(), out int size);

        if (!okSize || size <= 0)
        {
            Console.WriteLine("Помилка введення. Розмір масиву має бути додатним числом.");
            return;
        }

        int[] array = new int[size];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введіть елемент масиву [" + i + "]: ");
            bool okElement = int.TryParse(Console.ReadLine(), out array[i]);

            if (!okElement)
            {
                Console.WriteLine("Помилка введення. Потрібно ввести ціле число.");
                return;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        Console.WriteLine();
        Console.Write("Введіть значення для пошуку: ");
        bool okSearch = int.TryParse(Console.ReadLine(), out int searchValue);

        if (!okSearch)
        {
            Console.WriteLine("Помилка введення. Потрібно ввести ціле число.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Пошук у невідсортованому масиві за допомогою Array.IndexOf:");

        int index = Array.IndexOf(array, searchValue);

        if (index >= 0)
        {
            Console.WriteLine("Елемент знайдено. Індекс елемента: " + index);
        }
        else
        {
            Console.WriteLine("Елемент не знайдено.");
        }

        Console.WriteLine();
        Console.WriteLine("Елементи масиву, які менші за " + searchValue + ":");

        int[] smallerElements = Array.FindAll(array, element => element < searchValue);

        if (smallerElements.Length > 0)
        {
            PrintArray(smallerElements);
        }
        else
        {
            Console.WriteLine("Таких елементів немає.");
        }

        Array.Sort(array);

        Console.WriteLine();
        Console.WriteLine("Відсортований масив:");
        PrintArray(array);

        Console.WriteLine();
        Console.WriteLine("Бінарний пошук у відсортованому масиві:");

        int binaryIndex = BinarySearch(array, searchValue);

        if (binaryIndex >= 0)
        {
            Console.WriteLine("Елемент знайдено. Індекс елемента у відсортованому масиві: " + binaryIndex);
        }
        else
        {
            Console.WriteLine("Елемент не знайдено.");
        }
    }
}