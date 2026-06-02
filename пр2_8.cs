using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть швидкість V: ");
        bool okV = int.TryParse(Console.ReadLine(), out int v);

        Console.Write("Введіть час T: ");
        bool okT = int.TryParse(Console.ReadLine(), out int t);

        if (!okV || !okT)
        {
            Console.WriteLine("Помилка введення");
            return;
        }

        if (t < 0)
        {
            Console.WriteLine("Час не може бути від’ємним");
            return;
        }

        int position = (v * t) % 109;

        if (position < 0)
        {
            position = position + 109;
        }

        Console.WriteLine("Мотоцикліст зупиниться на позначці: " + position);
    }
}