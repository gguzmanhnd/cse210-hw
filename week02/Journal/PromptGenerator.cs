using System;
using System.Collections.Generic;


public class PromptGenerator
{
    
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day",
        "Who was the most interesting person I interacted with today",
        "What made me smile today",
        "What is one thing i learned today",
        "what could I improve tomorrow"

    };

    public String GetRandomPrompt()
    {
        Random  random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
