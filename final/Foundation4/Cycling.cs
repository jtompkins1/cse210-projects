using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, int minutes, DateTime date) : base (minutes, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {

    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {

    }
    public override string GetSummary()
    {
        
    }
}