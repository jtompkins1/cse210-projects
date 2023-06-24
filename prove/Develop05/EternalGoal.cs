using System;


public class EternalGoal: Goal
{
    private string _goalStr;
    private Goal _goal;

    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        _goal = this;
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
    public override string GoalToString()
    {
        _goalStr = ($"Eternal Goal | {_goal.GetName} | {_goal.GetDescription()} | {_goal.GetPoints()}");

        return _goalStr;
    }
}