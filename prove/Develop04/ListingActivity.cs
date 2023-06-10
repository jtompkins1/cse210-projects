using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _listPrompts = new List<string>();
    protected List<string> _userEntries = new List<string>();
    protected string _userEntry;

    protected Stopwatch sw2 = new Stopwatch();

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
    public List<string> GetEntries(int _durationInt)
    {


        sw2.Start();
        double acc = 0.0;
        List<string> buf = new List<string>();
        double _durationMill = _durationInt * 1000;


        //start counting here
        while (acc <= _durationMill)
        {
            acc += GetDeltaTime();
            Console.Write("> ");
            _userEntry = Console.ReadLine();
            _userEntries.Add(_userEntry);

            if (!Console.KeyAvailable)
            {
                continue;
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
                buf.Add("\n");
            }
            else
            {
                buf.Add(key.KeyChar.ToString());
            }
            
        }
        return _userEntries;
    }


    public void DisplayListCount(List<string> _userEntries)
    {
        Console.WriteLine($"You listed {_userEntries.Count} items.");
        
    }

}
