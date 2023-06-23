using System;

public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {

    }
    public override bool IsComplete()
    {
        //will always return false as eternal goal is never completed
        return false;
    }
    public override int RecordEvent()
    {
        return GetPoints();
    }
}