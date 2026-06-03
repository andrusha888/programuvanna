using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть розмір масиву: ");
        bool ok = int.TryParse(Console.ReadLine(), out int n);

        if (!ok || n <= 0)
        {
            Console.WriteLine("Помилка введення.");
            return;
        }

        int[] array = new int[n];
        Random rnd = new Random();

        int sum = 0;

        Console.WriteLine("Масив:");

        for (int i = 0; i < n; i++)
        {
            array[i] = rnd.Next(1, 51);
            sum += array[i];
            Console.Write(array[i] + " ");
        }

        double average = (double)sum / n;

        Console.WriteLine();
        Console.WriteLine("Середнє арифметичне: " + average);
        Console.WriteLine("Елементи, більші за середнє:");

        for (int i = 0; i < n; i++)
        {
            if (array[i] > average)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}