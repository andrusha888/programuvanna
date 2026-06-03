using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int[,] matrix = new int[10, 8];
        Random rnd = new Random();

        long product = 1;
        bool hasPositive = false;

        Console.WriteLine("Матриця:");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                matrix[i, j] = rnd.Next(-10, 11);
                Console.Write(matrix[i, j] + "\t");

                if (matrix[i, j] > 0)
                {
                    product *= matrix[i, j];
                    hasPositive = true;
                }
            }

            Console.WriteLine();
        }

        if (hasPositive)
        {
            Console.WriteLine("Добуток додатних елементів: " + product);
        }
        else
        {
            Console.WriteLine("Додатних елементів немає");
        }
    }
}