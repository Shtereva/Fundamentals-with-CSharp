using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Order_by_Age
{
    public class People
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public static People Read(string input)
        {
            var line = input.Split();

            return new People
            {
                Name = line.First(),
                Id = line[1],
                Age = int.Parse(line.Last())
            };
        }
    }

    public class OrderByAge
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var people = new List<People>();

            while (input != "End")
            {
                var person = People.Read(input);

                people.Add(person);

                input = Console.ReadLine();
            }

            people
                .OrderBy(x => x.Age)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Name} with ID: {x.Id} is {x.Age} years old."));
        }


    }
}
