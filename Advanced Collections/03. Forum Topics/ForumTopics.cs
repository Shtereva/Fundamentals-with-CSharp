using System;
using System.Collections.Generic;
using System.Linq;



class ForumTopics
{
    static void Main()
    {
        var line = Console.ReadLine().Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        var forumTopics = new Dictionary<string, HashSet<string>>();

        while (line[0] != "filter")
        {
            string topic = line[0].Trim();
            var tags = line[1].Trim().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            AddTopicsToForum(forumTopics, topic, tags);

            line = Console.ReadLine().Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        }

        var finalTags = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var topic in forumTopics)
        {
            bool hasAllTopics = true;
            hasAllTopics = CheckTopicsExistence(finalTags, topic, hasAllTopics);

            if (hasAllTopics)
            {
                Console.WriteLine($"{topic.Key} | {string.Join(", ", topic.Value.Select(x => $"#{x}"))}");
            }
        }


    }

    private static bool CheckTopicsExistence(string[] finalTags, KeyValuePair<string, HashSet<string>> topic, bool hasAllTopics)
    {
        foreach (var finalTag in finalTags)
        {
            if (!topic.Value.Contains(finalTag))
            {
                hasAllTopics = false;
                return hasAllTopics;
            }
        }

        return hasAllTopics;
    }

    private static void AddTopicsToForum(Dictionary<string, HashSet<string>> forumTopics, string topic, string[] tags)
    {
        if (!forumTopics.ContainsKey(topic))
        {
            forumTopics[topic] = new HashSet<string>();
        }

        foreach (var tag in tags)
        {
            forumTopics[topic].Add(tag);
        }
    }
}

