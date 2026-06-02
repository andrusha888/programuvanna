using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть кількість поїздок: ");
        bool ok = int.TryParse(Console.ReadLine(), out int n);

        if (!ok || n <= 0)
        {
            Console.WriteLine("Помилка введення");
            return;
        }

        int bestCost = int.MaxValue;
        int bestTrips = 0;

        int best1 = 0;
        int best23 = 0;
        int best62 = 0;

        for (int ticket62 = 0; ticket62 <= n / 62 + 2; ticket62++)
        {
            for (int ticket23 = 0; ticket23 <= n / 23 + 3; ticket23++)
            {
                int trips = ticket62 * 62 + ticket23 * 23;

                int ticket1 = 0;

                if (trips < n)
                {
                    ticket1 = n - trips;
                }

                int totalTrips = trips + ticket1;
                int cost = ticket62 * 390 + ticket23 * 145 + ticket1 * 8;

                if (cost < bestCost || (cost == bestCost && totalTrips > bestTrips))
                {
                    bestCost = cost;
                    bestTrips = totalTrips;
                    best1 = ticket1;
                    best23 = ticket23;
                    best62 = ticket62;
                }
            }
        }

        Console.WriteLine("Квитків на 1 поїздку: " + best1);
        Console.WriteLine("Квитків на 23 поїздки: " + best23);
        Console.WriteLine("Квитків на 62 поїздки: " + best62);
        Console.WriteLine("Всього поїздок: " + bestTrips);
        Console.WriteLine("Загальна ціна: " + bestCost + " грн");
    }
}