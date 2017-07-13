using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Pokemon_Evolution
{
    public class Evolution
    {
        public string EvolutionType { get; set; }
        public long Index { get; set; }
    }
    class PokemonEvolution
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var pokemons = new Dictionary<string, List<Evolution>>();

            while (input != "wubbalubbadubdub")
            {
                var line = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (line.Length == 1)
                {
                    if (pokemons.ContainsKey(line[0]))
                    {
                        foreach (var pokemon in pokemons)
                        {
                            if (pokemon.Key == line[0])
                            {
                                Console.WriteLine("# " + pokemon.Key);
                                pokemon.Value
                                    .ToList()
                                    .ForEach(x => Console.WriteLine($"{x.EvolutionType} <-> {x.Index}"));
                            }
                        }
                    }

                    input = Console.ReadLine();
                    continue;
                }

                if (!pokemons.ContainsKey(line[0]))
                {
                    pokemons[line[0]] = new List<Evolution>();
                }



                var temp = new Evolution
                {
                    EvolutionType = line[1],
                    Index = long.Parse(line[2])
                };

                pokemons[line[0]].Add(temp);
                input = Console.ReadLine();
            }

            foreach (var evolutions in pokemons)
            {
                Console.WriteLine($"# {evolutions.Key}");
                evolutions.Value
                    .OrderByDescending(x => x.Index)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.EvolutionType} <-> {x.Index}"));

            }
        }
    }
}
