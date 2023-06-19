using System;

public class ChecklistGoal: Goal
{
    protected int _bonus;
    private int _requiredCount;
    private int _completedCount;
    private bool _complete = false;
 
    public ChecklistGoal (string goalType, string name, string description, int points, int bonus, int requiredCount, int completedCount, bool complete) : base (goalType, name, description, points)
    {
        _bonus = bonus;
        _requiredCount = requiredCount;
        _completedCount = completedCount;
        _complete = complete;
        
    }


}