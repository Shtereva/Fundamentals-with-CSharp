using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SocialMediaPosts
{
    static void Main()
    {
        var line = Console.ReadLine();
        var socialMedia = new Dictionary<string, Dictionary<string, List<string>>>();
        // postName     like || dislike || comment
        while (line != "drop the media")
        {
            var commands = line.Split();
            string command = commands[0];
            string postName = commands[1];
            AddingContentToSocialMedia(commands, socialMedia, command, postName);

            line = Console.ReadLine();
        }

        PrintSummary(socialMedia);
    }

    private static void PrintSummary(Dictionary<string, Dictionary<string, List<string>>> socialMedia)
    {
        foreach (var post in socialMedia)
        {
            Console.Write($"Post: {post.Key} | ");
            var summary = post.Value;
            Console.WriteLine($"Likes: {summary["like"].Count} | Dislikes: {summary["dislike"].Count}");
            Console.WriteLine("Comments:");
            Console.WriteLine(summary["comment"].Count <= 0 ? "None" : $"{string.Join(Environment.NewLine, summary["comment"])}");
        }
    }

    private static void AddingContentToSocialMedia(string[] commands, Dictionary<string, Dictionary<string, List<string>>> socialMedia, string command, string postName)
    {
        if (!socialMedia.ContainsKey(postName))
        {
            CreatingSocialMediaButtons(socialMedia, postName);
        }

        if (command == "like")
        {
            socialMedia[postName][command].Add("1");
        }

        else if (command == "dislike")
        {
            socialMedia[postName][command].Add("1");
        }

        else if (command == "comment")
        {
            string commentatorName = commands[2];
            string content = string.Empty;
            content = CollectContent(commands, content);
            socialMedia[postName][command].Add($"*  {commentatorName}: {content}");
        }
    }

    private static string CollectContent(string[] commands, string content)
    {
        for (int i = 3; i < commands.Length; i++)
        {
            content += commands[i] + " ";
        }
        content.Trim();
        return content;
    }

    private static void CreatingSocialMediaButtons(Dictionary<string, Dictionary<string, List<string>>> socialMedia, string postName)
    {
        socialMedia[postName] = new Dictionary<string, List<string>>();
        socialMedia[postName]["like"] = new List<string>();
        socialMedia[postName]["dislike"] = new List<string>();
        socialMedia[postName]["comment"] = new List<string>();
    }
}
