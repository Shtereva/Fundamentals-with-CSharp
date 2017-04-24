using System;


namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            float timeHours = float.Parse(Console.ReadLine());
            float timeMinutes = float.Parse(Console.ReadLine());
            float timeSeconds = float.Parse(Console.ReadLine());

            float speedInMinutes = (timeHours * 60) + timeMinutes;
            float speedInSeconds = (speedInMinutes * 60) + timeSeconds;
            float speedInHours = (speedInSeconds / 60) / 60;
            Console.WriteLine("{0}", (distanceMeters / speedInSeconds));
            Console.WriteLine("{0}", (distanceMeters / 1000) / speedInHours);
            Console.WriteLine("{0}", (distanceMeters / 1609) / speedInHours);
        }
    }
}
