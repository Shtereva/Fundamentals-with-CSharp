using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            if (n % 2 == 0) { stars++; }
            for (int i = 1; i <= (n + 1)/2; i++)
            {
                int padding = (n - stars) / 2;
                Console.Write(new string('-', padding));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', padding));
                stars += 2;
                Console.WriteLine();
            }
            for (int i = 1; i <= n/2 ; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
