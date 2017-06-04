using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class RegisterUsers
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        var users = new Dictionary<string, DateTime>();

        while (input[0] != "end")
        {
            string username = input[0];
            var date = DateTime.ParseExact(input[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            users[username] = date;
            input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        }

        var orderedUsers = users
            .Reverse()
            .OrderBy(x => x.Value)
            .Take(5)
            .OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var kvp in orderedUsers)
        {
            Console.WriteLine(kvp.Key);
        }
    }
}

