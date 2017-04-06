using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            var bonus1 = 5;
            var bonus2 = score * 0.20;
            var bonus3 = score * 0.10;

            if (score <= 100 && score % 2 == 0)
            {
                Console.WriteLine(bonus1 + 1);
                Console.WriteLine((bonus1 + 1) + score);
            }
            else if (score <= 100 && score % 5 == 0)
            {
                Console.WriteLine(bonus1 + 2);
                Console.WriteLine((bonus1 + 2) + score);
            }
            else if(score <= 100)
            {
                Console.WriteLine(bonus1);
                Console.WriteLine(bonus1 + score);
            }

            if (score > 100 && score < 1000 && score % 2 == 0)
            {
                Console.WriteLine(bonus2 + 1);
                Console.WriteLine((bonus2 + 1) + score);
            }
            else if (score > 100 && score < 1000 && score % 5 == 0)
            {
                Console.WriteLine(bonus2 + 2);
                Console.WriteLine((bonus2 + 2) + score);
            }
            else if (score > 100 && score < 1000)
            {
                Console.WriteLine(bonus2);
                Console.WriteLine(bonus2 + score);
            }

            if (score >= 1000 && score % 2 == 0)
            {
                Console.WriteLine(bonus3 + 1);
                Console.WriteLine((bonus3 + 1) + score);
            }
            else if (score >= 1000 && score % 5 == 0)
            {
                Console.WriteLine(bonus3 + 2);
                Console.WriteLine((bonus3 + 2) + score);
            }
            else if (score >= 1000)
            {
                Console.WriteLine(bonus3);
                Console.WriteLine(bonus3 + score);
            }
        }
    }
}
