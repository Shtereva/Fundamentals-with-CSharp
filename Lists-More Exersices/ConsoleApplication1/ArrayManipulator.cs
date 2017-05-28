using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class ArrayManipulator
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split();

            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "addMany":
                        AddMany(numbers, command);
                        break;
                    case "contains":
                        CommandContains(numbers, command);
                        break;
                    case "remove":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "shift":
                        CommandShift(numbers, command);
                        break;
                    case "sumPairs":
                        SumPairs(numbers);
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void SumPairs(List<int> numbers)
        {
            bool isEven = numbers.Count % 2 == 0;

            if (isEven)
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    int sum = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    numbers.RemoveAt(i);
                    numbers.Insert(i, sum);
                }
            }

            else
            {
                for (int i = 0; i < numbers.Count - 2; i++)
                {
                    int sum = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    numbers.RemoveAt(i);
                    numbers.Insert(i, sum);
                }
            }
        }

        private static void CommandShift(List<int> numbers, string[] command)
        {
            for (int i = 0; i < int.Parse(command[1]); i++)
            {
                int temp = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Count - 1] = temp;
            }
        }

        private static void CommandContains(List<int> numbers, string[] command)
        {
            bool hasMatch = false; ;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i].Equals(int.Parse(command[1])))
                {
                    hasMatch = true;
                    Console.WriteLine(i);
                    break;
                }
            }

            if (hasMatch == false)
            {
                Console.WriteLine(-1);
            }
        }

        private static void AddMany(List<int> numbers, string[] command)
        {
            int startIndex = 2;
            for (int i = int.Parse(command[1]); i <= numbers.Count; i++)
            {
                numbers.Insert(i, int.Parse(command[startIndex]));
                startIndex++;
                if (startIndex == command.Length)
                {
                    break;
                }
            }
        }
    }
}
