using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _listPrompts = new List<string>();
    protected List<string> _userEntries = new List<string>();
    protected string _userEntry;

    // public ListingActivity(List<string> userEntries)
    public ListingActivity()
    {

        _listPrompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

        // _userEntries = userEntries;
    }

    public ListingActivity(string activityName, string description): base (activityName, description)
    {
        // inherits parameters from base class Activity
    }

    public string GetListPrompt()
    {
        return GetRandom(_listPrompts);
    }
    public void ListCountdown()
    {
        string listPrompt = GetListPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {listPrompt} ---");
        DisplayCountdown("You may begin in: ", 4);
        Console.WriteLine();
    }
    public int GetEntries(int _durationInt)
    {
        Stopwatch sw = new Stopwatch();

        this.sw.Start();
        double _durationMill = _durationInt * 1000;
        double acc = 0.0;
        List<string> buf = new List<string>();
        int total = 0;

        Console.Write(">");

        //start counting here
        while (acc <= _durationMill)
        {
            acc += this.GetDeltaTime();
            if (!Console.KeyAvailable)
            {
                continue;
            }

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                total ++;

                Console.WriteLine("");
                // buf.Add("\n");
                Console.Write(">");
            }
            else
            {
                _userEntries.Add(key.KeyChar.ToString());
            }
        }
        Console.WriteLine($"\nYou listed {total} items.");
        return total;
    }


    // public void DisplayListCount()
    // {
    //     Console.WriteLine($"You listed {total} items.");
        
    // }

}