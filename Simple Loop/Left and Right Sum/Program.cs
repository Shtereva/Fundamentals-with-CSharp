using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = 0;
            var num2 = 0;

            for (int i = 0; i < n; i++)
            {
                 num = num + int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < n; i++)
            {
                 num2 = num2 +  int.Parse(Console.ReadLine());
                
            }

                if (num == num2)
                {
                    Console.WriteLine("Yes, sum =  " + num);
                }
                else
                {
                    Console.WriteLine("No, Diff = " + Math.Abs(num - num2));
                }
            
        }
    }
}
