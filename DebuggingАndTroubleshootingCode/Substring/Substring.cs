using System;


namespace Substring
{
    class Substring
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int numberCount = int.Parse(Console.ReadLine());

            //const char letter = 'р';
            bool hasMatch = false;

            for (int i = 0; i <= text.Length - 1; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;

                    int endIndex = numberCount + 1;

                    if (endIndex >= text.Length - i)
                    {
                        endIndex = text.Length - i;
                    }
                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += numberCount;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
