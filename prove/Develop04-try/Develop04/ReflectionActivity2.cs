using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    protected string _question;
    protected string _thoughtPrompt;
    protected List<string> _thoughtPrompts = new List<string>(){
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
        };
    protected List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?", 
        "How did you feel when it was complete?", 
        "How did you get started?",
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
        };
    
    public ReflectionActivity()
    {
        _thoughtPrompts = new List<string>(){
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>(){
        "Why was this experience meaningful to you?", 
        "How did you feel when it was complete?", 
        "How did you get started?",
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
        };
    }
        public ReflectionActivity(List<string> thoughtPrompts, List<string> questions)
    {
        _thoughtPrompts = thoughtPrompts;
        _questions = questions;
    }

    public ReflectionActivity(string activityName, string description) : base (activityName, description)
    {
        // inherits parameters from base class Activity
    }


    //Behaviors:
    public string GetQuestion()
    {
        SetQuestion(_questions);
        return _question;
    }
    private void SetQuestion(List<string> _questions)
    {
        _question = GetRandom(_questions);
    }
    public string GetThoughtPrompt()
    {
        SetThoughtPrompt(_thoughtPrompts);
        return _thoughtPrompt;
    }
    private void SetThoughtPrompt(List<string> _thoughtPrompts)
    {
        _thoughtPrompt = GetRandom(_thoughtPrompts);
    }
    public void DisplayThoughtPrompt()
    {
        string thoughtPrompt = GetThoughtPrompt();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {thoughtPrompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
    }
    public void DisplayQuestion(string question)
    {
        // Console.WriteLine("When you have something in mind, press enter to continue.");
        // string enter = Console.ReadLine();

        // if (enter == "")
        // {
        //     Console.WriteLine(question);
        // }

        Console.WriteLine($"{question}");
    }
}