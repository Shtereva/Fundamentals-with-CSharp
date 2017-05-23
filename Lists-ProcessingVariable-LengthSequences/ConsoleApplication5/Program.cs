using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: ");
            Console.WriteLine("|{0}{1}|", new string('|', Math.Min(health, maxHealth)), new string('.', maxHealth - health));
            Console.Write("Energy: ");
            Console.WriteLine("|{0}{1}|", new string('|', Math.Min(energy, maxEnergy)), new string('.', maxEnergy - energy));


        }
    }
}
