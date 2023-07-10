using System;

public class Running : Activity
{
    private int _distance;

    public Running(int distance, int minutes, DateTime date) : base (minutes, date)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {

    }
    public override double GetPace()
    {

    }
    public override string GetSummary()
    {
        
    }

}