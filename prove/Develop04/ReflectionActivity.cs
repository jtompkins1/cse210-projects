using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _thoughtPrompts = new List<string>(){"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>(){"Why was this experience meaningful to you?", "How did you feel when it was complete?", "How did you get started?","What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public ReflectionActivity(string activityName, string description) : base (activityName, description)
    {
        // inherits parameters from base class Activity
    }
    // Behaviors:
    // private GetThoughtPrompt() : string
    // private GetQuestion() : string

}