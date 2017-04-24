using System;


namespace Tetris
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string currentDirection = string.Empty;
            do
            {
                currentDirection = Console.ReadLine();
                switch (currentDirection)
                {
                    case "left":
                        CommandLeft(n);
                        break;
                    case "down":
                        CommandDown(n);
                        break;
                    case "right":
                        CommandRight(n);
                        break;
                    case "up":
                        CommandUp(n);
                        break;
                }

            } while (currentDirection != "exit");
        }

        static void CommandLeft(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine( new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }

        }

        static void CommandRight(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }

        }

        static void CommandUp(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine( new string('*', n * 3));
            }
        }

        static void CommandDown(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine( new string('*', n * 3));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            }
        }
    }
}
