using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Magic_exchangeable_words
{
    class MagicExchangeableWords
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            bool isReplacable = true;

            var str1 = input[0].ToCharArray();
            var str2 = input[1].ToCharArray();

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = i + 1; j < str1.Length; j++)
                {
                    if (j >= str2.Length)
                    {
                        var letters = str1.Skip(str2.Length).ToArray();
                        str1 = str1.Take(str2.Length).ToArray();

                        for (int k = 0; k < letters.Length; k++)
                        {
                            if (!str1.Contains(letters[k]))
                            {
                                Console.WriteLine("false");
                                return;
                            }
                        }

                        if (isReplacable)
                        {
                            Console.WriteLine("true");
                            return;
                        }
                    }
                    CheckPattern(ref isReplacable, str1, str2, i, j);

                    if (!isReplacable)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            if (str1.Length < str2.Length)
            {
                var letters = str2.Skip(str1.Length).ToArray();
                str2 = str2.Take(str1.Length).ToArray();

                for (int i = 0; i < letters.Length; i++)
                {
                    if (!str2.Contains(letters[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
            Console.WriteLine("true");
        }

        private static void CheckPattern(ref bool isReplacable, char[] str1, char[] str2, int i, int j)
        {
            if (str1[i] == str1[j])
            {
                if (str2[i] != str2[j])
                {
                    isReplacable = false;
                }
            }

            else
            {
                if (str2[i] == str2[j])
                {
                    isReplacable = false;
                }
            }

        }
    }
}
