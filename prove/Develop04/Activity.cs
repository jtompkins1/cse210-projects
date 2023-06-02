using System;

public class Activity
{
    protected string _activityName;
    private string _description;
    private int _durationInt;
    private string _durationString;

    public Activity(string activityName, string description, int durationInt)
    {
        _activityName = activityName;
        _description = description;
        _durationInt = durationInt;
    }

    // Behaviors:
    // public CountDownTimer() : void
    // public PausingAnimation() : void
    // public GetDuration() : int
    // public GetActivityName() : string
    // public GetDescription() : string
    // public DisplayStartMessage() : string
    // public DisplayEndMessage() : string
    // public GetRandom(): string
}