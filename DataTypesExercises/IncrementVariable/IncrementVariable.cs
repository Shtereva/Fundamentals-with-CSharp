using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int incrementation = int.Parse(Console.ReadLine());
            byte variable = 0;
            int counter = 0;
            for (int i = 0; i < incrementation; i++)
            {
                variable++;
                if (variable == 0) { counter++; }
            }
            Console.WriteLine(variable );
            Console.WriteLine($"Overflowed {counter} times");
        }
    }
}
