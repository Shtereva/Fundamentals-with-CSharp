using System;


namespace Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split(' ');
            var names = Console.ReadLine().Split(' ');

            PrintPhoneBook(phoneNumbers, names);
        }

        private static void PrintPhoneBook(string[] phoneNumbers, string[] names)
        {
            do
            {
                string lines = Console.ReadLine();
                if (lines == "done") { break; }
                int possition = 0;
                for (int j = 0; j < names.Length; j++)
                {
                    if (names[j] == lines)
                    {
                        possition = j;
                    }
                }
                Console.WriteLine($"{names[possition]} -> {phoneNumbers[possition]}");

            } while (true);
        }
    }
}
