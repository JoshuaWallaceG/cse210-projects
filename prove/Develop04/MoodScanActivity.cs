using System.Reflection.Metadata;

public class MoodScanActivity : Activity
{
    public MoodScanActivity()
    {
        _name = "Mood Scan Activity";
        _description = "This activity will help you identify how you currently feel and help identify what things are contributing to your feelings and current mood.";
    }

    public static Random random = new Random();

    public void DoActivity()
    {
        base.PrintStartingMessage();
        _duration = base.PromptAndReturnSessionLength();
        Console.Clear();
        base.PlayGetReadyCycle();
        Console.Clear();
        Console.WriteLine("Take a moment to reflect and identify: how do you feel right now? What is your current mood?");
        base.SpinnerAnimation(3);
        Console.WriteLine("Once you are ready to identify and list the factors contributing to your current mood, press enter.");
        Console.ReadLine();
        Console.WriteLine("Now list as many of the factors contributing to your current mood. (Examples: Family, School, Social Media, Food)");
        Console.Write("You will begin in: ");
        base.CountDown(5);
        Console.Write("Now!\n");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int listCounter = 0;
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            listCounter++;
        }
        Console.WriteLine($"You identified {listCounter} things contributing to your mood!");

        Console.WriteLine();
        base.PlayEndingMessageCycle();

    }
}