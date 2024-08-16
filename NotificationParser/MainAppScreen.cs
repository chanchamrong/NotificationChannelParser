using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationParser
{
    public class MainAppScreen
    {
        public void RenderMenuList(){
            bool running = true;

            while (running)
            {
                // Display menu
                Console.Clear();
                Console.WriteLine("=== Notification Parser Menu ===");
                Console.WriteLine("1. Parse a new notification title");
                Console.WriteLine("2. Help");
                Console.WriteLine("3. Exit");
                Console.Write("Please choose an option (1-3): ");
                
                string choice = Console.ReadLine() ?? "";
                
                switch (choice)
                {
                    case "1":
                        TitleNotificationParserScreen notificationParserScreen = new();
                        notificationParserScreen.ParseNotification();
                        break;
                    case "2":
                        ScreenHelper screenHelper = new();
                        screenHelper.DisplayHelp();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Exiting the system...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}