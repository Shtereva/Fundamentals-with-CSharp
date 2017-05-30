using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.User_Logins
{
    class UserLogins
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var usernames = new Dictionary<string, string>();
            int count = 0;

            while (input[0] != "login")
            {
                AddingUsernames(input, usernames);

                input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "end")
            {
                UserLogin(input, usernames,ref count);

                input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");

        }

        private static int UserLogin(string[] input, Dictionary<string, string> usernames,ref int count)
        {
            if (usernames.ContainsKey(input[0]) && usernames[input[0]].Equals(input[1]))
            {
                Console.WriteLine($"{input[0]}: logged in successfully");
            }

            else
            {
                count++;
                Console.WriteLine($"{input[0]}: login failed");
            }

            return count;
        }

        private static void AddingUsernames(string[] input, Dictionary<string, string> usernames)
        {
            if (usernames.ContainsKey(input[0]))
            {
                usernames[input[0]] = input[1];
            }

            else
            {
                usernames.Add(input[0], input[1]);
            }
        }
    }
}
