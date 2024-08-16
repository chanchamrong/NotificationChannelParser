using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationParser
{
    public class ScreenHelper
    {
        public void DisplayHelp()
        {
            Console.Clear();
            Console.WriteLine("=== Help ===");
            Console.WriteLine("This application allows you to parse notification titles.");
            Console.WriteLine("The notification title should contain tags in square brackets,");
            Console.WriteLine("such as [BE] for Backend, [FE] for Frontend, [QA] for Quality Assurance,");
            Console.WriteLine("or [Urgent] for urgent notifications.");
            Console.WriteLine("\nExample:");
            Console.WriteLine("Title: 'Urgent bug fix [BE][Urgent][QA]'");
            Console.WriteLine("Channels: Backend, Urgent, Quality Assurance");
            Console.WriteLine("Message: Urgent bug fix");
        }
    }
}