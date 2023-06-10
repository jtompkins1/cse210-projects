using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _listPrompts = new List<string>();
    protected List<string> _userEntries = new List<string>();
    protected string _userEntry;

    public ListingActivity(string activityName, string description, int durationInt): base (activityName, description, durationInt)
    {
        // inherits activityName, description, and durationInt from Activity class

        _listPrompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };
    }
    public ListingActivity(List<string> listPrompts, string activityName, string description, int durationInt): base (activityName, description, durationInt)
    {
        // inherits activityName, description, and durationInt from Activity class

        _listPrompts = listPrompts;
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
    public double GetEntries(int durationInt)
    {
        StartActivity();
        double _durationMill = _durationInt * 1000;
        double acc = 0.0;
        List<string> buf = new List<string>();
        int total = 0;

        Console.Write(">");

        //start counting here
        while (acc <= _durationMill)
        {
            acc += this.DeltaTime();
            if (!Console.KeyAvailable)
            {
                continue;
            }

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                total ++;

                Console.WriteLine("");
                Console.Write(">");
            }
            else
            {
                _userEntries.Add(key.KeyChar.ToString());
            }
        }

        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"You listed {total} items.");

        return acc;
    }

}