using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());

            var seconds = sec1 + sec2 + sec3;
            var mins = 0;

            
             if (seconds > 59 && seconds <= 119)
            {
                mins++;
                seconds -= 60;
            }

             if (seconds > 120 && seconds <= 179)
            { 
                mins = 2;
                seconds -= 120;
            }

             if (seconds < 10)
            {
                Console.WriteLine(mins + ":" + "0" + seconds);
            }
            else
            {
                Console.WriteLine(mins + ":" + seconds);
            }
        }
    }
}
