using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>();
        _questions = new List<string>();
        //  Populate _prompts and _questions lists
    }

    public void Run()
    {
        
    }

    public string GetRandomPrompt()
    {
        
        return "";
    }

    public string GetRandomQuestion()
    {
        
        return "";
    }

    public void DisplayPrompt()
    {
        
    }

    public void DisplayQuestions()
    {
        
    }
}
