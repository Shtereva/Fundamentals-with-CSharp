using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var CitiesByContinentAndCountry = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
        // continent         //country    //cities   
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            string continent = input[0];
            string country = input[1];
            string city = input[2];
            AddingContinentsCountriesAndCities(CitiesByContinentAndCountry, continent, country, city);
        }

        foreach (var continent in CitiesByContinentAndCountry.Keys)
        {
            Console.WriteLine($"{continent}:");

            foreach (var country in CitiesByContinentAndCountry[continent])
            {
                Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }

    private static void AddingContinentsCountriesAndCities(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> CitiesByContinentAndCountry, string continent, string country, string city)
    {
        if (!CitiesByContinentAndCountry.ContainsKey(continent))
        {
            CitiesByContinentAndCountry[continent] = new SortedDictionary<string, SortedSet<string>>();
        }

        if (!CitiesByContinentAndCountry[continent].ContainsKey(country))
        {
            CitiesByContinentAndCountry[continent][country] = new SortedSet<string>();
        }
        CitiesByContinentAndCountry[continent][country].Add(city);
    }
}

