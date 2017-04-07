using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int specialNum = 0;
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int oldNum = i;
                while (true)
                {
                    int lastNum = oldNum % 10;
                    sum += lastNum;
                    int leftNum = oldNum / 10;
                    oldNum = leftNum;
                    if (oldNum == 0) { break; }
                }
                if (sum == 5 || sum == 7 || sum == 11) { specialNum = i; Console.WriteLine("{0} -> True", i); }
                else { Console.WriteLine("{0} -> False", i); }
            }
           
        }
    }
}
