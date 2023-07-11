using System;

public abstract class Activity
{
    private double _minutes;
    private string _date;

    public Activity(double minutes)
    {
        _minutes = minutes;
        _date = DateTime.Now.ToString("dd MMM yyyy");
    }
    public double GetMinutes()
    {
        return _minutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract void DisplaySummary();
}
