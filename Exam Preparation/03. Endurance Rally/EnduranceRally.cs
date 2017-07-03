using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Endurance_Rally
{
    class EnduranceRally
    {
        static void Main()
        {
            var drivers = Console.ReadLine()
                .Split()
                .Distinct()
                .ToArray();

            var zoneFuel = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var checkpoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0 && x <= zoneFuel.Length - 1)
                .Distinct()
                .ToArray();

            var result = new Dictionary<string, string>();

            foreach (var driver in drivers)
            {
                result[driver] = string.Empty;
            }

            foreach (var driver in drivers)
            {
                double fuel = driver.ToCharArray().First();
                bool endGame = false;

                CalculateFuel(ref fuel, ref endGame, zoneFuel, checkpoints, result, driver);

                if (!endGame)
                {
                    result[driver] = $"{driver} - fuel left {fuel:f2}";
                }
            }

            result
                .ToList()
                .ForEach(x => Console.WriteLine(x.Value));
        }

        private static void CalculateFuel(ref double fuel, ref bool endGame, double[] zoneFuel, int[] checkpoints, Dictionary<string, string> result, string driver)
        {
            for (int i = 0; i < zoneFuel.Length; i++)
            {
                if (checkpoints.Contains(i))
                {
                    fuel += zoneFuel[i];
                }

                else
                {
                    fuel -= zoneFuel[i];
                }

                if (fuel <= 0)
                {
                    result[driver] = $"{driver} - reached {i}";
                    endGame = true;
                    return;
                }
            }
        }
    }
}
