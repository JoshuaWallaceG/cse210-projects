using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    private static List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public static Random random = new Random();

    public void DoActivity()
    {
        base.PrintStartingMessage();
        _duration = base.PromptAndReturnSessionLength();
        Console.Clear();
        base.PlayGetReadyCycle();
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{_listingPrompts[random.Next(0, _listingPrompts.Count)]}---\n");
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
        Console.WriteLine($"You listed {listCounter} items!");

        Console.WriteLine();
        base.PlayEndingMessageCycle();

    }
}