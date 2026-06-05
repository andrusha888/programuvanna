using System;
using System.Text;

class Program
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    static void SumMatrices(int[,] matrixA, int[,] matrixB)
    {
        Console.WriteLine("Сума двох матриць:");

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                int sum = matrixA[i, j] + matrixB[i, j];
                Console.Write(sum + "\t");
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Самостійна робота №2, Таран Андрій";

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Самостійна робота №2 Варіант 15");
        Console.WriteLine();

        Console.Write("Введіть кількість рядків матриць: ");
        bool okRows = int.TryParse(Console.ReadLine(), out int rows);

        Console.Write("Введіть кількість стовпців матриць: ");
        bool okCols = int.TryParse(Console.ReadLine(), out int cols);

        if (!okRows || !okCols || rows <= 0 || cols <= 0)
        {
            Console.WriteLine("Помилка введення. Розмірності матриць мають бути додатними числами.");
            return;
        }

        int[,] matrixA = new int[rows, cols];
        int[,] matrixB = new int[rows, cols];

        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrixA[i, j] = rnd.Next(1, 21);
                matrixB[i, j] = rnd.Next(1, 21);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Перша матриця:");
        PrintMatrix(matrixA);

        Console.WriteLine();
        Console.WriteLine("Друга матриця:");
        PrintMatrix(matrixB);

        Console.WriteLine();
        SumMatrices(matrixA, matrixB);
    }
}