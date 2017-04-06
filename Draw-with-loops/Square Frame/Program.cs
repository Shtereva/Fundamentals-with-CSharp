using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                Console.Write("+");
                for (int c = 1; c <= n - 2; c++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            for (int i = 1; i <= n - 2 ; i++)
            {
                Console.Write("|");
                for (int c = 1; c <= n - 2 ; c++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
                Console.Write("+");
                for (int c = 1; c <= n - 2; c++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
        }
    }
}
