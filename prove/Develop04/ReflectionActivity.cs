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
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private static List<string> _reflectionPrompts = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public static Random random = new Random();

    public void DoActivity()
    {
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