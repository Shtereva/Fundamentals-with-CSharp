using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Vehicle_Catalogue
{
    public class Vehicle
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public static Vehicle Read(string[] line)
        {

            return new Vehicle
            {
                Model = line[1],
                Color = line[2],
                HorsePower = int.Parse(line[3])
            };
        }
    }

    public class VehicleCatalogue
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var vehicles = new Dictionary<string, List<Vehicle>>();
            vehicles["car"] = new List<Vehicle>();
            vehicles["truck"] = new List<Vehicle>();

            while (input != "End")
            {
                DistributeVehicles(input, vehicles);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                string type = string.Empty;
                int index = 0;
                FindModel(input, vehicles, out type, out index);
                PrintCarsData(vehicles, type, index);

                input = Console.ReadLine();
            }

            double avgPowerOfCars = 0;
            double avgPowerOfTrucks = 0;

            if (vehicles["car"].Count > 0)
            {
                avgPowerOfCars = vehicles["car"].Select(x => x.HorsePower).Average();
            }

            if (vehicles["truck"].Count > 0)
            {
                avgPowerOfTrucks = vehicles["truck"].Select(x => x.HorsePower).Average();
            }                                              
                                                              
            Console.WriteLine($"Cars have average horsepower of: {avgPowerOfCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgPowerOfTrucks:f2}.");
        }

        private static void PrintCarsData(Dictionary<string, List<Vehicle>> vehicles, string type, int index)
        {
            Console.WriteLine(type == "car" ? "Type: Car" : "Type: Truck");
            Console.WriteLine($"Model: {vehicles[type][index].Model}");
            Console.WriteLine($"Color: {vehicles[type][index].Color}");
            Console.WriteLine($"Horsepower: {vehicles[type][index].HorsePower}");
        }

        private static void FindModel(string input, Dictionary<string, List<Vehicle>> vehicles, out string type, out int index)
        {
            if (vehicles["car"].Any(x => x.Model == input))
            {
                type = "car";
                index = vehicles[type].IndexOf(vehicles[type].Find(x => x.Model == input));
            }

            else
            {
                type = "truck";
                index = vehicles[type].IndexOf(vehicles[type].Find(x => x.Model == input));
            }
        }

        private static void DistributeVehicles(string input, Dictionary<string, List<Vehicle>> vehicles)
        {
            var line = input.Split();

            var type = line[0].ToLower();
            var properties = Vehicle.Read(line);

            switch (type)
            {
                case "car":
                    vehicles[type].Add(properties);
                    break;
                case "truck":
                    vehicles[type].Add(properties);
                    break;
            }
        }
    }
}
