using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        //  sample prompts
        _prompts = new List<string>
        {
            "Did you pray today?",
            "which hymn did you sing",
            "did you smile or you was moody?",
            "Reflect on a challenge you faced recently.",
            "name other things to do today?"
        };
    }

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "No prompts available.";
        }

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }


    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }
}
