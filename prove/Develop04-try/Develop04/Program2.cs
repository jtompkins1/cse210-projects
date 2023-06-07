using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        string menuSelection = "";
        string activityName;
        int durationInt;
        string thoughtPrompt;
        string question;
        string listPrompt;

        do
        {
            List<string> _menu = new List<string> {"Start Breathing Activity", "Start Reflection Activity", "Start Listing Activity", "Quit" };
            Console.WriteLine("Menu Options:");

            for (int i = 0; i < _menu.Count; i++)
            {
                string menuItem = _menu[i];
                Console.WriteLine($" {i + 1}. {menuItem}");
            }
            
            Activity a = new Activity();
            menuSelection = a.GetMenuSelection();
            a.SetActivityName(menuSelection);
            activityName = a.GetActivityName();

            Console.WriteLine($"Menu Selection: {menuSelection} Activity Name: {activityName}");



            if (menuSelection == "1" || menuSelection == "2" || menuSelection == "3")
            {
                //Console.Clear();
                a.DisplayStartMessage(menuSelection, activityName);
                Console.WriteLine();

                durationInt = a.GetDuration();
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(durationInt);
                //Console.Clear();

                Console.WriteLine("Get Ready...");
                a.PausingAnimation();
                Console.WriteLine();
                
                if (menuSelection == "2")
                {
                    ReflectionActivity r = new ReflectionActivity();
                    // thoughtPrompt = r.GetThoughtPrompt();
                    r.DisplayThoughtPrompt();

                    question = r.GetQuestion();
                    r.DisplayQuestion(question);

                }else if (menuSelection == "1")
                {
                    while (DateTime.Now < endTime)
                    do
                    {
                        BreathingActivity b = new BreathingActivity();
                        b.GetBreathing();
                    }while (DateTime.Now < endTime);

                }else if (menuSelection == "3")
                {
                    ListingActivity l = new ListingActivity();
                    listPrompt = l.GetListPrompt();
                    l.DisplayListPrompt(listPrompt);
                }

                a.DisplayEndMessage(menuSelection, activityName, durationInt);

            }else if (menuSelection == "4")
            {
                break;

            }
            
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***Invalid selection, try again.***");
                Console.ResetColor();
                Console.WriteLine();
            }

        }while (menuSelection != "4");

        Console.WriteLine("Thank you for using the Mindfulness program! Goodbye!");

        
    }
}