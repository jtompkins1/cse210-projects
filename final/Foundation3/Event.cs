using System;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    public Event (string title, string description, DateTime date, DateTime time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }
    public void DisplayStandardDetails()
    {

    }
    public void DisplayFullDetails()
    {

    }
    public void DisplayShortDescription()
    {
        
    }
}