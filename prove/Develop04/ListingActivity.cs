using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _listPrompts = new List<string>();
    private List<string> _userEntries = new List<string>();
    private int _entryCount;

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
    public void DisplayListPrompt(string listPrompt)
    {
        Console.WriteLine(listPrompt);
    }

//     // Behaviors:
//     // public GetEntryCount() : int
//     // public DisplayEntryCount() : void

//     // public GetEntries() : List<string>

}
