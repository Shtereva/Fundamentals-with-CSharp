using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        var cards = new Dictionary<string, List<string>>();

        while (input != "JOKER")
        {
            var param = input.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = param[0];
            var line = param[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            AddCardsToPlayers(cards, line, name);

            input = Console.ReadLine();
        }

        foreach (var name in cards.Keys)
        {
            int sum = 0;
            foreach (var item in cards[name])
            {
                var temp = item.ToCharArray();
                int power = 0;
                int type = 0;
                if (temp.Length == 3)
                {
                    temp[1] = temp[2];
                }
                power = TryToParsePower(temp);
                type = TryToParseType(temp);

                if (temp.Length == 3)
                {
                    power *= 10; 
                }
                sum += power * type;
            }

            Console.WriteLine($"{name}: {sum}");
        }
    }

    private static int TryToParseType(char[] temp)
    {
        int type;
        if (!int.TryParse(temp[1].ToString(), out type))
        {
            switch (temp[1].ToString())
            {
                case "S":
                    type = 4;
                    break;
                case "H":
                    type = 3;
                    break;
                case "D":
                    type = 2;
                    break;
                case "C":
                    type = 1;
                    break;
            }
        }

        else
        {
            type = int.Parse(temp[1].ToString());
        }

        return type;
    }

    private static int TryToParsePower(char[] temp)
    {
        int power;
        if (!int.TryParse(temp[0].ToString(), out power))
        {
            switch (temp[0].ToString())
            {
                case "J":
                    power = 11;
                    break;
                case "Q":
                    power = 12;
                    break;
                case "K":
                    power = 13;
                    break;
                case "A":
                    power = 14;
                    break;
            }
        }

        else
        {
            power = int.Parse(temp[0].ToString());
        }

        return power;
    }

    private static void AddCardsToPlayers(Dictionary<string, List<string>> cards, List<string> line, string name)
    {
        if (!cards.ContainsKey(name))
        {
            cards[name] = new List<string>();
        }

        foreach (var item in line)
        {
            if (!cards[name].Contains(item))
            {
                cards[name].Add(item);
            }
        }
    }
}
