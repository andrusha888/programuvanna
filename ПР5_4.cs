using System;

class Program
{
    static string TranslateSeason(string season)
    {
        season = season.ToLower();

        if (season == "зима")
        {
            return "winter";
        }
        else if (season == "весна")
        {
            return "spring";
        }
        else if (season == "літо")
        {
            return "summer";
        }
        else if (season == "осінь")
        {
            return "autumn";
        }
        else
        {
            return "Такої пори року немає у списку.";
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть назву пори року українською: ");
        string season = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(season))
        {
            Console.WriteLine("Помилка введення");
            return;
        }

        string result = TranslateSeason(season);

        Console.WriteLine("Переклад: " + result);
    }
}