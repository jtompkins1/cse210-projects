using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, int minutes) : base (minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round((_laps * 50) / (1000 * 0.62), 2);

    }
    public override double GetSpeed()
    {
        double distance = GetDistance();
        double minutes = GetMinutes();

        return Math.Round((distance/minutes) * 60, 2);

    }
    public override double GetPace()
    {
        double distance = GetDistance();
        double minutes = GetMinutes();

        return Math.Round(minutes / distance, 2);

    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetMinutes()}) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");

        
    }
}