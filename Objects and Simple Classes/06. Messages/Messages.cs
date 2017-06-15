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
                Username = line[1]
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
                Content = line[line.Length - 1]
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
                        Username = username.Username
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
                    username.ReceivedMessages = new List<string>();
                    username.ReceivedMessages.Add(message.Content);

                    users[line[2]].ReceivedMessages.Add(message.Content);
                }

                input = Console.ReadLine();
            }
        }

        
    }
}
