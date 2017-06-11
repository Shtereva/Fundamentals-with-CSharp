using System;
using System.Linq;
class RandomizeWords
{
    static void Main()
    {
        var words = Console.ReadLine().Split();

        var random = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            var currentWord = words[i];
            var randomPossition = random.Next(0, words.Length);
            var temp = words[randomPossition];
            words[randomPossition] = currentWord;
            words[i] = temp;
        }
        Console.WriteLine(string.Join(Environment.NewLine, words));

    }
}
