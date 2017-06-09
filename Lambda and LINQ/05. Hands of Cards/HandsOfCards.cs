using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var cardsPower = GetCardsPower();
        var cardsType = GetCardsType();
        string input = Console.ReadLine();
        var cards = new Dictionary<string, HashSet<int>>();

        while (input != "JOKER")
        {
            var param = input.Split(':');
            string name = param[0];
            var playerCards = param[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var card in playerCards)
            {
                var power = card.Substring(0, card.Length - 1);
                var type = card.Substring(card.Length - 1);

                int sum = cardsPower[power] * cardsType[type];

                if (!cards.ContainsKey(name))
                {
                    cards[name] = new HashSet<int>();
                }

                cards[name].Add(sum);
            }
            input = Console.ReadLine();
        }

        foreach (var player in cards)
        {
            Console.WriteLine($"{player.Key}: {player.Value.Sum()}");
        }
    }

    private static Dictionary<string, int> GetCardsType()
    {
        var types = new Dictionary<string, int>();

        types["S"] = 4;
        types["H"] = 3;
        types["D"] = 2;
        types["C"] = 1;

        return types;
    }

    private static Dictionary<string, int> GetCardsPower()
    {
        var powers = new Dictionary<string, int>();

        for (int i = 2; i <= 10; i++)
        {
            powers[i.ToString()] = i;
        }

        powers["J"] = 11;
        powers["Q"] = 12;
        powers["K"] = 13;
        powers["A"] = 14;

        return powers;
    }
}
