using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event (string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Event: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");

    }
    public virtual void DisplayFullDetails()
    {
        Console.WriteLine("Event Type: ");
        DisplayStandardDetails();

    }
    public virtual void DisplayShortDescription()
    {
        //Console.WriteLine("Event Type: ");
        ShowTitleDate();

    }
    public void ShowTitleDate()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
        
    


}