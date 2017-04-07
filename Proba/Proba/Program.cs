using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                foreach (var symbol in i.ToString())
                {
                    sum += (symbol - '0');
                }
                Console.WriteLine(sum == 5 || sum == 7 || sum == 11 ? "{0} True" : "{0} False", i);
            }
        }
    }
}
    