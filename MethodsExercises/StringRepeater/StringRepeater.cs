using System;


namespace StringRepeater
{
    class StringRepeater
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            string repeatedString = RepeatString(text, counter);
            Console.WriteLine(repeatedString);
        }

         static string RepeatString(string text, int counter)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < counter; i++)
            {
                repeatedString += text;
            }
            return repeatedString;
        }
    }
}
