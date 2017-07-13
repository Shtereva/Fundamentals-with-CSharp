using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class PokemonDontGo
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            long sumRemovedElements = 0;

            while (true)
            {
                int index = int.Parse(Console.ReadLine());
                long removedElement = 0;
                if (index < 0)
                {
                    removedElement = arr.First();
                    sumRemovedElements += arr.First();
                    long lastElement = arr.Last();
                    arr.RemoveAt(0);
                    arr.Insert(0, lastElement);
                    
                }

                else if (index > arr.Count - 1)
                {
                    removedElement = arr.Last();
                    sumRemovedElements += arr.Last();
                    long firstElement = arr.First();
                    arr.RemoveAt(arr.Count - 1);
                    arr.Add(firstElement);
                }

                else
                {

                    removedElement = arr[index];
                    sumRemovedElements += removedElement;
                    arr.RemoveAt(index);
                }


                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] <= removedElement)
                    {
                        arr[i] += removedElement;
                    }

                    else
                    {
                        
                        arr[i] -=  removedElement;
                    }
                }

                if (arr.Count <= 0)
                {
                    Console.WriteLine(sumRemovedElements);
                    break;
                }
            }
        }
    }
}
