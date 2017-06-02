using System;

class WeatherForecast
{
    static void Main()
    {
        long number = 0;
        try
        {
            number = long.Parse(Console.ReadLine());

        }
        catch (Exception)
        {

            Console.WriteLine("Rainy");
            return;
        }

        if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
        {
            Console.WriteLine("Sunny");
        }

        else if ((number >= int.MinValue && number < sbyte.MinValue) || (number > sbyte.MaxValue && number <= int.MaxValue))
        {
            Console.WriteLine("Cloudy");
        }
        else if ((number >= long.MinValue && number < int.MinValue) || (number > int.MaxValue && number <= long.MaxValue))
        {
            Console.WriteLine("Windy");
        }
    }
}
