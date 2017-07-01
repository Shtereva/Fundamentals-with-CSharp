using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.Replace_a_Tag
{
    class ReplaceATag
    {
        static void Main()
        {
            var regex = new Regex(@"<a(.*)href=("".*"")>(.*)<\/a>");

            var input = Console.ReadLine();

            while (input != "end")
            {
                if (regex.IsMatch(input))
                {
                    var replacedString = @"[URL$1href=$2]$3[/URL]";
                    input = regex.Replace(input, replacedString);
                }

                Console.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    }
}
