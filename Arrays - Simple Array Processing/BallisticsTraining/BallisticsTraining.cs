using System;
using System.Linq;

namespace BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main()
        {
            var coordinates = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long targetX = coordinates[0];
            long targetY = coordinates[1];
            var commands = Console.ReadLine().Split(' ');
            long x = 0;
            long y = 0;

            for (int i = 0; i < commands.Length; i += 2)
            {
                switch (commands[i])
                {
                    case "up": y += long.Parse(commands[i + 1]); ; break;
                    case "down": y -= long.Parse(commands[i + 1]); break;
                    case "left": x -= long.Parse(commands[i + 1]); break;
                    case "right": x += long.Parse(commands[i + 1]); break;
                }
            }

            Console.WriteLine("firing at [{0}, {1}]", x, y);
            Console.WriteLine(targetX == x && targetY == y ? "got 'em!" : "better luck next time...");
        }
    }
}
