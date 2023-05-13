using System;
using System.Collections.Generic;

// Class: PromptGenerator
// Attributes:
//     _prompt : string
//     _prompts : List<string>
// Behaviors:
//     GetPrompt() : string
//     ViewPrompts() : void
public class PromptGenerator
{
    public Random random = new Random();
    public string _prompt;
    public List<string> _prompts = new List<string>(){
        "What is one thing I'm looking forward to?",
        "What am I most grateful for today?", 
        "How did I see the hand of the Lord in my life today?",
        "What was the best part of my day?", 
        "What did I learn today?", 
        "What was the most challenging thing I faced today?"
    };

    public string GetPrompt()
    {
        int random_index = random.Next(_prompts.Count);
        _prompt = _prompts[random_index];

        return _prompt;

    }
    public void ViewPrompts()
    {
        Console.WriteLine();
        Console.WriteLine("Viewing list of prompts...");
        foreach (string _prompt in _prompts)
        {
            Console.WriteLine(_prompt);
        }
    }

}