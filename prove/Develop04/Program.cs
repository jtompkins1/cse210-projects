using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {   
        string menuSelection = "";
        string activityName;
        string description;
        int durationInt;
        string listPrompt;
        List<string> userEntries = new List<string>();
        double acc = 0.0;
        int elapsedSeconds;

        do
        {
            List<string> _menu = new List<string> {"Start Breathing Activity", "Start Reflection Activity", "Start Listing Activity", "Quit" };
            Console.WriteLine("Menu Options:");

            for (int i = 0; i < _menu.Count; i++)
            {
                string menuItem = _menu[i];
                Console.WriteLine($" {i + 1}. {menuItem}");
            }
            
            Activity a = new Activity();
            menuSelection = a.GetMenuSelection();
            activityName = a.GetActivityName(menuSelection);
            description = a.GetDescription();
            

            if (menuSelection == "1" || menuSelection == "2" || menuSelection == "3")
            {
                Console.Clear();
                a.DisplayStartMessage(menuSelection, activityName);
                Console.WriteLine();

                durationInt = a.GetDuration();
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(durationInt);
                Console.Clear();

                Console.WriteLine("Get Ready...");
                a.PausingAnimation(5);
                Console.WriteLine();

                if (menuSelection == "1")
                {
                    BreathingActivity b = new BreathingActivity(activityName, description, durationInt);
                    b.GetBreathingTime(durationInt);

                }
                else if (menuSelection == "2")
                {
                    ReflectionActivity r = new ReflectionActivity(activityName, description, durationInt);
                    r.DisplayThoughtPrompt();
                    r.QuestionCountdown();
                    acc = r.Questions(durationInt);

                }
                else if (menuSelection == "3")
                {
                    ListingActivity l = new ListingActivity(activityName, description, durationInt);
                    listPrompt = l.GetListPrompt();

                    l.ListCountdown();
                    acc = l.GetEntries(durationInt);    
                }
                
                elapsedSeconds = a.GetElapsedTime(acc);

                a.DisplayEndMessage(activityName, elapsedSeconds);
                a.PausingAnimation(5);
                Console.Clear();
            }
            else if (menuSelection == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***Invalid selection, try again.***");
                Console.ResetColor();
                Console.WriteLine();
            }

        }while (menuSelection != "4");

        Console.WriteLine("Thank you for using the Mindfulness program! Goodbye!");

        
    }
}
