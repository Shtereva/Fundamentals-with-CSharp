using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    public class TemperatureAndType
    {
        public double Temperature { get; set; }
        public string Type { get; set; }


    }
    class Weather
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var regex = new Regex(@"(?<city>[A-Z]{2})(?<temp>\d+(\.\d+)?)(?<type>[A-Z]+[a-z]+|[a-z]+)\|");
            var weather = new Dictionary<string, TemperatureAndType>();

            while (input != "end")
            {
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);

                    var city = match.Groups["city"];
                    if (!weather.ContainsKey(city.Value))
                    {
                        weather[city.Value] = new TemperatureAndType();
                    }

                    var temperature = match.Groups["temp"];
                    var type = match.Groups["type"];

                    weather[city.Value].Temperature = double.Parse(temperature.Value);
                    weather[city.Value].Type = type.Value;
                }
                input = Console.ReadLine();
            }

            weather
                .OrderBy(x => x.Value.Temperature)
                .Select(x => $"{x.Key} => {x.Value.Temperature:f2} => {x.Value.Type}")
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
