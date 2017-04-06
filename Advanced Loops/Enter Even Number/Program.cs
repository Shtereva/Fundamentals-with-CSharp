using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
                int num = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        num = n;
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
               
            catch (OverflowException)
                {
                    Console.WriteLine("Invalid number!");
                }
               catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("Even number entered: " + num);
        }
    }
}
    