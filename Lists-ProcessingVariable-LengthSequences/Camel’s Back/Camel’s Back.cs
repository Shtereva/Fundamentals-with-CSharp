using System;
using System.Collections.Generic;
using System.Linq;

namespace Camel_s_Back
{
    class Program
    {
        static void Main()
        {
            var building = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var size = int.Parse(Console.ReadLine());
            int rounded = 0;
            int diff = building.Count - size;
            rounded = BreakDownTheBuilding(building, rounded, diff);
        }

        private static int BreakDownTheBuilding(List<int> building, int rounded, int diff)
        {
            if (diff == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", building)}");
            }

            else
            {
                for (int i = 0; i < diff / 2; i++)
                {
                    building.RemoveAt(0);
                    building.RemoveAt(building.Count - 1);
                    rounded++;
                }

                Console.WriteLine($"{rounded} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", building)}");
            }

            return rounded;
        }
    }
}
