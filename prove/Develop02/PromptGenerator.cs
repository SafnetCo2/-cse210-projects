using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Did you pray today?",
        "Which hymn did you sing?",
        "Did you smile or were you moody?",
        "Reflect on a challenge you faced recently.",
        "Name other things to do today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count); 
        return _prompts[index];
    }
}
