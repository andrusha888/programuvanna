using System;
using System.Text;

class Rectangle
{
    private double sideA;
    private double sideB;

    public Rectangle()
    {
        sideA = 1;
        sideB = 1;
    }

    public Rectangle(double a, double b)
    {
        sideA = a;
        sideB = b;
    }

    public void SetSides(double a, double b)
    {
        sideA = a;
        sideB = b;
    }

    public double GetSideA()
    {
        return sideA;
    }

    public double GetSideB()
    {
        return sideB;
    }

    public double GetPerimeter()
    {
        return 2 * (sideA + sideB);
    }

    public double GetArea()
    {
        return sideA * sideB;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Сторона A: " + sideA);
        Console.WriteLine("Сторона B: " + sideB);
        Console.WriteLine("Периметр: " + GetPerimeter());
        Console.WriteLine("Площа: " + GetArea());
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Практична робота №6, Таран Андрій";

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Практична робота №6 Навчальне завдання 1.");
        Console.WriteLine();

        Rectangle rect1 = new Rectangle(5, 8);

        Console.WriteLine("Інформація про один прямокутник:");
        rect1.PrintInfo();

        Console.WriteLine();

        Rectangle[] rectangles = new Rectangle[3];

        rectangles[0] = new Rectangle(4, 6);
        rectangles[1] = new Rectangle(7, 3);
        rectangles[2] = new Rectangle(10, 5);

        Console.WriteLine("Інформація про масив прямокутників:");

        double sumA = 0;
        double sumB = 0;

        for (int i = 0; i < rectangles.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Прямокутник №" + (i + 1));
            rectangles[i].PrintInfo();

            sumA += rectangles[i].GetSideA();
            sumB += rectangles[i].GetSideB();
        }

        double averageA = sumA / rectangles.Length;
        double averageB = sumB / rectangles.Length;

        Rectangle averageRectangle = new Rectangle(averageA, averageB);

        Console.WriteLine();
        Console.WriteLine("Прямокутник із середніми значеннями сторін:");
        averageRectangle.PrintInfo();
    }
}