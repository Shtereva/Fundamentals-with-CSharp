using System;

namespace CountOfCapitalLettersInArray
{
    class CountOfCapitalLettersInArray
    {
        static void Main()
        {
            var text = Console.ReadLine().Split(' ');
            int count = 0;

            foreach (var item in text)
            {
                char chars = ' ';
                bool isChar = char.TryParse(item, out chars);
                if (isChar && chars >= 65 && chars <= 90)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
