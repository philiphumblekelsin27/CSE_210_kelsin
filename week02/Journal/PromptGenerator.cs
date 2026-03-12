using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string GetRandomPrompt()
    {
        if (_prompts.Count > 0)
        {
            return _prompts[0];
        }
        return "No prompts available.";
    }
}