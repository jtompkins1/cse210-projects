using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        string menuSelection = "";
        List<string> menu = new List<string> {"Start Breathing Activity", "Start Reflection Activity", "Start Listing Activity", "Quit" };

        do{
            Console.WriteLine("Menu Options:");

            for (int i = 0; i < menu.Count; i++)
            {
                string menuItem = menu[i];
                Console.WriteLine($" {i + 1}. {menuItem}");
            }

            Console.Write("Select an option from the menu (1-4): ");
            menuSelection = Console.ReadLine();
            
        }while (menuSelection != "4");


        
    }
}