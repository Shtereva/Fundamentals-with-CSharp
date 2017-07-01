using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    class ExtractEmails
    {
        static void Main()
        {
            var text = Console.ReadLine();

            var regex = new Regex(@"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)");

            regex.Matches(text)
                .Cast<Match>()
                .Select(x => x.Value)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
