using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, int minutes) : base (minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double minutes = GetMinutes();
        return Math.Round(_speed * (minutes / 60),2);

    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return Math.Round((60 / _speed),2);

    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetMinutes()}) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
        
    }
}