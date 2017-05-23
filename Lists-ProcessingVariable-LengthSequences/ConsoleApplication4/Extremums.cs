using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication4
{
    class Extremums
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine().ToLower();
            var result = new List<int>();
            long sum = 0;
            ProccessingList(numbers, command);
            sum = SumNumbers(numbers, sum);

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(sum);
        }

        private static long SumNumbers(List<int> numbers, long sum)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static void ProccessingList(List<int> numbers, string command)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                var rotatedLeft = new List<int>();
                int max = 0;
                max = RotateLeft(numbers, i, rotatedLeft, max);

                var rotatedRight = new List<int>();
                int min = 0;
                min = RotateRight(numbers, i, rotatedRight, min);

                switch (command)
                {
                    case "max":
                        if (max > numbers[i])
                        {
                            numbers[i] = max;
                        }
                        break;
                    case "min":
                        if (min < numbers[i])
                        {
                            numbers[i] = min;
                        }
                        break;
                }

            }
        }

        private static int RotateRight(List<int> numbers, int i, List<int> rotatedRight, int min)
        {
            string variable = numbers[i].ToString();
            for (int j = 0; j < variable.Length; j++)
            {
                rotatedRight.Add(int.Parse(variable[j].ToString()));
            }

             min = int.MaxValue;

            for (int j = 0; j < rotatedRight.Count; j++)
            {
                int temp = rotatedRight[rotatedRight.Count - 1];
                rotatedRight.RemoveAt(rotatedRight.Count - 1);
                rotatedRight.Insert(0, temp);

                string compare = string.Empty;
                compare = Parsing(rotatedRight, compare);

                if (int.Parse(compare) < min)
                {
                    min = int.Parse(compare);
                }
            }
            return min;
        }

        private static string Parsing(List<int> rotatedRight, string compare)
        {
            for (int k = 0; k < rotatedRight.Count; k++)
            {
                compare += rotatedRight[k];
            }

            return compare;
        }


        private static int RotateLeft(List<int> numbers, int i, List<int> rotatedLeft, int max)
        {
            string variable = numbers[i].ToString();
            for (int j = 0; j < variable.Length; j++)
            {
                rotatedLeft.Add(int.Parse(variable[j].ToString()));
            }

             max = int.MinValue;

            for (int j = 0; j < rotatedLeft.Count; j++)
            {
                int temp = rotatedLeft[0];
                rotatedLeft.RemoveAt(0);
                rotatedLeft.Add(temp);

                string compare = string.Empty;
                compare = Pars(rotatedLeft, compare);

                if (int.Parse(compare) > max)
                {
                    max = int.Parse(compare);
                }
            }
            return max;
        }

        private static string Pars(List<int> rotatedLeft, string compare)
        {
            for (int k = 0; k < rotatedLeft.Count; k++)
            {
                compare += rotatedLeft[k];
            }

            return compare;
        }
    }
}
