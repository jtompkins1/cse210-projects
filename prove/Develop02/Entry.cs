using System;

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
    public string CombineEntryElements()
    {
        _entry = ($"Date: {_date} | Prompt: {_prompt} | {_response}");
        Console.WriteLine(_entry);

        return _entry;

    }

    
}
// Class: Entry
// Attributes:

// * _date : string
// * _response : string
// * _prompt: string

// Behaviors:
// Response(): string
// Display(): string


