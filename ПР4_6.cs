using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string[,] users = new string[,]
        {
            { "admin", "12345" },
            { "andriy", "1111" },
            { "user", "password" },
            { "student", "2026" }
        };

        Console.Write("Введіть логін: ");
        string login = Console.ReadLine();

        Console.Write("Введіть пароль: ");
        string password = Console.ReadLine();

        bool found = false;
        bool isAdmin = false;

        for (int i = 0; i < users.GetLength(0); i++)
        {
            if (login == users[i, 0] && password == users[i, 1])
            {
                found = true;

                if (login == "admin")
                {
                    isAdmin = true;
                }

                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Welcome");

            if (isAdmin)
            {
                Console.WriteLine("Інформація про користувачів:");

                for (int i = 0; i < users.GetLength(0); i++)
                {
                    Console.WriteLine("Логін: " + users[i, 0] + ", пароль: " + users[i, 1]);
                }
            }
        }
        else
        {
            Console.WriteLine("Goodbye");
        }
    }
}