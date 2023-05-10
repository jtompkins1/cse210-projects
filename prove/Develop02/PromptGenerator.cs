using System;

public class PromptGenerator
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>() {
            "What is one thing I'm looking forward to?",
            "What am I most grateful for today?", 
            "How did I see the hand of the Lord in my life today?",
            "What was the best part of my day?", 
            "What did I learn today?", 
            "What was the most challenging thing I faced today?"
        };

    foreach (string prompt in prompts)
    {
        Console.WriteLine(prompt);
    }
    }
    
}