using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            minutes = minutes + 15;

            if (hour >= 0 && hour <= 23 && minutes > 0 && minutes <= 59)
            {
                Console.WriteLine("{0}:{1}", hour, minutes);
            }
            else if (hour >= 0 && hour < 23 && minutes > 59)
            {
                hour += 1;
                minutes = minutes - 60;
                if (minutes < 10)
                {
                    Console.WriteLine("{0}:0{1}", hour, minutes);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", hour, minutes);
                }
            }
            else if (hour >= 23 && minutes > 59)
            {
                minutes = minutes - 60;
                if (minutes < 10)
                {
                    Console.WriteLine("0:0{0}",minutes);
                }
                else
                {
                    Console.WriteLine("0:{0}",minutes);
                }
            }

            
            
        }
    }
}
