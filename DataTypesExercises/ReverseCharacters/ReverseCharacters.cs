﻿using System;


namespace ReverseCharacters
{
    class ReverseCharacters
    {
        static void Main()
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{char3}{char2}{char1}" );
        }

    }
}