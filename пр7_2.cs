using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void PrintStack(Stack<string> stack)
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("Стек порожній.");
            return;
        }

        Console.WriteLine("Елементи стеку:");

        foreach (string word in stack)
        {
            Console.WriteLine(word);
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Практична робота №7, Таран Андрій";

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Практична робота №7 Навчальне завдання 2.");
        Console.WriteLine();

        Stack<string> words = new Stack<string>();

        words.Push("алгоритм");
        words.Push("масив");
        words.Push("стек");
        words.Push("програма");

        Console.WriteLine("Після додавання слів:");
        PrintStack(words);

        Console.WriteLine();

        if (words.Count > 0)
        {
            string removedWord = words.Pop();

            Console.WriteLine("Вилучений елемент зі стеку: " + removedWord);
        }

        Console.WriteLine();

        Console.WriteLine("Стек після вилучення:");
        PrintStack(words);
    }
}