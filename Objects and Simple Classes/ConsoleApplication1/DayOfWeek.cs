using System;
using System.Globalization;

class DayOfWeek
{
    static void Main()
    {

        var dateAsString = Console.ReadLine();
        var date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(date.DayOfWeek);
    }
}

