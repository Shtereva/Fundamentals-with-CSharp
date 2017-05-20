using System;
using System.Collections.Generic;
using System.Linq;

namespace Batteries
{
    class Batteries
    {
        static void Main()
        {
            var capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int testHours = int.Parse(Console.ReadLine());

            for (int i = 0; i < capacity.Length; i++)
            {
                bool isDead = false;
                int hour = 0;
                double originalCapacity = capacity[i];
                StresTest(capacity, usagePerHour, testHours, i, ref isDead, ref hour);
                PrintResult(ref originalCapacity, usagePerHour, i, isDead, hour, capacity);
            }
        }

        private static void PrintResult(ref double originalCapacity, double[] usagePerHour, int i, bool isDead, int hour, double[] capacity)
        {
            if (isDead)
            {
                Console.WriteLine($"Battery {i + 1}: dead (lasted {hour} hours)");
            }

            else
            {
                double percent = (capacity[i] / originalCapacity) * 100;
                Console.WriteLine($"Battery {i + 1}: {capacity[i]:f2} mAh ({percent:f2})%");
            }
        }

        private static void StresTest(double[] capacity, double[] usagePerHour, int testHours, int i, ref bool isDead, ref int hour)
        {
            for (int j = 1; j <= testHours; j++)
            {
                capacity[i] -= usagePerHour[i];
                if (capacity[i] <= 0)
                {
                    hour = j;
                    isDead = true;
                    break;
                }
            }
        }
    }
}
