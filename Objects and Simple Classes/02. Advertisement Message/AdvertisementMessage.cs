using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Advertisement_Message
{
    class AdvertisementMessage
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var phrases = new List<string>()
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."
            };

            var events = new List<string>()
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            var authors = new List<string>()
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            var towns = new List<string>()
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            var random = new Random();

            for (int i = 0; i < n; i++)
            {
                var phraseIndex = random.Next(0, phrases.Count);
                var eventIndex = random.Next(0, events.Count);
                var authorIndex = random.Next(0, authors.Count);
                var townIndex = random.Next(0, towns.Count);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} {towns[townIndex]}");
            }
        }
    }
}
