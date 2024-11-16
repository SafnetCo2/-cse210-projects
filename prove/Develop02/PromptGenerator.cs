using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Any progress with your goals?",
            "What steps are you taking to achieve your goals?",
            "What motivates you to stay committed to your goals?",
            "What challenges have you faced while working towards your goals?",
            "What short-term milestones have you set for your goals?",
            "What are you grateful for today?",
            "What is something you achieved recently?",
            "Describe a moment that made you happy today.",
            "What is a challenge you overcame recently?"

        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
