using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        string menuSelection;
        string activityName;
        int durationInt;

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
            Console.Clear();
            a.SetActivityName(menuSelection);
            activityName = a.GetActivityName();
            a.DisplayStartMessage(menuSelection, activityName);
            Console.WriteLine();

            if (menuSelection != "4")
            {
                durationInt = a.GetDuration();
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(durationInt);
                Console.Clear();

                Console.WriteLine("Get Ready...");
                a.PausingAnimation();
                Console.WriteLine();

                while (DateTime.Now < endTime)
                {
                    if (menuSelection == "1")
                    {
                        BreathingActivity b = new BreathingActivity();
                        b.GetBreathing();
                    }
                }
                a.DisplayEndMessage(activityName, durationInt);
                
            }


            



        }while (menuSelection != "4");

    Console.WriteLine("Thank you for using the Mindfulness program!  Goodbye!");
        
    }

    
}