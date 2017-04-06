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
            int n = int.Parse(Console.ReadLine());
            int maxDiff = 0;
            int lastPairSum = 0;


            for (int i = 0; i < n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int sum = firstNumber + secondNumber;

                if (i != 0)
                {

                    if (sum != lastPairSum)
                    {
                        int diff = Math.Abs(sum - lastPairSum);

                        if (diff > maxDiff)
                            maxDiff = diff;
                    }
                }
                lastPairSum = sum;
                
            }
            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value=" + lastPairSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + maxDiff);
            }
            
        }
    } 
}
