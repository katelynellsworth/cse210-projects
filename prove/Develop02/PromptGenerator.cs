using System;

public class PromptGenerator
{
    List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you eat today?",
        "How was the weather?",
        "What superpower would have helped the most today?",
        "What parts of nature did you notice today?",
        "What can you do tommorrow to make it a better day than today?"
    };

    public PromptGenerator()
    {

    }

    public PromptGenerator(List<string> prompts)
    {
        this.prompts = prompts;
    }
///
/// Returns a random prompt from the list of prompts
///
    public string RandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, prompts.Count);
        return prompts[number];
    }
    
}