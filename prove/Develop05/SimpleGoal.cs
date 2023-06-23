using System;

public class SimpleGoal: Goal
{
    private bool _complete = false;

    public SimpleGoal(string name, string description, int points, bool complete) : base (name, description, points)
    {
        _complete = complete;
    }
    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return _complete;
    }
    public void SetComplete(bool complete)
    {
        _complete = complete;
    }
}

