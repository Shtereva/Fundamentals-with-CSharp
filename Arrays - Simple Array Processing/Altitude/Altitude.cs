using System;

namespace Altitude
{
    class Altitude
    {
        static void Main()
        {
            var text = Console.ReadLine().Split(' ');
            long altitude = long.Parse(text[0]);
            bool isNegative = true;
            

            for (int i = 1; i < text.Length; i += 2)
            {
                switch (text[i])
                {
                    case "up": altitude += long.Parse(text[i + 1]); break;
                    case "down": altitude -= long.Parse(text[i + 1]); break;
                }

                if (altitude <= 0)
                {
                    isNegative = false;
                    break;
                }
            }

            Console.WriteLine(isNegative ? $"got through safely. current altitude: {altitude}m" : "crashed");
        }

    }
}
