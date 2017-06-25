using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Serialize_String
{
    class SerializeString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var result = new StringBuilder();

            var comparison = input.Distinct().ToArray();

            for (int i = 0; i < comparison.Length; i++)
            {
                string character = comparison[i].ToString();
                string indexes = character + ":";
                int index = -1;

                while (true)
                {
                    index = input.IndexOf(character, index + 1);

                    if (index >= 0)
                    {
                        indexes += index.ToString() + "/";
                    }

                    else
                    {
                        break;
                    }
                }

                indexes = indexes.TrimEnd('/');
                result.AppendLine(indexes);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
