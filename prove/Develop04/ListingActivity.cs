using System;
using System.Collections.Generic;

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

    // public GetListPrompt() : string
    public string GetListPrompt()
    {
        return GetRandom(_listPrompts);

    }
    public void ListCountdown()
    {
        string listPrompt = GetListPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {listPrompt} ---");
        GetCountdown("You may begin in: ", 4);
        Console.WriteLine();
    }

    public void DisplayListPrompt(string listPrompt)
    {
        Console.WriteLine(listPrompt);
    }

    public List<string> GetEntries()
    {
        Console.Write("> ");
        _userEntry = Console.ReadLine();
        _userEntries.Add(_userEntry);
        return _userEntries;
    }

    public void DisplayListCount(List<string> _userEntries)
    {
        Console.WriteLine($"You listed {_userEntries.Count} items.");
        
    }

}
