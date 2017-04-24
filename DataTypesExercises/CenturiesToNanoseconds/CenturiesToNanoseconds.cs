using System;
using System.Numerics;


namespace CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main()
        {
            decimal centuries = decimal.Parse(Console.ReadLine());
            decimal years = centuries * 100;
            ulong days = (ulong)(years * 365.242M);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");


        }
    }
}
