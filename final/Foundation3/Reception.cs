using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    // public string GetEmail()
    // {
    //     return _rsvpEmail;
    // }
    public override void DisplayFullDetails()
    {
        Console.WriteLine("Event Type: Reception");
        Console.WriteLine($"RSVP Email: {_rsvpEmail}");
        DisplayStandardDetails();

    }
    public override void DisplayShortDescription()
    {
        Console.WriteLine("Event Type: Reception");
        ShowTitleDate();

    }
}