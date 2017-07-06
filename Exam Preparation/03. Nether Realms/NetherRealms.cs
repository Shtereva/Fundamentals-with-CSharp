using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Nether_Realms
{
    public class Deamon
    {
        public decimal Health { get; set; }
        public decimal Damage { get; set; }

        public static Deamon Read(decimal health, decimal damage)
        {
            return new Deamon()
            {
                Health = health,
                Damage = damage
            };
        }
    }
    class NetherRealms
    {
        static void Main()
        {
            var input = Regex.Split(Console.ReadLine(), @",\s*")
                .Select(x => x.Trim())
                .Where(x => !x.Contains(" ") & !x.Contains(","))
                .ToArray();

            var deamons = new Dictionary<string, Deamon>();

            foreach (var match in input)
            {
                decimal health = Regex.Matches(match, @"[^\d\-*\/\.]")
                    .Cast<Match>()
                    .Select(x => char.Parse(x.Value))
                    .Select(x => (int) x)
                    .Sum();


                var damage = Regex.Matches(match, @"-?\d+(?:\.\d+)?")
                    .Cast<Match>()
                    .Select(x => decimal.Parse(x.Value))
                    .Sum();

                var specialSymbols = match
                    .Where(x => x == '*' || x == '/')
                    .ToArray();

                damage = DivideOrMultiply(damage, specialSymbols);

                var healthAndDamage = Deamon.Read(health, damage);

                if (!deamons.ContainsKey(match))
                {
                    deamons[match] = new Deamon();
                }

                deamons[match] = healthAndDamage;
            }

            deamons
                .OrderBy(x => x.Key)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} - {x.Value.Health} health, {x.Value.Damage:f2} damage"));
        }

        private static decimal DivideOrMultiply(decimal damage, char[] specialSymbols)
        {
            foreach (var symbol in specialSymbols)
            {
                switch (symbol)
                {
                    case '*':
                        damage *= 2;
                        break;
                    case '/':
                        damage /= 2;
                        break;
                }
            }

            return damage;
        }
    }
}
