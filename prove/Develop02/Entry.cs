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
    PromptGenerator getPrompt = new PromptGenerator();
    public string _prompt;
    public string _response;
    public string _date;
    public string _entry;
    public List<string> _allEntries = new List<string>();


    public string DisplayPrompt()
    {
        _prompt = getPrompt.GetPrompt();
        Console.Write(_prompt);
        return _prompt;
    }
    public string GetUserResponse()
    {
        _response = Console.ReadLine();
        return _response;
    }
    public string GetDate()
    {
        DateTime todaysDate = DateTime.Today;
        _date = todaysDate.ToShortDateString();
        return _date;
    }
    public string GetEntry(string _date, string _prompt, string _response)
    {
        _entry = ($"{_date} | {_prompt} | {_response}");
        return _entry;

    }
}

