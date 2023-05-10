// Class: Entry
// Attributes:

// * _date : string
// * _response : string
// * _prompt: string

// Behaviors:
// Response(): string
// Display(): string

using System;

public class Entry
{
    public string _prompt;
    public string _entry;
    public string _date;
    public List<string> _allEntries = new List<string>();


    public string GetUserEntry()
    {
        _entry = Console.ReadLine();
        return _entry;
    }
}

