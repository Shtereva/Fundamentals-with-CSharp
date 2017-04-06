using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n - row ; col++)
                {
                        num1 = row + col + 1;
                        Console.Write(num1 + " ");
                }
                for (int i = 1; i <= row; i++)
                {
                    int num2 = num1;
                    Console.Write((num2 - i) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
