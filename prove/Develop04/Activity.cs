// using System;

// public class Activity
// {
//     protected string _activityName;
//     private string _description;
//     private int _durationInt;
//     private string _durationString;

//     public Activity()
//     {
//         _activityName = GetActivity();
//         _description = GetDescription(_activityName);
//         _durationInt = GetDuration();
//     }

//     public Activity(string activityName, string description, int durationInt)
//     {
//         _activityName = activityName;
//         _description = description;
//         _durationInt = durationInt;
//     }



//     // public CountDownTimer() : void
//     // public PausingAnimation() : void

//     public void PausingAnimation()
//     {
//         Console.WriteLine("Get Ready");
//     }

//     // public GetActivityName() : string
//     public string GetActivity()
//     {
//         _activityName = m.GetActivityName();
//         return _activityName;
//     }
//     // public GetDescription() : string
//     public string GetDescription(string activityName)
//     {
//         if (activityName == "Breathing Activity")
//         {
//             _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
//         }else if (activityName == "Reflection Activity")
//         {
//             _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
//         }else if (activityName == "Listing Activity")
//         {
//             _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
//         }
//         return _description;
//     }
//     // public DisplayStartMessage() : string
//     public void DisplayStartMessage(string activityName, string description, int durationInt)
//     {
//         Console.WriteLine($"Welcome to the {activityName}.");
//         Console.WriteLine();
//         Console.WriteLine(_description);
//         GetDuration();
//     }

//     // public GetDuration() : int
//     public int GetDuration()
//     {
//         Console.Write("How long, in seconds, would you like for your session? ");
//         _durationString = Console.ReadLine();
//         return _durationInt = int.Parse(_durationString);

//     }

//     // public DisplayEndMessage() : string
//     // public GetRandom(): string
// }