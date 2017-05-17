using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootListElements
{
    class ShootListElements
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var output = new List<int>();
            bool endProgram = false;
            int lastRemovedInt = 0;

            while (input != "stop")
            {
                int digit = 0;
                bool isInteger = int.TryParse(input, out digit);
                CheckInputType(ref digit, ref isInteger, output, input, ref endProgram, ref lastRemovedInt);
                if (endProgram) { break; }
                input = Console.ReadLine();
            }

            PrintFinalResult(input, output, lastRemovedInt);
        }

        private static void PrintFinalResult(string input, List<int> output, int lastRemovedInt)
        {
            if (input == "stop")
            {
                if (output.Count > 0)
                {
                    Console.WriteLine($"survivors: {string.Join(" ", output)}");
                }

                else
                {
                    Console.WriteLine($"you shot them all. last one was {lastRemovedInt}");
                }
            }
        }

        private static void CheckInputType(ref int digit, ref bool isInteger, List<int> output, string input, ref bool endProgram, ref int lastRemovedInt)
        {
            if (isInteger)
            {
                output.Insert(0, digit);
            }

            else if (input == "bang")
            {
                double averageSum = AverageSum(output);
                
                RemoveSmalerElement(output, averageSum,ref lastRemovedInt, ref endProgram);
            }
        }

        private static void RemoveSmalerElement(List<int> output, double averageSum, ref int lastRemovedInt, ref bool endProgram)
        {
            int element = 0;
            if (output.Count > 0)
            {
                ProcessingList(output, averageSum, ref lastRemovedInt, ref element);
            }

            else
            {
                Console.WriteLine($"nobody left to shoot! last one was {lastRemovedInt}");
                endProgram = true;
            }
        }

        private static void ProcessingList(List<int> output, double averageSum, ref int lastRemovedInt, ref int element)
        {
            for (int i = 0; i < output.Count; i++)
            {
                if (output[i] < averageSum || output.Count == 1)
                {
                    lastRemovedInt = output[i];
                    element = output[i];
                    output.RemoveAt(i);
                    Console.WriteLine($"shot {element}");
                    if (output.Count > 0)
                    {
                        for (int j = 0; j < output.Count; j++)
                        {
                            output[j]--;
                        }
                    }
                    break;
                }
            }
        }

        private static double AverageSum(List<int> output)
        {
            double averageSum = 0;
            int countDigits = 0;
            for (int i = 0; i < output.Count; i++)
            {
                averageSum += output[i];
                countDigits++;
            }

           return averageSum /= countDigits;
        }
    }
}
