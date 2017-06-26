using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Nilapdromes
{
    class Nilapdromes
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string border = string.Empty;
                int lastIndex = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    var compared = input.LastIndexOf(input.Substring(0, i + 1));
                    if (compared > i)
                    {
                        if (input.Substring(0, i + 1).CompareTo(input.Substring(compared)) == 0)
                        {
                            border = input.Substring(0, i + 1);
                            lastIndex = compared;
                        }
                    }

                    else
                    {
                        break;
                    }
                }

                if (border.CompareTo(input.Substring(lastIndex)) == 0)
                {
                    input = input.Remove(lastIndex).Substring(border.Length);
                    if (input != string.Empty)
                    {
                        Console.WriteLine($"{input}{border}{input}");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
