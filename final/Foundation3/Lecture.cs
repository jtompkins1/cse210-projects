using System;

public class Lecture : Event
{
    public string _speaker;
    public int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, DateTime date, DateTime time, Address address) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;

    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }

}