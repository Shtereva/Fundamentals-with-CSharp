using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{
    class WinningTicket
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var winningSymbols = "@#$^".ToCharArray();

            foreach (var VARIABLE in input)
            {
                int len = VARIABLE.Length;
                var ticket = Regex.Match(VARIABLE, @"(?<=\s|^).{20}(?=\s|$)");

                if (!ticket.Success)
                {
                    Console.WriteLine("Invalid ticket");
                    continue;
                }

                for (int i = 0; i < winningSymbols.Length; i++)
                {
                    var symbol = Regex.Match(ticket.Value, @".*?(\" + winningSymbols[i] + @"{6,9}).*?\1");
                    if (symbol.Success)
                    {
                        var index = symbol.Value.IndexOf(winningSymbols[i]);

                        if (ticket.Value.All(x => x == winningSymbols[i]))
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10$ Jackpot!");
                        }

                        else
                        {
                            
                        }
                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }

            }
        }
    }
}
