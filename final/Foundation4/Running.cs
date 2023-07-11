using System;

public class Running : Activity
{
    private int _distance;

    public Running(int distance, int minutes) : base (minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return Math.Round(60 / GetPace(),2);

    }
    public override double GetPace()
    {
        double distance = GetDistance();
        double minutes = GetMinutes();

        return Math.Round(minutes / distance, 2);

    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetMinutes()}) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }

}