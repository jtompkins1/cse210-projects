using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string activityName = "";

        do
        {

            List<string> _menu = new List<string> {"Start Breathing Activity", "Start Reflection Activity", "Start Listing Activity", "Quit" };

            // Menu menu = new Menu();
            // menu.DisplayMenu();
            // menuSelection = menu.GetMenuSelection();

            Console.WriteLine("Menu Options:");

            for (int i = 0; i < _menu.Count; i++)
            {
                string menuItem = _menu[i];
                Console.WriteLine($" {i + 1}. {menuItem}");
            }

            Activity a = new Activity();
            activityName = a.GetActivityName();

            // Console.Write("Select an option from the menu (1-4): ");
            // menuSelection = Console.ReadLine();

            // if (menuSelection == "1")
            // {
            //     activityName = "Breathing Activity";
            // }else if (menuSelection == "2")
            // {
            //     activityName = "Reflection Activity";
            // }else if (menuSelection == "3")
            // {
            //     activityName = "Listing Activity";
            // }



        }while (activityName != "Quit");


        
    }
}