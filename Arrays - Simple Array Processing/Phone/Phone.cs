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
            var namesToPhoneNumber = string.Empty.Split(' ');
            var command = Console.ReadLine().Split(' ');

            while (!command[0].Equals("done"))
            {
                if (command[0].Equals("call"))
                {
                    CommandCall(phoneNumbers, names, command, namesToPhoneNumber);
                }

                if (command[0].Equals("message"))
                {
                    CommandMessage(phoneNumbers, names, command, namesToPhoneNumber);
                }

                command = Console.ReadLine().Split(' ');
            }
        }

        private static void CommandMessage(string[] phoneNumbers, string[] names, string[] command, string[] namesToPhoneNumber)
        {
            long phones = 0;
            bool phone = long.TryParse(string.Join("", command[1].Split('+', '(', ')', '-')), out phones);
            if (phone == true)
            {
                for (int i = 0; i < phoneNumbers.Length; i++)
                {
                    if (phoneNumbers[i] == command[1])
                    {
                        Console.WriteLine($"sending sms to {names[i]}...");
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == command[1])
                    {
                        namesToPhoneNumber[0] = phoneNumbers[i];
                        Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                        break;
                    }
                }
            }

            int digitsDifference = Difference(phoneNumbers, names, command, namesToPhoneNumber, phone);
            if (Math.Abs(digitsDifference) % 2 != 0) { Console.WriteLine("busy"); }
            else { Console.WriteLine("meet me there"); }
        }

        private static int Difference(string[] phoneNumbers, string[] names, string[] command, string[] namesToPhoneNumber, bool phone)
        {
            if (phone == true)
            {
                string digits = string.Join("", command[1].Split('+', '(', ')', '-'));
                int phones = 0;
                for (int i = 0; i < digits.Length; i++)
                {
                    phones -= int.Parse(digits[i].ToString());
                }
                return phones;
            }
            string digitsFromName = string.Join("", namesToPhoneNumber[0].Split('+', '(', ')', '-'));
            int numbers = 0;
            for (int i = 0; i < digitsFromName.Length; i++)
            {
                numbers = Math.Abs(numbers - int.Parse(digitsFromName[i].ToString()));
            }
            return numbers;
        }

        private static void CommandCall(string[] phoneNumbers, string[] names, string[] command, string[] namesToPhoneNumber)
        {
            long phones = 0;
            bool phone = long.TryParse(string.Join("", command[1].Split('+', '(', ')', '-')), out phones);
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
            }
            else
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == command[1])
                    {
                        namesToPhoneNumber[0] = phoneNumbers[i];
                        Console.WriteLine($"calling {phoneNumbers[i]}...");
                        break;
                    }
                }
            }
                
               int sumDigits = SumOfDigits(command, phone, namesToPhoneNumber);
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

        private static void PrintDuration(int sumDigits)
        {
            var timeSpan = TimeSpan.FromSeconds(sumDigits);
            Console.WriteLine(timeSpan.ToString(@"mm\:ss"));
            
        }

        private static int SumOfDigits(string[] command, bool phone, string[] namesToPhoneNumber)
        {
            if (phone == true)
            {
                string digits = string.Join("", command[1].Split('+', '(', ')', '-'));
                int phones = 0;
                for (int i = 0; i < digits.Length; i++)
                {
                    phones += int.Parse(digits[i].ToString());
                }
                return phones;
            }
            string digitsFromName = string.Join("" , namesToPhoneNumber[0].Split('+', '(', ')', '-'));
            int numbers = 0;
            for (int i = 0; i < digitsFromName.Length; i++)
            {
                numbers += int.Parse(digitsFromName[i].ToString());
            }
            return numbers;
        }
    }
}
