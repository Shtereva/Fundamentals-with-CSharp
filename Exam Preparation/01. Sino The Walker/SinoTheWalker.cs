using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _01.Sino_The_Walker
{
    class SinoTheWalker
    {
        static void Main()
        {
            var time = TimeSpan.Parse(Console.ReadLine());
            ulong steps = ulong.Parse(Console.ReadLine());
            ulong secondsForStep = ulong.Parse(Console.ReadLine());

            ulong totalSeconds = (ulong)(time.TotalSeconds) + steps * secondsForStep;
            ulong hours = (totalSeconds / 3600) % 24;
            totalSeconds %= 3600;
            ulong minutes = (totalSeconds / 60) % 60;
            ulong seconds = totalSeconds % 60;

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
