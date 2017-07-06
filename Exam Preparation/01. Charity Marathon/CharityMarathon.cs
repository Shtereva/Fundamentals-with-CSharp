using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Charity_Marathon
{
    class CharityMarathon
    {
        static void Main()
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long trackLenght = long.Parse(Console.ReadLine());
            long capacity = long.Parse(Console.ReadLine());
            decimal donationPerKm = decimal.Parse(Console.ReadLine());

            long totalCapacity = days * capacity;

            if (runners > totalCapacity)
            {
                runners = totalCapacity;
            }

            long totalMeters = runners * laps * trackLenght;
            long totalKilometers = totalMeters / 1000;

            decimal moneyRaised = totalKilometers * donationPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
