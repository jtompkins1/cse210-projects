using System;
using System.Collections.Generic;
using System.IO;

public class FileManagement
{
    public void SaveGoals(string filename, int totalScore, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalScore);

            foreach(Goal goal in goals)
            {
                if(goal is SimpleGoal){
                    if (goal.IsComplete()== true)
                    {
                        outputFile.WriteLine($"Simple Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}, True");
                    }else
                    {
                        outputFile.WriteLine($"Simple Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}, False");
                    }
                }else if (goal is EternalGoal)
                {
                    outputFile.WriteLine($"Eternal Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}");
                }else if (goal is ChecklistGoal)
                {
                    outputFile.WriteLine($"Checklist Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}, {((ChecklistGoal)goal).GetBonus()} | {((ChecklistGoal)goal).GetCompletedCount()} | {((ChecklistGoal)goal).GetRequiredCount()}");
                }
            }
        }

        // public void LoadGoals(string fileName)
        // {
        //     using (StreamReader inputFile = new StreamReader(fileName))
        //     {
        //         string totalLine = inputFile.ReadLine();
        //         int totalScore = int.Parse(totalLine);
        //         _totalScore = totalScore;

        //         string line = inputFile.ReadLine();
        //         while (line != null)
        //         {
        //             string [] goalInfo = line.Split("|");
        //             string goalType = goalInfo[0];
        //             string name = goalInfo[1];
        //             string description = goalInfo[2];
        //             int points = int.Parse(goalInfo[3]);

        //             if (goalType == "Eternal Goal")
        //             {
        //                 EternalGoal goal1 = new EternalGoal(name, description, points);
        //             }
        //             else if (goalType == "Simple Goal")
        //             {
        //                 bool complete = bool.Parse(goalInfo[4]);
        //                 SimpleGoal goal2 = new SimpleGoal(name, description, points);
        //                 //complete true or false??
                        
        //             }else if (goalType == "Checklist Goal")


        //         }



        //     }

        // }

    }
}