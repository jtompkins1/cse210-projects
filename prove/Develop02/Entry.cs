using System;

// Class: Entry
// Attributes:
    // _date : string
    // _prompt : string
    // _response : string
    // _entry : string
// Behaviors:
    // DisplayPrompt() : string
    // GetUserResponse() : string
    // GetDate() : string
    // GetEntry() : string

public class Entry
{
    PromptGenerator getPrompt = new PromptGenerator();
    public string _prompt;
    public string _response;
    public string _date;
    public string _entry;


    public string DisplayPrompt()
    {
        _prompt = getPrompt.GetPrompt();
        Console.Write($"{_prompt}\n>");
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
        _entry = ($"Date: {_date} | Prompt: {_prompt} | {_response}");
        return _entry;

    }
}
