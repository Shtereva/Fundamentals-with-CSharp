using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Command_Interpreter
{
    class CommandInterpreter
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            var commands = Console.ReadLine();

            while (commands != "end")
            {
                var line = commands.Split();
                string command = line.First();
                bool invalid = false;

                switch (command)
                {
                    case "reverse":
                        {
                            long startIndex = long.Parse(line[2]);
                            long count = long.Parse(line[4]);

                            CheckForInvalidInput(arr, startIndex, count, ref invalid);
                            if (invalid)
                            {
                                commands = Console.ReadLine();
                                continue;
                            }
                            var temp = arr.Skip((int)startIndex).Take((int)count).Reverse().ToList();
                            arr.RemoveRange((int)startIndex, (int)count);
                            arr.InsertRange((int)startIndex, temp);
                        }
                        break;
                    case "sort":
                        {
                            long startIndex = long.Parse(line[2]);
                            long count = long.Parse(line[4]);

                            CheckForInvalidInput(arr, startIndex, count, ref invalid);
                            if (invalid)
                            {
                                commands = Console.ReadLine();
                                continue;
                            }

                            var temp = arr.Skip((int)startIndex).Take((int)count).OrderBy(x => x).ToList();
                            // temp.Sort();
                            arr.RemoveRange((int)startIndex, (int)count);
                            arr.InsertRange((int)startIndex, temp);
                        }
                        break;
                    case "rollLeft":
                        {
                            long count = long.Parse(line[1]);
                            if (count < 0)
                            {
                                Console.WriteLine("Invalid input parameters.");
                                commands = Console.ReadLine();
                                continue;
                            }
                            RollLeft(arr, count);
                        }
                        break;
                    case "rollRight":
                        {
                            long count = long.Parse(line[1]);
                            if (count < 0)
                            {
                                Console.WriteLine("Invalid input parameters.");
                                commands = Console.ReadLine();
                                continue;
                            }
                            RollRight(arr, count);
                        }
                        break;
                }
                commands = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static void RollLeft(List<string> arr, long count)
        {
            var temp = new List<string>(arr);

            for (int i = 0; i < arr.Count; i++)
            { 
                long index = (i + arr.Count - count) % arr.Count;
                if (index < 0)
                {
                    index += arr.Count;
                }
                arr[(int)index] = temp[i];
            }
        }

        private static void RollRight(List<string> arr, long count)
        {
            var temp = new List<string>(arr);

            for (int i = 0; i < arr.Count; i++)
            {
                long index = (i + count) % arr.Count;
                arr[(int)index] = temp[i];
            }
        }

        private static void CheckForInvalidInput(List<string> arr, long startIndex, long count, ref bool invalid)
        {
            if ((startIndex < 0 || startIndex >= arr.Count) || (count < 0 || count + startIndex - 1 > arr.Count - 1))
            {
                Console.WriteLine("Invalid input parameters.");
                invalid = true;

            }
        }
    }
}
