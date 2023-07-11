using System;

public class Lecture : Event
{
    public string _speaker;
    public int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;

    }

    // public string GetSpeaker()
    // {
    //     return _speaker;
    // }
    // public int GetCapacity()
    // {
    //     return _capacity;
    // }
    public override void DisplayFullDetails()
    {
        Console.WriteLine("Event Type: Lecture");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        DisplayStandardDetails();

    }
    public override void DisplayShortDescription()
    {
        Console.WriteLine("Event Type: Lecture");
        ShowTitleDate();

    }

}