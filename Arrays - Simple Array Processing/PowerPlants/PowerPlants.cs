using System;
using System.Linq;

namespace PowerPlants
{
    class PowerPlants
    {
        static void Main()
        {
            var powerLevel = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int currentDay = 0;
            long days = 0;
            long seasons = 0;
            bool notZero = false;
            while (powerLevel.Sum() > 0)
            {
                for (int i = 0; i < powerLevel.Length; i++)
                {
                    if (powerLevel[i] != 0)
                    {
                        powerLevel[i] -= 1;
                        notZero = true;
                    }
                   
                    if (i == currentDay && notZero)
                    {
                        powerLevel[i]++;
                    }

                    if (currentDay == powerLevel.Length - 1 && powerLevel.Sum() > 0 && i == currentDay)
                    {
                        for (int j = 0; j < powerLevel.Length; j++)
                        {
                            if (powerLevel[j] > 0)
                            {
                                powerLevel[j]++;
                            }
                        }
                       
                        seasons++;
                        currentDay = -1;
                    }

                    notZero = false;
                }
                days++;
                currentDay++;
            }

            Console.WriteLine("survived {0} days ({1} seasons)", days, seasons);
        }
    }
}
