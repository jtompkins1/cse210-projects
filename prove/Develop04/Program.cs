using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        string menuSelection = "";
        string activityName = "";

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
            a.SetActivityName(menuSelection);
            activityName = a.GetActivityName();
            // a.SetDescription(activityName);
            // description = a.GetDescription();
            a.DisplayStartMessage(menuSelection, activityName);
            Console.WriteLine();



        }while (menuSelection != "4");

    Console.WriteLine("Thank you for using the Mindfulness program!  Goodbye!");
        
    }

    
}