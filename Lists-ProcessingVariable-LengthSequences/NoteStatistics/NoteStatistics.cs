using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteStatistics
{
    class NoteStatistics
    {
        static void Main()
        {
            var frequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var notes = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            var freq = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30
                                        , 440.00, 466.16, 493.88};
            var allNotes = new List<string>();
            var naturals = new List<string>();
            var sharp = new List<string>();
            double sumNaturals = 0;
            double sumSharp = 0;

            SeparateNotesToNaturalAndSharp(frequencies, notes, freq, allNotes, naturals, sharp, ref sumNaturals, ref sumSharp);
            PrintNotesResult(allNotes, sharp, naturals);

            Console.WriteLine(naturals.Count == 0 ? "Naturals sum: {0}" : "Naturals sum: {0:f2}", sumNaturals);
            Console.WriteLine(sharp.Count == 0 ? "Sharps sum: {0}" : "Sharps sum: {0:f2}", sumSharp);
        }

        private static void PrintNotesResult(List<string> allNotes, List<string> sharp, List<string> naturals)
        {
            Console.WriteLine($"Notes: {string.Join(" ", allNotes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharp)}");
        }

        private static void SeparateNotesToNaturalAndSharp(List<double> frequencies, List<string> notes, List<double> freq
            , List<string> allNotes, List<string> naturals, List<string> sharp, ref double sumNaturals, ref double sumSharp)
        {
            for (int i = 0; i < frequencies.Count; i++)
            {
                for (int j = 0; j < freq.Count; j++)
                {
                    if (frequencies[i].Equals(freq[j]))
                    {
                        allNotes.Add(notes[j]);
                        if (notes[j].Length > 1)
                        {
                            sharp.Add(notes[j]);
                            sumSharp += freq[j];
                            break;
                        }
                        else
                        {
                            naturals.Add(notes[j]);
                            sumNaturals += freq[j];
                            break;
                        }
                    }
                }
            }
        }
    }
}
