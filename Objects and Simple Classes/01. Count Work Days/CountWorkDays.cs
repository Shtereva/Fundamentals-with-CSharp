using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01.Count_Work_Days
{
    class CountWorkDays
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            var startDate = new DateTime();
            startDate = DateTime.ParseExact(first, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var endDate = new DateTime();
            endDate = DateTime.ParseExact(second, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidays = new DateTime[]
            {
                new DateTime(2001, 1, 1),
                new DateTime(2001, 3, 3),
                new DateTime(2001, 5, 1),
                new DateTime(2001, 5, 6),
                new DateTime(2001, 5, 24),
                new DateTime(2001, 9, 6),
                new DateTime(2001, 9, 22),
                new DateTime(2001, 10, 1),
                new DateTime(2001, 12, 24),
                new DateTime(2001, 12, 25),
                new DateTime(2001, 12, 26),

            };
            int workingDaysCounter = 0;

            for (var i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var currentDay = i.DayOfWeek;

                bool hasMatch = false;
                hasMatch = CheckForHoliday(holidays, ref workingDaysCounter, i, hasMatch);

                if (!(currentDay.ToString() == "Saturday" || currentDay.ToString() == "Sunday" || hasMatch))
                {
                    workingDaysCounter++;
                }
            }

            Console.WriteLine(workingDaysCounter);
        }

        private static bool CheckForHoliday(DateTime[] holidays, ref int workingDaysCounter, DateTime i, bool hasMatch)
        {
            for (int j = 0; j < holidays.Length; j++)
            {
                if (holidays[j].Day.Equals(i.Day) && holidays[j].Month.Equals(i.Month))
                {
                    hasMatch = true;
                    break;
                }
            }

            return hasMatch;
        }
    }
}
