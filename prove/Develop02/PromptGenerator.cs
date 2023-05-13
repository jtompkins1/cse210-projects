// Class: PromptGenerator
// Attributes:
// * _prompts: list

// Behaviors:
// GetPrompt():string


using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public Random random = new Random();
    public string _prompt;
    public List<string> _prompts = new List<string>(){
        "What is one thing I'm looking forward to?\n> ",
        "What am I most grateful for today?\n> ", 
        "How did I see the hand of the Lord in my life today?\n> ",
        "What was the best part of my day?\n> ", 
        "What did I learn today?\n> ", 
        "What was the most challenging thing I faced today?\n> "
    };

    public string GetPrompt()
    {
        int random_index = random.Next(_prompts.Count);
        _prompt = _prompts[random_index];

        return _prompt;

    }
    public void ViewPrompts()
    {
        foreach (string _prompt in _prompts)
        {
            Console.WriteLine(_prompt);
        }
    }

}