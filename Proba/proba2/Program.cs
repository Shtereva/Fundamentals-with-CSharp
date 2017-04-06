using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int countAll = 0;
            bool noCombinations = true;
            int magicNumber = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    countAll++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", countAll, i, j, i + j);
                        noCombinations = false;
                        break;
                    }
                }
                if (noCombinations == false) { break; }
            }
            if (noCombinations)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", countAll, magicNumber);
            }
        }
    }
}
