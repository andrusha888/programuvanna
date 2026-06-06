using System;
using System.Text;

class StackNumbers
{
    private int[] data;
    private int top;

    public StackNumbers(int size)
    {
        data = new int[size];
        top = -1;
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == data.Length - 1;
    }

    public void Push(int value)
    {
        if (IsFull())
        {
            Console.WriteLine("Стек заповнений. Неможливо додати елемент.");
            return;
        }

        top++;
        data[top] = value;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Стек порожній. Неможливо вилучити елемент.");
            return 0;
        }

        int value = data[top];
        top--;
        return value;
    }

    public void PrintStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Стек порожній.");
            return;
        }

        Console.WriteLine("Елементи стеку:");

        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(data[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Практична робота №7, Таран Андрій";

        Console.WriteLine("Виконав: Таран Андрій");
        Console.WriteLine("Практична робота №7 Навчальне завдання 1");
        Console.WriteLine();

        StackNumbers stack = new StackNumbers(5);

        stack.Push(10);
        stack.Push(25);
        stack.Push(40);

        Console.WriteLine("Після додавання елементів:");
        stack.PrintStack();

        Console.WriteLine();

        int removed = stack.Pop();

        Console.WriteLine("Вилучений елемент зі стеку: " + removed);
        Console.WriteLine();

        Console.WriteLine("Стек після вилучення:");
        stack.PrintStack();
    }
}