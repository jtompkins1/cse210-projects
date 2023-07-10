using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, int minutes, DateTime date) : base (minutes, date)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {

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