using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Mixed_Phones
{
    class MixedPhones
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', ':'}, StringSplitOptions.RemoveEmptyEntries);
            var phoneBook = new SortedDictionary<string, long>();

            while (input[0] != "Over")
            {
                FixThePhoneBook(input, phoneBook);
                input = Console.ReadLine().Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            PrintPhoneBook(phoneBook);
        }

        private static void PrintPhoneBook(SortedDictionary<string, long> phoneBook)
        {
            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static void FixThePhoneBook(string[] input, SortedDictionary<string, long> phoneBook)
        {
            long number = 0;
            bool isNumber = long.TryParse(input[0], out number);

            if (isNumber)
            {
                phoneBook.Add(input[1], number);
            }

            else
            {
                phoneBook.Add(input[0], long.Parse(input[1]));
            }
        }
    }
}
