﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine().ToLower();
            if (productName == "banana" || productName == "apple" || productName == "kiwi" || productName == "cherry" || productName == "lemon" || productName == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (productName == "tomato" || productName == "cucumber" || productName == "pepper" || productName == "carrot")
            {
                    Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}