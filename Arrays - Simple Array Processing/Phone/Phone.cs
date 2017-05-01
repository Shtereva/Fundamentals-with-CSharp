using System;
using System.Linq;

namespace Phone
{
    class Phone
    {
        static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split(' ');
            var names = Console.ReadLine().Split(' ');

            while (true)
            {
                var command = Console.ReadLine().Split(' ');
                if (command[0].Equals("done")) { break; }

                if (command[0].Equals("call"))
                {
                    CommandCall(phoneNumbers, names, command);
                }
            }
        }

        private static void CommandCall(string[] phoneNumbers, string[] names, string[] command)
        {
            int phones = 0;
            bool phone = int.TryParse(command[1].Trim('+', '(', ')'), out phones);
            if (phone == true)
            {
                for (int i = 0; i < phoneNumbers.Length; i++)
                {
                    if (phoneNumbers[i] == command[1])
                    {
                        Console.WriteLine($"calling {names[i]}...");
                        break;
                    }
                }
               int sumDigits = SumOfDigits(command);
                if (sumDigits % 2 == 0)
                {
                    Console.Write("call ended. duration: ");
                    PrintDuration(sumDigits);
                }
                else
                {
                    Console.WriteLine("no answer");
                }
            }
        }

        private static void PrintDuration(int sumDigits)
        {
            var timeSpan = TimeSpan.FromSeconds(sumDigits);
            Console.WriteLine(timeSpan.ToString(@"mm\:ss"));
            
        }

        private static int SumOfDigits(string[] command)
        {
            string digits = command[1].Trim('+', '(', ')');
            int phone = 0;
            for (int i = 0; i < digits.Length; i++)
            {
               phone += int.Parse(digits[i].ToString());
            }
            return phone;
        }
    }
}
