using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class PokeMon
    {
        static void Main()
        {
            long pokePower = long.Parse(Console.ReadLine());
            long distance = long.Parse(Console.ReadLine());
            long exhFactor = long.Parse(Console.ReadLine());

            long count = 0;
            long originalValue = pokePower;
            long perc = (originalValue * 50) / 100;


            while (true)
            {
                pokePower -= distance;
                count++;

                if (pokePower == perc)
                {
                    try
                    {
                        long division = pokePower / exhFactor;
                        pokePower = division;
                    }
                    catch (Exception e)
                    {
                        
                    }
                }

                if (pokePower < distance)
                {
                    Console.WriteLine(pokePower);
                    Console.WriteLine(count);
                    break;
                }
            }
        }
    }
}
