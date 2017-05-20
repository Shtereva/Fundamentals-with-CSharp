using System;
using System.Collections.Generic;
using System.Linq;

namespace RabbitHole
{
    class RabbitHole
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Count;)
            {
                if (input[i] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                bool bombAway = false;
                var array = input[i].Split('|');
                string command = array[0];
                int possition = 0;
                if (array.Length > 1) { possition = int.Parse(array[1]); }

                ExecuteCommand(input, ref energy, ref i, ref bombAway, command, possition);

                 if (energy <= 0)
                {
                    Console.WriteLine(bombAway ? "You are dead due to bomb explosion!" : "You are tired. You can't continue the mission.");
                    break;
                }

                if (input[input.Count - 1] != "RabbitHole")
                {
                    input[input.Count - 1] = $"Bomb|{energy}";
                }

                else
                {
                    input.Add($"Bomb|{energy}");
                }
            }
        }

        private static void ExecuteCommand(List<string> input, ref int energy, ref int i, ref bool bombAway, string command, int possition)
        {
            switch (command)
            {
                case "Left":
                    i = (Math.Abs(possition - i)) % input.Count; energy -= possition;
                    break;
                case "Right":
                    i = (i + possition) % input.Count; energy -= possition;
                    break;
                case "Bomb":
                    input.RemoveAt(i); energy -= possition;
                    i = 0;
                    bombAway = true;
                    break;
            }
        }
    }
}
