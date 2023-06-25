using System;
using System.Collections.Generic;
using System.IO;

public class FileManagement
{
    protected int _totalScore;

    public FileManagement()
    {
        
    }
    public void SaveGoals(string filename, int totalScore, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalScore);

            foreach(Goal goal in goals)
            {
                string _goalStr = goal.GoalToString();
                outputFile.WriteLine(_goalStr);
            }
        }
    }
    public int LoadGoals(string fileName, List<Goal> goals)
    {
        goals.Clear();
        using (StreamReader inputFile = new StreamReader(fileName))
        {
            string totalLine = inputFile.ReadLine();
            int totalScore = int.Parse(totalLine);
            _totalScore = totalScore;

            string line = inputFile.ReadLine();
            while (line != null)
            {
                string [] goalInfo = line.Split(": ");
                string goalType = goalInfo[0];
                string [] goalDetails = goalInfo[1].Split(" | ");
                string name = goalDetails[0];
                string description = goalDetails[1];
                int points = int.Parse(goalDetails[2]);
                
                if (goalType == "Eternal Goal")
                {
                    EternalGoal goal1 = new EternalGoal(name, description, points);
                    goals.Add(goal1);
                }
                else if (goalType == "Simple Goal")
                {
                    bool complete = bool.Parse(goalDetails[3]);
                    SimpleGoal goal2 = new SimpleGoal(name, description, points, complete);
                    goals.Add(goal2);
          
                }else if (goalType == "Checklist Goal")
                {
                    int bonus = int.Parse(goalDetails[3]);
                    int completedCount = int.Parse(goalDetails[4]);
                    int requiredCount = int.Parse(goalDetails[5]);
                    ChecklistGoal goal3 = new ChecklistGoal(name, description, points, bonus, completedCount, requiredCount);
                    goals.Add(goal3);

                }
                line = inputFile.ReadLine();
            }
            return _totalScore;
        }
        
    }


}