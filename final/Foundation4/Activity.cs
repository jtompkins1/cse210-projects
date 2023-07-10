using System;

public abstract class Activity
{
    private int _minutes;
    private DateTime _date;

    public Activity(int minutes, DateTime date)
    {
        _minutes = minutes;
        _date = date;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}
