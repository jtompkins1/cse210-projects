using System;

public class SimpleGoal: Goal
{
    private bool _complete;

    public SimpleGoal(string goalType, string name, string description, int points, bool complete) : base (goalType, name, description, points)
    {
        _complete = complete;
    }
}

