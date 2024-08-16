using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationParser
{
    public class TitleNotificationParserScreen
    {
        public void ParseNotification()
        {
            Console.Clear();
            Console.WriteLine("Enter the notification title:");
            string title = Console.ReadLine() ?? "";

            var (channels, message) = ParseNotificationTitle(title);

            // Display results
            if (channels.Count > 0)
            {
                Console.WriteLine("\nReceived Channels:");
                foreach (var channel in channels)
                {
                    Console.WriteLine($"- {channel}");
                }
            }
            else
            {
                Console.WriteLine("No valid notification channels found in the title.");
            }

            Console.WriteLine($"Message: {message}");
        }



        public (HashSet<string> channels, string message) ParseNotificationTitle(string title)
        {
            var tagToChannelMap = new Dictionary<string, string>
            {
                { "BE", "Backend" },
                { "FE", "Frontend" },
                { "QA", "Quality Assurance" },
                { "Urgent", "Urgent" }
            };

            var channels = new HashSet<string>();

            var tags = title
                .Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

            var messageParts = new List<string>();

            foreach (var tag in tags)
            {
                var trimmedPart = tag.Trim();
                if (tagToChannelMap.ContainsKey(trimmedPart))
                {
                    channels.Add(tagToChannelMap[trimmedPart]);
                }
                else
                {
                    messageParts.Add(trimmedPart);
                }
            }
            foreach (var tag in tags)
            {
                if (tagToChannelMap.ContainsKey(tag.Trim()))
                {
                    channels.Add(tagToChannelMap[tag.Trim()]);
                }
            }
            string message = string.Join(" ", messageParts).Trim();

            return (channels, message);
        }
    }
}