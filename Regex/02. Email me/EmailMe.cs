using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Email_me
{
    class EmailMe
    {
        static void Main()
        {
            var email = Regex.Split(Console.ReadLine(), "@").ToArray();

            var sum = email[0].ToCharArray().Select(x => (int)x).Sum() - email[1].ToCharArray().Select(x => (int)x).Sum();

            Console.WriteLine(sum >= 0 ? "Call her!" : "She is not the one.");
        }
    }
}
