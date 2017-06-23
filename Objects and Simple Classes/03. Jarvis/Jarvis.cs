using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Jarvis
{
    public class Arms
    {
        public long EnergyConsumption { get; set; }
        public int ReachDistance { get; set; }
        public int CountOfFingers { get; set; }

        public override string ToString()
        {
            return string.Format(
                $"#Arm:{Environment.NewLine}###Energy consumption: {EnergyConsumption}{Environment.NewLine}###Reach: {ReachDistance}{Environment.NewLine}###Fingers: {CountOfFingers}");
        }
    }

    public class Legs
    {
        public long EnergyConsumption { get; set; }
        public long Strenght { get; set; }
        public long Speed { get; set; }

        public override string ToString()
        {
            return string.Format(
                $"#Leg:{Environment.NewLine}###Energy consumption: {EnergyConsumption}{Environment.NewLine}###Strength: {Strenght}{Environment.NewLine}###Speed: {Speed}");
        }
    }

    public class Torso
    {
        public long EnergyConsumption { get; set; }
        public double ProcessorSizeInSentimeters { get; set; }
        public string HousingMaterial { get; set; }

        public override string ToString()
        {
            return string.Format(
                $"#Torso:{Environment.NewLine}###Energy consumption: {EnergyConsumption}{Environment.NewLine}###Processor size: {ProcessorSizeInSentimeters:f1}{Environment.NewLine}###Corpus material: {HousingMaterial}");
        }
    }

    public class Head
    {
        public long EnergyConsumption { get; set; }
        public long Iq { get; set; }
        public string SkinMaterial { get; set; }

        public override string ToString()
        {
            return string.Format(
                $"#Head:{Environment.NewLine}###Energy consumption: {EnergyConsumption}{Environment.NewLine}###IQ: {Iq}{Environment.NewLine}###Skin material: {SkinMaterial}");
        }
    }

    public class Jarvis
    {
        public static void Main()
        {
            long maxEnergy = long.Parse(Console.ReadLine());
            string lines = Console.ReadLine();
            var arms = new Dictionary<string, List<Arms>>();
            arms["Arm"] = new List<Arms>();

            var legs = new Dictionary<string, List<Legs>>();
            legs["Leg"] = new List<Legs>();

            var torso = new Dictionary<string, List<Torso>>();
            torso["Torso"] = new List<Torso>();

            var head = new Dictionary<string, List<Head>>();
            head["Head"] = new List<Head>();

            var robot = new Dictionary<string, List<object>>();

            while (lines != "Assemble!")
            {
                var components = lines.Split();

                string typeOfComponent = components[0];
                long energyConsumption = long.Parse(components[1]);
                string property1 = components[2];
                string property2 = components[3];

                AddComponents(arms, legs, torso, head, typeOfComponent, energyConsumption, property1, property2);

                robot[typeOfComponent] = new List<object>();

                lines = Console.ReadLine();
            }

            long energy = 0;
            energy = CalculateComponentsEnergy(arms, legs, torso, head, robot, energy);

            PrintRobot(maxEnergy, robot, energy);

        }

        private static void PrintRobot(long maxEnergy, Dictionary<string, List<object>> robot, long energy)
        {
            if (energy > maxEnergy)
            {
                Console.WriteLine("We need more power!");
            }

            else if (robot.Count < 4 || robot["Leg"].Count < 2 || robot["Arm"].Count < 2)
            {
                Console.WriteLine("We need more parts!");
            }

            else
            {
                Console.WriteLine("Jarvis:");
                Console.WriteLine(string.Join(Environment.NewLine, robot["Head"]));
                Console.WriteLine(string.Join(Environment.NewLine, robot["Torso"]));
                Console.WriteLine(string.Join(Environment.NewLine, robot["Arm"]));
                Console.WriteLine(string.Join(Environment.NewLine, robot["Leg"]));
            }
        }

        private static long CalculateComponentsEnergy(Dictionary<string, List<Arms>> arms, Dictionary<string, List<Legs>> legs, Dictionary<string, List<Torso>> torso, Dictionary<string, List<Head>> head, Dictionary<string, List<object>> robot, long energy)
        {
            foreach (var item in arms)
            {
                var list = item.Value.ToList();
                var temp = list.OrderBy(x => x.EnergyConsumption).Take(2).ToList();
                energy += temp.Select(x => x.EnergyConsumption).Sum();

                if (robot.ContainsKey(item.Key))
                {
                    robot[item.Key].AddRange(temp);
                }
            }

            foreach (var item in legs)
            {
                var list = item.Value.ToList();
                var temp = list.OrderBy(x => x.EnergyConsumption).Take(2).ToList();
                energy += temp.Select(x => x.EnergyConsumption).Sum();

                if (robot.ContainsKey(item.Key))
                {
                    robot[item.Key].AddRange(temp);
                }
            }

            foreach (var item in head)
            {
                var list = item.Value.ToList();
                var temp = list.OrderBy(x => x.EnergyConsumption).Take(1).ToList();
                energy += temp.Select(x => x.EnergyConsumption).Sum();

                if (robot.ContainsKey(item.Key))
                {
                    robot[item.Key].AddRange(temp);
                }
            }

            foreach (var item in torso)
            {
                var list = item.Value.ToList();
                var temp = list.OrderBy(x => x.EnergyConsumption).Take(1).ToList();
                energy += temp.Select(x => x.EnergyConsumption).Sum();

                if (robot.ContainsKey(item.Key))
                {
                    robot[item.Key].AddRange(temp);
                }
            }

            return energy;
        }

        private static void AddComponents(Dictionary<string, List<Arms>> arms, Dictionary<string, List<Legs>> legs, Dictionary<string, List<Torso>> torso, Dictionary<string, List<Head>> head, string typeOfComponent, long energyConsumption, string property1, string property2)
        {
            switch (typeOfComponent)
            {
                case "Arm":
                    var arm = new Arms()
                    {
                        EnergyConsumption = energyConsumption,
                        ReachDistance = int.Parse(property1),
                        CountOfFingers = int.Parse(property2)
                    };

                    arms[typeOfComponent].Add(arm);
                    break;
                case "Leg":
                    var leg = new Legs()
                    {
                        EnergyConsumption = energyConsumption,
                        Strenght = int.Parse(property1),
                        Speed = int.Parse(property2)
                    };

                    legs[typeOfComponent].Add(leg);
                    break;
                case "Torso":
                    var torsoTemp = new Torso()
                    {
                        EnergyConsumption = energyConsumption,
                        ProcessorSizeInSentimeters = double.Parse(property1),
                        HousingMaterial = property2
                    };

                    torso[typeOfComponent].Add(torsoTemp);
                    break;
                case "Head":
                    var headTemp = new Head()
                    {
                        EnergyConsumption = energyConsumption,
                        Iq = int.Parse(property1),
                        SkinMaterial = property2
                    };

                    head[typeOfComponent].Add(headTemp);
                    break;
            }
        }
    }
}
