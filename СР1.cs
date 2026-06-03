using System;
using System.Text;

class Program
{
    static bool CanMakeWord(string firstWord, string secondWord)
    {
        firstWord = firstWord.ToLower();
        secondWord = secondWord.ToLower();

        for (int i = 0; i < secondWord.Length; i++)
        {
            char letter = secondWord[i];

            if (!firstWord.Contains(letter))
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Самостійна робота №1, Таран Андрій";

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Самостійна робота №1 Варіант 15");
        Console.WriteLine();

        Console.Write("Введіть перше слово: ");
        string firstWord = Console.ReadLine();

        Console.Write("Введіть друге слово: ");
        string secondWord = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(firstWord) || string.IsNullOrWhiteSpace(secondWord))
        {
            Console.WriteLine("Помилка. Слова не можуть бути порожніми.");
            return;
        }

        bool result = CanMakeWord(firstWord, secondWord);

        Console.WriteLine();

        if (result)
        {
            Console.WriteLine("З букв першого слова можна скласти друге слово.");
        }
        else
        {
            Console.WriteLine("З букв першого слова не можна скласти друге слово.");
        }
    }
}