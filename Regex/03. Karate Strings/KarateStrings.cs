using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Karate_Strings
{
    class KarateStrings
    {
        static void Main()
        {
            var path = Console.ReadLine();
            int power = 0;

            for (int i = 0; i < path.Length; i++)
            { 
                if (path[i] == '>')
                {
                    power = int.Parse(path[i + 1].ToString()) + power;
                    i++;

                    while (power > 0)
                    {
                        if (i < path.Length && path[i] == '>')
                        {
                            break;
                        }
                        try
                        {
                            path = path.Remove(i, 1);
                        }
                        catch (Exception e)
                        {
                        }
                        
                        power--;
                    }

                    i--;
                }
            }

            Console.WriteLine(path);
        }
    }
}
