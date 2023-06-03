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
            // Activity a = new Activity();

            Menu menu = new Menu();
            menu.DisplayMenu();
            menuSelection = menu.GetMenuSelection();

            // string activityName;

            // activityName = menu.GetActivityName();


            // List<string> _menu = new List<string> {"Start Breathing Activity", "Start Reflection Activity", "Start Listing Activity", "Quit" };

            // Console.WriteLine("Menu Options:");

            // for (int i = 0; i < _menu.Count; i++)
            // {
            //     string menuItem = _menu[i];
            //     Console.WriteLine($" {i + 1}. {menuItem}");
            // }

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



        }while (menuSelection != "4");


        
    }
}