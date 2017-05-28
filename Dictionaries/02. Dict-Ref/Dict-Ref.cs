using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var reference = new Dictionary<string, int>();

            while (input[0] != "end")
            {
                string text = input[0];
                int number = 0;
                bool paresed = int.TryParse(input[1], out number);
                if (paresed)
                {
                    AddingElementsToDictionary(reference, text, number);

                }

                else
                {
                    if (reference.ContainsKey(input[1]))
                    {
                        int value = 0;
                        bool getValue = reference.TryGetValue(input[1], out value);
                        AddingElementsToDictionary(reference, text, value);
                    }

                    else
                    {
                        input = Console.ReadLine().Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        continue;
                    }
                }

                input = Console.ReadLine().Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var item in reference)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }

        private static void AddingElementsToDictionary(Dictionary<string, int> reference, string text, int number)
        {
            if (!reference.ContainsKey(text))
            {
                reference.Add(text, number);
            }

            else
            {
                reference[text] = number;
            }
        }
    }
}
