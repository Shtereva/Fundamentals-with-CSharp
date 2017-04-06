using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args) ////1 1 2 3
        {
            int n = int.Parse(Console.ReadLine());
            int fNull = 1;
            int fFirst = 1;
            int fNext = 1;
            for (int i = 2; i <= n; i++)
            {
                fNext = fNull + fFirst;
                fNull = fFirst;
                fFirst = fNext;
            }
            Console.WriteLine(fNext);
        }
    }
}
