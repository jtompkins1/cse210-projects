using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather, string title, string description, DateTime date, DateTime time, Address address) : base (title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GetWeatherInfo()
    {
        return _weather;
    }

}