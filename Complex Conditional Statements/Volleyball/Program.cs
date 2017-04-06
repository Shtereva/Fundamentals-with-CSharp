using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            double sofiaWeekends = 48 - weekends;
            sofiaWeekends = sofiaWeekends * 3.00 / 4;
            double gamesHolidays = holidays * 2.0 / 3;
            double sum = sofiaWeekends + weekends + gamesHolidays;

            if (year == "leap")
            {
                var games = sum + (sum * 0.15);
                Console.WriteLine(Math.Truncate(games));
            }
            else
            {
                Console.WriteLine(Math.Truncate(sum));
            }
        }
    }
}
