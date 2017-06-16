using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Messages
{
    public class User
    {
        public string Username { get; set; }
        public List<string> ReceivedMessages { get; set; }

        public static User RegisterUser(string input)
        {
            var line = input.Split();

            return new User
            {
                Username = line[1],
                ReceivedMessages = new List<string>()
            };
        }

    }

    public class Message
    {
        public string Content { get; set; }
        public string Sender { get; set; }

        public static Message ReadMessage(string input)
        {
            var line = input.Split();

            return new Message
            {
                Sender = line[0],
                Content = string.Join(" ", line.Skip(3))
            };
        }
    }

    public class Messages
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var users = new Dictionary<string, User>();
            var username = new User();

            while (input != "exit")
            {
                if (input.Contains("register"))
                {
                    username = User.RegisterUser(input);

                    users[username.Username] = new User()
                    {
                        Username = username.Username,
                        ReceivedMessages = new List<string>()
                    };
                }

                else if (input.Contains("send"))
                {
                    var line = input.Split();

                    if (!users.ContainsKey(line[0]) || !users.ContainsKey(line[2]))
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    var message = Message.ReadMessage(input);
                    //username.ReceivedMessages.Add(message.Content);

                    users[message.Sender].ReceivedMessages.Add(message.Content);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            var finalLine = input.Split();

            users = users
                .Where(x => x.Key == finalLine[0] || x.Key == finalLine[1])
                .ToDictionary(x => x.Key, x => x.Value);

            var first = new User();
            var second = new User();

            foreach (var item in users)
            {
                if (item.Key == finalLine[0])
                {
                    first = item.Value;
                }

                if (item.Key == finalLine[1])
                {
                    second = item.Value;
                }
            }

            for (int i = 0; i < Math.Max(first.ReceivedMessages.Count, second.ReceivedMessages.Count); i++)
            {
                if (i < first.ReceivedMessages.Count)
                {
                    Console.WriteLine($"{first.Username}: {first.ReceivedMessages[i]}");

                }

                if (i < second.ReceivedMessages.Count)
                {
                    Console.WriteLine($"{second.ReceivedMessages[i]} :{second.Username}");

                }
            }

            if (first.ReceivedMessages.Count == 0 && second.ReceivedMessages.Count == 0)
            {
                Console.WriteLine("No messages.");
            }
        }


    }
}
