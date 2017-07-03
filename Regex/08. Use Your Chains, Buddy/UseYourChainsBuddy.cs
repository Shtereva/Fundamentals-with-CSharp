using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Use_Your_Chains__Buddy
{
    class UseYourChainsBuddy
    {
        static void Main()
        {
            var matches = Regex.Matches(Console.ReadLine(), @"<p>(?<message>.+?)<\/p>");

            string letters = ReplaceSymbols(matches);
            letters = DecryptLetters(letters);

            Console.WriteLine(letters);
        }

        private static string DecryptLetters(string letters)
        {
            var decrypted = letters.ToCharArray();

            for (int i = 0; i < decrypted.Length; i++)
            {
                if (decrypted[i] >= 97 && decrypted[i] <= 109)
                {
                    decrypted[i] = (char)(decrypted[i] + 13);
                }

                else if (decrypted[i] >= 110 && decrypted[i] <= 122)
                {
                    decrypted[i] = (char)(decrypted[i] - 13);
                }
            }

            var result = new string(decrypted);  
            result = Regex.Replace(result, @"\s+", " ");
            return result;
        }

        private static string ReplaceSymbols(MatchCollection matches)
        {
            string temp = string.Empty;
            foreach (Match match in matches)
            {
                temp += Regex.Replace(match.Groups["message"].Value, @"[^a-z\d]", " ");
            }
            return temp;
        }
    }
}
