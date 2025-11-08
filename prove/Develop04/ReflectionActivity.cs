using System.Reflection.Metadata;

public class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    private static List<string> _questionPrompts = new List<string>
    {
        "Think of a time when you chose patience instead of frustration.",
        "Think of a time when you apologized sincerely and it mattered.",
        "Think of a time when you kept going even though you were exhausted.",
        "Think of a time when you were scared but acted with courage anyway.",
        "Think of a time when you chose to be honest even though it was hard.",
        "Think of a time when you showed kindness that no one else saw.",
        "Think of a time when you listened deeply to someone who needed to talk.",
        "Think of a time when you took responsibility for something meaningful.",
        "Think of a time when you chose to do the right thing even when no one knew.",
        "Think of a time when you peacefully walked away from conflict.",
        "Think of a time when you took care of yourself in a healthy way."
    };
    private static List<string> _reflectionPrompts = new List<string>
    {
        "What was the most surprising part of this experience?",
        "Who supported or encouraged you during this experience?",
        "What did you notice changing in yourself as you continued?",
        "What qualities did you use that you're glad you have?",
        "What skills did this experience help you express or develop?",
        "What do you wish you could thank your past self for in this process?",
        "What emotions of joy or peace came up along the way?",
        "What part of this experience do you want to remember most clearly?",
        "How does this experience reflect what matters most to you?",
        "What strengths did this experience help reveal or affirm?",
        "What opportunities or blessings did this experience create?",
        "What does this experience teach you about the kind of person you are becoming?",
        "What was the most meaningful moment within this experience?",
        "What is something beautiful or good you saw in yourself during this?",
        "How can you gently carry the feeling of this experience with you forward?"
    };
    public static Random random = new Random();

    public void DoActivity()
    {
        Console.Clear();
        base.PrintStartingMessage();
        _duration = base.PromptAndReturnSessionLength();
        Console.Clear();
        base.PlayGetReadyCycle();
        Console.Clear();
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{_questionPrompts[random.Next(0, _questionPrompts.Count)]}---\n");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions and how they related to that experience.");
        Console.Write("You will begin in: ");
        base.CountDown(5);
        Console.Clear();

        //We use our spinner animation as a 1 second clock. Each time that 5 seconds (or loops) have passed, it prints a new prompt. It goes until our duration is up
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        for(int i = 0; DateTime.Now < endTime; i++)
        {
            if(i % 5 == 0)
            {
                Console.Write($"\n{_reflectionPrompts[random.Next(0, _reflectionPrompts.Count)]} ");
            }
            base.SpinnerAnimation(1);
        }
        Console.WriteLine();
        base.PlayEndingMessageCycle();

    }
}