using System;
using System.Collections.Generic;

public class Menu
{
    protected string _menuSelection;
    protected List<string> _menu;
    protected string _activityName;

    public Menu()
    {
         List<string> _menu = new List<string> {"Start Breathing Activity", "Start Reflection Activity", "Start Listing Activity", "Quit" };

    }
    public List<string> GetMenu(List<string> menu)
    {
        return _menu;
    }
    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");

        for (int i = 0; i < _menu.Count; i++)
        {
            string menuItem = _menu[i];
            Console.WriteLine($" {i + 1}. {menuItem}");
        }

    }

    public string GetMenuSelection()
    {
        Console.Write("Select an option from the menu (1-4): ");
        return _menuSelection = Console.ReadLine();

    }

    public string GetActivityName()
    {
        if (_menuSelection == "1")
        {
            _activityName = "Breathing Activity";
        }else if (_menuSelection == "2")
        {
            _activityName = "Reflection Activity";
        }else if (_menuSelection == "3")
        {
            _activityName = "Listing Activity";
        }
        return _activityName;

    }

}