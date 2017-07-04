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
            var tickets = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            

            foreach (var ticket in tickets)
            {
                if (ticket.Length < 20 || ticket.Length > 20)
                {
                    Console.WriteLine("invalid ticket");
                }

                else
                {
                    var leftSide = new string(ticket.Take(10).ToArray());
                    var rightSide = new string(ticket.Skip(10).Take(10).ToArray());

                    var leftLongestSeq = FindMaxEqualSeq(leftSide);
                    var rightLongestSeq = FindMaxEqualSeq(rightSide);

                    bool leftWinSymbols = leftLongestSeq.Contains("@") || leftLongestSeq.Contains("#") ||
                                          leftLongestSeq.Contains("$") || leftLongestSeq.Contains("^");
                    bool rightWinSymbols = rightLongestSeq.Contains("@") || rightLongestSeq.Contains("#") ||
                                           rightLongestSeq.Contains("$") || rightLongestSeq.Contains("^");

                    if (leftLongestSeq.Length >= 6 && rightLongestSeq.Length >= 6 && leftLongestSeq[0] == rightLongestSeq[0]
                        && leftWinSymbols && rightWinSymbols)
                    {
                        var count = Math.Min(leftLongestSeq.Length, rightLongestSeq.Length);
                        Console.Write($"ticket \"{ticket}\" - {count}{leftLongestSeq[0]}");
                        if (count == 10)
                        {
                            Console.Write(" Jackpot!");
                        }
                        Console.WriteLine();
                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }

        private static string FindMaxEqualSeq(string text)
        {
            var bestStr = text[0].ToString();
            var max = 1;

            for (int i = 0; i < text.Length; i++)
            {
                var ch = text[i];
                var count = 0;

                while (i + count < text.Length && text[i + count] == text[i])
                {
                    count++;

                    if (count > max)
                    {
                        max = count;
                        bestStr = text.Substring(i, count);
                    }
                }
            }

            return bestStr;
        }
    }
}
