using System;

public class SimpleGoal: Goal
{
    private bool _complete = false;
    private string _goalStr;
    private Goal goal;

    public SimpleGoal(string name, string description, int points, bool complete) : base (name, description, points)
    {
        _complete = complete;
    }
    public override int RecordEvent()
    {
        _complete = true;
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
    public override string GoalToString()
    {
        if (goal.IsComplete()== true)
        {
            _goalStr = ($"Simple Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}, True");
        }else
        {
            _goalStr = ($"Simple Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}, False");
        }
        return _goalStr;
    }
}

