using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("$");
                for (int c = 1; c <i ; c++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
