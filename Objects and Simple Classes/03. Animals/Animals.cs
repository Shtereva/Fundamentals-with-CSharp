using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animals
{
    class Animals
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var dogs = new Dictionary<string, List<int>>();
            var cats = new Dictionary<string, List<int>>();
            var snakes = new Dictionary<string, List<int>>();

            while (input != "I'm your Huckleberry")
            {
                var dog = new Dog();
                var cat = new Cat();
                var snake = new Snake();

                if (input.Contains("talk"))
                {
                    var temp = input.Split();
                    string talkName = temp[1];
                    ProduceSound(dogs, cats, snakes, dog, cat, snake, talkName);

                    input = Console.ReadLine();
                    continue;
                }

                var line = input.Split();
                string givenClass = line[0];
                string name = line[1];
                int age = int.Parse(line[2]);
                int parameter = int.Parse(line[3]);


                AddAnimalsToCollections(givenClass, name, age, parameter, dog, cat, snake, dogs, cats, snakes);

                input = Console.ReadLine();
            }

            PrintResult(dogs, cats, snakes);
        }

        private static void PrintResult(Dictionary<string, List<int>> dogs, Dictionary<string, List<int>> cats, Dictionary<string, List<int>> snakes)
        {
            if (dogs.Count > 0)
            {
                dogs
                    .ToList()
                    .ForEach(x => Console.WriteLine($"Dog: {x.Key}, Age: {x.Value[0]}, Number Of Legs: {x.Value[1]}"));
            }

            if (cats.Count > 0)
            {
                cats
                    .ToList()
                    .ForEach(x => Console.WriteLine($"Cat: {x.Key}, Age: {x.Value[0]}, IQ: {x.Value[1]}"));
            }

            if (snakes.Count > 0)
            {
                snakes
                    .ToList()
                    .ForEach(x => Console.WriteLine($"Snake: {x.Key}, Age: {x.Value[0]}, Cruelty: {x.Value[1]}"));
            }
        }

        private static void ProduceSound(Dictionary<string, List<int>> dogs, Dictionary<string, List<int>> cats, Dictionary<string, List<int>> snakes, Dog dog, Cat cat, Snake snake, string talkName)
        {
            if (dogs.ContainsKey(talkName))
            {
                dog.ProduceSound();
            }

            if (cats.ContainsKey(talkName))
            {
                cat.ProduceSound();
            }

            if (snakes.ContainsKey(talkName))
            {
                snake.ProduceSound();
            }
        }

        private static void AddAnimalsToCollections(string givenClass, string name, int age, int parameter, Dog dog, Cat cat, Snake snake,
            Dictionary<string, List<int>> dogs, Dictionary<string, List<int>> cats, Dictionary<string, List<int>> snakes)
        {
            switch (givenClass)
            {
                case "Dog":
                    dog.Name = name;
                    dog.Age = age;
                    dog.NumberOfLegs = parameter;

                    if (!dogs.ContainsKey(name))
                    {
                        dogs[name] = new List<int>();
                    }

                    dogs[name].Add(age);
                    dogs[name].Add(parameter);

                    break;
                case "Cat":
                    cat.Name = name;
                    cat.Age = age;
                    cat.IntelligenceQuotient = parameter;

                    if (!cats.ContainsKey(name))
                    {
                        cats[name] = new List<int>();
                    }

                    cats[name].Add(age);
                    cats[name].Add(parameter);

                    break;
                case "Snake":
                    snake.Name = name;
                    snake.Age = age;
                    snake.CrueltyCoefficient = parameter;

                    if (!snakes.ContainsKey(name))
                    {
                        snakes[name] = new List<int>();
                    }

                    snakes[name].Add(age);
                    snakes[name].Add(parameter);

                    break;
            }
        }
    }
}
