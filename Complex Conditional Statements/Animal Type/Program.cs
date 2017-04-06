using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine().ToLower();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                     Console.WriteLine("Reptile");
                    break;

                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
    }
}
