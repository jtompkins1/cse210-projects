using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public Random random = new Random();
    public string _entry;
    public List<string> _prompts = new List<string>(){
        "What is one thing I'm looking forward to?",
        "What am I most grateful for today?", 
        "How did I see the hand of the Lord in my life today?",
        "What was the best part of my day?", 
        "What did I learn today?", 
        "What was the most challenging thing I faced today?"
    };

    public string GenerateRandomPrompt()
    {
        int random_index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[random_index]);
        _entry = Console.ReadLine();
        return _entry;

    }


    
}