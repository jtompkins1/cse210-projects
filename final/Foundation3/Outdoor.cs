using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather, string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {
        _weather = weather;
    }
    // public string GetWeatherInfo()
    // {
    //     return _weather;
    // }
    public override void DisplayFullDetails()
    {

        Console.WriteLine("Event Type: Outdoor");
        Console.WriteLine($"Weather: {_weather}");
        DisplayStandardDetails();

    }
    public override void DisplayShortDescription()
    {
        Console.WriteLine("Event Type: Outdoor");
        ShowTitleDate();
    }

}