using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string title, string description, DateTime date, DateTime time, Address address) : base (title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public string GetEmail()
    {
        return _rsvpEmail;
    }
}