using System;
using System.Globalization;


namespace TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main()
        {
            long totalPictures = long.Parse(Console.ReadLine());
            long timeForFiltering = long.Parse(Console.ReadLine());
            long filterFactorPercent = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            double filteredPictures = (totalPictures / 100.00) * filterFactorPercent;
            filteredPictures = Math.Ceiling(filteredPictures);
            long filtering = totalPictures * timeForFiltering;
            long uploading = (long)filteredPictures * uploadTime;
            long totalTime = filtering + uploading;

            var timeSpan =  TimeSpan.FromSeconds(totalTime);
            Console.WriteLine(timeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
