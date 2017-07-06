using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main()
        {
            var input = Console.ReadLine();

            if (input == string.Empty || long.Parse(input) <= 0)
            {
                return;
            }
            
            var field = new long[long.Parse(input)]; 

            var indexes = Console.ReadLine()
                .Split()
                .Where(x => x.Length > 0)
                .Select(long.Parse)
                .Where(x => x >= 0 && x < field.Length)
                .Distinct()
                .ToArray();

            if (field.Length == 0)
            {
                return;
            }

            PlaceLadyBugsInTheField(field, indexes);

            string action = Console.ReadLine();

            while (action != "end")
            {
                var line = action.Split();

                var ladybugIndex = long.Parse(line[0]);
                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    action = Console.ReadLine();
                    continue;
                }
                string direction = line[1];
                var flyLenght = long.Parse(line[2]);

                if (field[ladybugIndex] == 1 && ladybugIndex >= 0 && ladybugIndex < field.Length)
                {
                    if (flyLenght == 0)
                    {
                        action = Console.ReadLine();
                        continue;
                    }

                    field[ladybugIndex] = 0;

                    ChangeDirectionWhenNegativeLenght(ref direction, ref flyLenght);

                    LadyBugFlight(field, ladybugIndex, direction, flyLenght);
                }
                action = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        private static void LadyBugFlight(long[] field, long ladybugIndex, string direction, long flyLenght)
        {
            switch (direction)
            {
                case "right":
                    for (long i = ladybugIndex; i < field.Length; i += flyLenght)
                    {
                        if (i + flyLenght <= field.Length - 1 && field[i + flyLenght] == 0)
                        {
                            field[i + flyLenght] = 1;
                            break;
                        }
                    }
                    break;

                case "left":
                    for (long i = ladybugIndex; i >= 0; i -= flyLenght)
                    {
                        if (i - flyLenght >= 0 && field[i - flyLenght] == 0)
                        {
                            field[i - flyLenght] = 1; 
                            break;
                        }
                    }
                    break;
            }
        }

        private static void PlaceLadyBugsInTheField(long[] field, long[] indexes)
        {
            for (long i = 0; i < indexes.Length; i++)
            {
                field[indexes[i]] = 1;
            }
        }

        private static void ChangeDirectionWhenNegativeLenght(ref string direction, ref long flyLenght)
        {
            if (flyLenght < 0)
            {
                switch (direction)
                {
                    case "right":
                        direction = "left";
                        flyLenght = Math.Abs(flyLenght);
                        break;
                    case "left":
                        direction = "right";
                        flyLenght = Math.Abs(flyLenght);
                        break;
                }
            }
        }
    }
}
