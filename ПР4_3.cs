using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть слово: ");
        string word = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(word))
        {
            Console.WriteLine("Помилка: слово не може бути порожнім.");
            return;
        }

        Console.WriteLine("Слово у зворотному порядку:");

        for (int i = word.Length - 1; i >= 0; i--)
        {
            Console.Write(word[i]);
        }

        Console.WriteLine();
        Console.WriteLine("Слово із символом * після кожної літери:");

        foreach (char letter in word)
        {
            Console.Write(letter + "*");
        }
    }
}