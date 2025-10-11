public static class PromptGenerator
{
    public static Random random = new Random();
    public static List<string> prompts = new List<string>
    {
        "What was the highlight of my day?",
        "What challenged me today?",
        "What's something funny or unexpected that happened today?",
        "What's one thing I accomplished today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    
    public static string GeneratePrompt()
    {
        return prompts[random.Next(0, prompts.Count)];
    }


}