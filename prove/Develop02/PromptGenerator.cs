using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "What is something you achieved recently?",
            "Describe a moment that made you happy today.",
            "What is a challenge you overcame recently?",
            "What is a goal you are working towards?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
