using System;

public class ChecklistGoal: Goal
{
    protected int _bonus = 0;
    private int _requiredCount = 0;
    private int _completedCount = 0;
    private string _goalStr;
    private Goal goal;

    public ChecklistGoal (string name, string description, int points, int bonus, int completedCount, int requiredCount) : base (name, description, points)
    {
        _bonus = bonus;
        _completedCount = completedCount;
        _requiredCount = requiredCount;
        
    }
    public int GetRequiredCount()
    {
        return _requiredCount;
    }
    public void SetRequiredCount(int requiredCount)
    {
        _requiredCount = requiredCount;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public int GetCompletedCount()
    {
        return _completedCount;
    }
    public override int RecordEvent()
    {
        _completedCount += 1;
        if (_completedCount == _requiredCount){
            return _bonus + GetPoints();
        }else
        {
            return GetPoints();
        }
    }
    public override bool IsComplete()
    {
        if (_completedCount == _requiredCount)
        {
            return true;
        }else
        return false;
    }
    public override string GoalToString()
    {
        _goalStr = ($"Checklist Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}, {((ChecklistGoal)goal).GetBonus()} | {((ChecklistGoal)goal).GetCompletedCount()} | {((ChecklistGoal)goal).GetRequiredCount()}");

        return _goalStr;
    }
}